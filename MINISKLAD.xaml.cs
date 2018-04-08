using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using SQLitePCL;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DataAppModelsMiniSklad;

using Windows.Graphics.Printing; //поддержка печати
using Windows.UI.Xaml.Printing; //поддержка печати
using System.Threading.Tasks;




namespace Мастерконд.Документы
{


    public sealed partial class MINISKLAD : Page
    {
        public ObservableCollection<SkladData> Tovari { get; set; }
        List<string> tovariListbox; //ОБЪЯВИТЬ СПИСКИ - ВАЖНО!!!!
        List<string> edListbox;
        List<string> primechanieListbox;
        List<string> artikulListbox;
        

        #region ПЕРЕМЕННЫЕ ДЛЯ ПЕЧАТИ
        private PrintManager printMan; //!!! для печати
        private PrintDocument printDoc;//!!! для печати
        private IPrintDocumentSource printDocSource;//!!! для печати
        internal List<UIElement> PreviewPages; //СПИСОК СТРАНИЦ ПРЕДПРОСМОТРА
        internal List<UIElement> Pages; //СПИСОК СТРАНИЦ, КОТОРЫЕ ПОЙДУТ НА ПЕЧАТЬ
        #endregion

        #region РЕГИСТРАЦИЯ ПЕЧАТИ
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Register for PrintTaskRequested event
            printMan = PrintManager.GetForCurrentView();
            printMan.PrintTaskRequested += PrintTaskRequested;

            // Build a PrintDocument and register for callbacks
            printDoc = new PrintDocument();
            printDocSource = printDoc.DocumentSource;
            printDoc.Paginate += Paginate;
            printDoc.GetPreviewPage += GetPreviewPage;
            printDoc.AddPages += AddPages;
        }
        #endregion

        #region ПОКАЗЫВАЕТ ДИАЛОГ ПЕЧАТИ

        private void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs args)
        {
            // Create the PrintTask.
            // Defines the title and delegate for PrintTaskSourceRequested
            var printTask = args.Request.CreatePrintTask("Print", PrintTaskSourceRequrested);

            // Handle PrintTask.Completed to catch failed print jobs
            printTask.Completed += PrintTaskCompleted;
        }

        private void PrintTaskSourceRequrested(PrintTaskSourceRequestedArgs args)
        {
            // Set the document source.
            args.SetSource(printDocSource);
        }

        #endregion

        #region НАСТРОЙКА ПРЕДПРОСМОТРА ПЕЧАТИ

        private void Paginate(object sender, PaginateEventArgs e)
        {
            PreviewPages = new List<UIElement>();
            PreviewPages.Clear();
            PreviewPages.Add(this.SkladListL);
            PreviewPages.Add(this.TextBlockCreateDocumentsOpisanie5);
            PreviewPages.Add(this.PanelZagolovokRow);
            //УСТАНАВЛИВАЕТ КОЛ-ВО СТРАНИЦ В ПРЕДПРОСМОТРЕ ПЕЧАТИ ПО КОЛ-ВУ ЭЛЕМЕНТОВ СПИСКА PREVIEWPAGES
            printDoc.SetPreviewPageCount(PreviewPages.Count, PreviewPageCountType.Intermediate);
            
        }


        private void GetPreviewPage(object sender, GetPreviewPageEventArgs e) //СТРАНИЦЫ В ПРЕДПРОСМОТР ДОБАВЛЯЮТСЯ, ВСЕ ОК
        {
            PreviewPages = new List<UIElement>();
            PreviewPages.Clear();
            PreviewPages.Add(this.SkladListL);
            PreviewPages.Add(this.TextBlockCreateDocumentsOpisanie5);
            PreviewPages.Add(this.PanelZagolovokRow);

            for (int i = 0; i < PreviewPages.Count; i++)
            {
                printDoc.SetPreviewPage(i+1, PreviewPages[i]); //ДОБАВЛЯЕМ СТРАНИЦЫ НА ПРЕДПРОСОМТР ПЕЧАТИ
            }

        }

        #endregion

        #region ДОБАВИТЬ СТРАНИЦЫ ДЛЯ ОТПРАВКИ НА ПРИНТЕР

        private void AddPages(object sender, AddPagesEventArgs e) //ДОБАВИТЬ СТРАНИЦЫ НА ПЕЧАТЬ
        {
            Pages = new List<UIElement>();
            Pages.Clear();
            
            Pages.Add(this.SkladListL);
            Pages.Add(this.TextBlockCreateDocumentsOpisanie5);
            Pages.Add(this.PanelZagolovokRow);

            for (int i = 0; i < Pages.Count; i++)
            {
                printDoc.AddPage(Pages[i]);
            }

            PrintDocument printDocument = (PrintDocument)sender;

            // Indicate that all of the print pages have been provided
            printDocument.AddPagesComplete();

            // Indicate that all of the print pages have been provided
            //printDoc.AddPagesComplete();


        }

        #endregion

        #region ЗАВЕРШИТЬ ЗАДАНИЕ ПЕЧАТИ

        private async void PrintTaskCompleted(PrintTask sender, PrintTaskCompletedEventArgs args)
        {
            // Notify the user when the print operation fails.
            if (args.Completion == PrintTaskCompletion.Failed)
            {
                ContentDialog noPrintingDialog = new ContentDialog()
                {
                    Title = "ОШИБКА ПЕЧАТИ",
                    Content = "\nПЕЧАТЬ НЕ УДАЛАСЬ.",
                    PrimaryButtonText = "OK"
                };
                await noPrintingDialog.ShowAsync();
            }
        }

        #endregion

        #region ОТМЕНА РЕГИСТРАЦИИ ПЕЧАТИ

        public void UnregisterForPrinting()
        {
            if (printDoc == null)
            {
                return;
            }

            printDoc.Paginate -= Paginate;
            printDoc.GetPreviewPage -= GetPreviewPage;
            printDoc.AddPages -= AddPages;

            // Remove the handler for printing initialization.
            PrintManager printMan = PrintManager.GetForCurrentView();
            printMan.PrintTaskRequested -= PrintTaskRequested;

        }


        #endregion

        #region НАЖАТИЕ НА КНОПКУ ПЕЧАТЬ
        private async void Print_Click(object sender, RoutedEventArgs e)
        {
            string M = this.SkladListL.ActualWidth.ToString();
            string L = this.SkladListL.ActualHeight.ToString();
            StatusFile.Text = "Высота SkladListL: "+L+" пикселей, ширина SkladListL: "+M+ " пикселей";

            if (PrintManager.IsSupported())
            {
                try
                {
                    // Show print UI
                    await PrintManager.ShowPrintUIAsync();
                }
                catch
                {
                    // Printing cannot proceed at this time
                    ContentDialog noPrintingDialog = new ContentDialog()
                    {
                        Title = "ОШИБКА ПЕЧАТИ",
                        Content = "\nК сожалению, печать в данный момент невозможна.",
                        PrimaryButtonText = "OK"
                    };
                    await noPrintingDialog.ShowAsync();
                }
            }
            else
            {
                // Printing is not supported on this device
                ContentDialog noPrintingDialog = new ContentDialog()
                {
                    Title = "ОТСУТСТВУЕТ ПООДЕРЖКА ПЕЧАТИ",
                    Content = "\nК сожалению, печать на этом устройстве не поддерживается.",
                    PrimaryButtonText = "OK"
                };
                await noPrintingDialog.ShowAsync();
            }

        }
        #endregion

        #region ОТМЕНА РЕГИСТРАЦИИ ПЕЧАТИ ПРИ ПЕРЕХОДЕ С ДРУГОЙ СТРАНИЦЫ
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            UnregisterForPrinting();
        }
        #endregion


        public MINISKLAD()
        {
            this.InitializeComponent();



            TextBlockArtikulTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockNKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockMyEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockSaleEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockEdIzmTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


            Tovari = new ObservableCollection<SkladData>
            {
            };

            tovariListbox = new List<string> { }; //СМ. ВАЖНО!!!
            edListbox=new List<string> { };
            primechanieListbox = new List<string> { };

            artikulListbox = new List<string> { };


            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string addSQL = @"CREATE TABLE IF NOT EXISTS SkladBase (IDTovara Integer Primary Key Autoincrement NOT NULL, TovarName Varchar(255), Kolichestvo Varchar(255), EdIzmTovara Varchar(200), MyCenaEd Varchar(200), SaleCenaEd Varchar(200), Primechanie Varchar(200), NKolichestvo Varchar(255), Artikul Varchar(255));";
            dbConnection.Prepare(addSQL).Step();


            try //ЕСЛИ БАЗЫ НЕТ, СРАЗУ СОЗДАДИМ ЕЕ И ЗАПОЛНИМ
            {
                string addSQLSettings2 = @"CREATE TABLE SKLADVISIBILITYSETTINGS (ID Integer Primary Key NOT NULL, OBJECT Varchar(255), VISIBILITY Varchar(255));";
                dbConnection.Prepare(addSQLSettings2).Step();
                string writeSQL1 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','KOLVO','VISIBLE');";
                string writeSQL2 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','NKOLVO','VISIBLE');";
                string writeSQL3 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','EDIZM','VISIBLE');";
                string writeSQL4 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','ARTIKUL','VISIBLE');";
                string writeSQL5 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','MYEDPRICE','VISIBLE');";
                string writeSQL6 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','SALEEDPRICE','VISIBLE');";
                string writeSQL7 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','PRIMECHANIE','VISIBLE');";
                dbConnection.Prepare(writeSQL1).Step();
                dbConnection.Prepare(writeSQL2).Step();
                dbConnection.Prepare(writeSQL3).Step();
                dbConnection.Prepare(writeSQL4).Step();
                dbConnection.Prepare(writeSQL5).Step();
                dbConnection.Prepare(writeSQL6).Step();
                dbConnection.Prepare(writeSQL7).Step();
            }
            catch { }

            //ДОБАВЛЯЕМ СТОЛБЕЦ NKOLICHESTVO
            try
            {
                string addSQL2 = "ALTER TABLE SkladBase ADD COLUMN NKolichestvo Varchar(255);";
                dbConnection.Prepare(addSQL2).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ NKOLICHESTVO


            //ДОБАВЛЯЕМ СТОЛБЕЦ ARTIKUL
            try
            {
                string addSQL3 = "ALTER TABLE SkladBase ADD COLUMN Artikul Varchar(255) DEFAULT '' NOT NULL;"; //ВАЖНО ДЛЯ ПОИСКА ПО AUTOSUGGESTBOXa, ЧТОБЫ НЕ NULL !!!
                dbConnection.Prepare(addSQL3).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ ARTIKUL

            try {
                //ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ CHECKBOX

            SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL1 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=1;";
            ISQLiteStatement dbState1 = dbConnection1.Prepare(readSQL1);
            while (dbState1.Step() == SQLiteResult.ROW)
            {
                string Visibility0 = dbState1["VISIBILITY"] as string;
                if (Visibility0 == "VISIBLE") { CheckBoxKolvo.IsChecked = true; KolvoVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                if (Visibility0 == "UNVISIBLE") { CheckBoxKolvo.IsChecked = false; KolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
            }

                SQLitePCL.SQLiteConnection dbConnection2 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL2 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=2;";
                ISQLiteStatement dbState2 = dbConnection2.Prepare(readSQL2);
                while (dbState2.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState2["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxNKolvo.IsChecked = true; NKolvoVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockNKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxNKolvo.IsChecked = false; NKolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockNKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection3 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL3 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=3;";
                ISQLiteStatement dbState3 = dbConnection3.Prepare(readSQL3);
                while (dbState3.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState3["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxEdIzm.IsChecked = true; EdIzmVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockEdIzmTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxEdIzm.IsChecked = false; EdIzmVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockEdIzmTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection4 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL4 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=4;";
                ISQLiteStatement dbState4 = dbConnection4.Prepare(readSQL4);
                while (dbState4.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState4["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxArtikul.IsChecked = true; ArtikulVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockArtikulTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxArtikul.IsChecked = false; ArtikulVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockArtikulTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection5 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL5 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=5;";
                ISQLiteStatement dbState5 = dbConnection5.Prepare(readSQL5);
                while (dbState5.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState5["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxMyEdPrice.IsChecked = true; MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockMyEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxMyEdPrice.IsChecked = false; MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockMyEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection6 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL6 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=6;";
                ISQLiteStatement dbState6 = dbConnection6.Prepare(readSQL6);
                while (dbState6.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState6["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxSaleEdPrice.IsChecked = true; SaleCenaVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockSaleEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxSaleEdPrice.IsChecked = false; SaleCenaVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockSaleEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection7 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL7 = "SELECT VISIBILITY FROM SKLADVISIBILITYSETTINGS WHERE ID=7;";
                ISQLiteStatement dbState7 = dbConnection7.Prepare(readSQL7);
                while (dbState7.Step() == SQLiteResult.ROW)
                {
                    string Visibility = dbState7["VISIBILITY"] as string;
                    if (Visibility == "VISIBLE") { CheckBoxPrimechanie.IsChecked = true; PrimechanieVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility == "UNVISIBLE") { CheckBoxPrimechanie.IsChecked = false; PrimechanieVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;}
                }

                //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ CHECKBOX

                Razdelitel1.Width = NChecked * 160;
                Razdelitel2.Width = NChecked * 160;
                Razdelitel3.Width = NChecked * 160;
            }

            catch
            {
                

                string writeSQL1 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','KOLVO','VISIBLE');";
                string writeSQL2 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','NKOLVO','VISIBLE');";
                string writeSQL3 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','EDIZM','VISIBLE');";
                string writeSQL4 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','ARTIKUL','VISIBLE');";
                string writeSQL5 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','MYEDPRICE','VISIBLE');";
                string writeSQL6 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','SALEEDPRICE','VISIBLE');";
                string writeSQL7 = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','PRIMECHANIE','VISIBLE');";
                dbConnection.Prepare(writeSQL1).Step();
                dbConnection.Prepare(writeSQL2).Step();
                dbConnection.Prepare(writeSQL3).Step();
                dbConnection.Prepare(writeSQL4).Step();
                dbConnection.Prepare(writeSQL5).Step();
                dbConnection.Prepare(writeSQL6).Step();
                dbConnection.Prepare(writeSQL7).Step();

                PrimechanieVisibility = Windows.UI.Xaml.Visibility.Visible;
                KolvoVisibility = Windows.UI.Xaml.Visibility.Visible;
                MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Visible;
                NKolvoVisibility = Windows.UI.Xaml.Visibility.Visible;
                SaleCenaVisibility = Windows.UI.Xaml.Visibility.Visible;
                ArtikulVisibility = Windows.UI.Xaml.Visibility.Visible;
                EdIzmVisibility = Windows.UI.Xaml.Visibility.Visible;

               // Razdelitel1.Width = 8 * 160;
               // Razdelitel2.Width = 8 * 160;
               // Razdelitel3.Width = 8 * 160;

            }

            this.Tovari.Clear();
            ReadDataBase();

            
            //Tovari.CollectionChanged += Tovari_CollectionChanged; //подписываемся на изменение коллекции
        }

        public Windows.UI.Xaml.Visibility PrimechanieVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility KolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility NKolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility SaleCenaVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility ArtikulVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility EdIzmVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public double NChecked = 1;

        public int _ID = 0;


        public void ReadDataBase()
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO=SN, IsVisiblePRIMECHANIE=PrimechanieVisibility,IsVisibleARTIKUL=ArtikulVisibility,IsVisibleEDIZM=EdIzmVisibility,IsVisibleKOLICHESTVO=KolvoVisibility,IsVisibleMYEDPRICE=MyCenaEdVisibility,IsVisibleNKOLICHESTVO=NKolvoVisibility,IsVisibleSALEEDPRICE=SaleCenaVisibility,ARTIKUL=SM });

                _ID = SNN;

                //ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ
                Buffer1.Text = "";
                foreach (string s in tovariListbox)
                {
                    if (SA == s) { Buffer1.Text = "not null"; }
                }
                if (Buffer1.Text == "") { tovariListbox.Add(SA); }
                


                Buffer2.Text = "";
                foreach (string s in edListbox)
                {
                    if (SC == s) { Buffer2.Text = "not null"; }
                }
                if (Buffer2.Text == "") { edListbox.Add(SC); }

                Buffer3.Text = "";
                foreach (string s in primechanieListbox)
                {
                    if (SF == s) { Buffer3.Text = "not null"; }
                }
                if (Buffer3.Text == "") { primechanieListbox.Add(SF); }

                Buffer4.Text = "";
                foreach (string s in artikulListbox)
                {
                    if (SM == s) { Buffer4.Text = "not null"; }
                }
                if (Buffer4.Text == "") { artikulListbox.Add(SM); }
                //КОНЕЦ ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
        }

        public void AddListSuggestBoxes()
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,Artikul FROM SkladBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SM = dbState["Artikul"] as string;

                _ID = SNN;

                //ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ
                Buffer1.Text = "";
                foreach (string s in tovariListbox)
                {
                    if (SA == s) { Buffer1.Text = "not null"; }
                }
                if (Buffer1.Text == "") { tovariListbox.Add(SA); }



                Buffer2.Text = "";
                foreach (string s in edListbox)
                {
                    if (SC == s) { Buffer2.Text = "not null"; }
                }
                if (Buffer2.Text == "") { edListbox.Add(SC); }


                Buffer3.Text = "";
                foreach (string s in primechanieListbox)
                {
                    if (SF == s) { Buffer3.Text = "not null"; }
                }
                if (Buffer3.Text == "") { primechanieListbox.Add(SF); }


                Buffer4.Text = "";
                foreach (string s in artikulListbox)
                {
                    if (SM == s) { Buffer4.Text = "not null"; }
                }
                if (Buffer4.Text == "") { artikulListbox.Add(SM); }

                //КОНЕЦ ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ
            }
        } //добавление данных в AutoSuggestBox'ы

        private void ContentDialogAddNewTovar_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (_ID == Tovari.Count)
            {
                Tovari.Add(new SkladData { TOVARNAME = TextBoxTovarName.Text, KOLICHESTVO = TextBoxKolichestvoTovara.Text, EDIZM = TextBoxEdIzmTovara.Text, MYEDPRICE = TextBoxMyPrice.Text, SALEEDPRICE = TextBoxSalePrice.Text, PRIMECHANIE = TextBoxPrimechanie.Text, NKOLICHESTVO = TextBoxNKolichestvoTovara.Text, ARTIKUL = TextBoxTovarArtikul.Text, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility, Id = Tovari.Count + 1 });
            }
            else
            {
                Tovari.Add(new SkladData { TOVARNAME = TextBoxTovarName.Text, KOLICHESTVO = TextBoxKolichestvoTovara.Text, EDIZM = TextBoxEdIzmTovara.Text, MYEDPRICE = TextBoxMyPrice.Text, SALEEDPRICE = TextBoxSalePrice.Text, PRIMECHANIE = TextBoxPrimechanie.Text, NKOLICHESTVO = TextBoxNKolichestvoTovara.Text, ARTIKUL = TextBoxTovarArtikul.Text, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility, Id = _ID + 1 });

            }
            StatusFile.Text = "Добавлен новый товар: " + TextBoxTovarName.Text;
            //////////////////////////////////////////////////////////////////////////////////////
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT INTO SkladBase ([IDTovara],[TovarName],[Kolichestvo],[EdIzmTovara],[MyCenaEd],[SaleCenaEd],[Primechanie],[NKolichestvo],[Artikul]) VALUES ('" + (Tovari.Count + 1) + "','" + TextBoxTovarName.Text + "','" + TextBoxKolichestvoTovara.Text + "','" + TextBoxEdIzmTovara.Text + "','" + TextBoxMyPrice.Text + "','" + TextBoxSalePrice.Text + "','" + TextBoxPrimechanie.Text + "','" + TextBoxNKolichestvoTovara.Text + "','" +TextBoxTovarArtikul.Text + "');";
            dbConnection.Prepare(writeSQL).Step();
            /////////////////////////////////////////////////////////////////////////////////////

            this.Tovari.Clear();

            ReadDataBase();
            AddListSuggestBoxes();

            TextBoxTovarName.Text = "";
            TextBoxKolichestvoTovara.Text = "";
            TextBoxNKolichestvoTovara.Text = "";
            TextBoxEdIzmTovara.Text = "";
            TextBoxMyPrice.Text = "";
            TextBoxSalePrice.Text = "";
            TextBoxPrimechanie.Text = "";
            TextBoxTovarArtikul.Text = "";

            SearchStatus.Text = "ALL";
        }

        private async void AddTovar_Click(object sender, RoutedEventArgs e)
        {
            await ContentDialogAddNewTovar.ShowAsync();
        }

        private void ContentDialogChangeTovar_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            SkladData TovarActive = (SkladData)SkladListL.SelectedItem; //выбор активного элемента коллекции, активного в XAML-элементе ListView


            TovarActive.TOVARNAME = TextBoxTovarName1.Text;
            TovarActive.EDIZM = TextBoxEdIzmTovara1.Text;
            TovarActive.KOLICHESTVO = TextBoxKolichestvoTovara1.Text;
            TovarActive.MYEDPRICE = TextBoxMyPrice1.Text;
            TovarActive.SALEEDPRICE = TextBoxSalePrice1.Text;
            TovarActive.PRIMECHANIE = TextBoxPrimechanie1.Text;
            TovarActive.NKOLICHESTVO = TextBoxNKolichestvoTovara1.Text;
            TovarActive.ARTIKUL = TextBoxTovarArtikul1.Text;
            int IDD = TovarActive.Id;


            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "UPDATE SkladBase SET TovarName='" + TextBoxTovarName1.Text + "',Kolichestvo='" + TextBoxKolichestvoTovara1.Text + "',EdIzmTovara= '" + TextBoxEdIzmTovara1.Text + "',MyCenaEd='" + TextBoxMyPrice1.Text + "',SaleCenaEd= '" + TextBoxSalePrice1.Text + "',Primechanie= '" + TextBoxPrimechanie1.Text + "',NKolichestvo='" + TextBoxNKolichestvoTovara1.Text + "',Artikul='" + TextBoxTovarArtikul1.Text + "' WHERE IDTovara='" + IDD + "';";
            dbConnection.Prepare(writeSQL).Step();

            this.Tovari.Clear();
            AddListSuggestBoxes();

            if (SearchStatus.Text == "ALL")
            {
                ReadDataBase();
            }

            if (SearchStatus.Text == "Name")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE TovarName='" + TextBoxSearchName.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {

                    int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    string SA = dbState["TovarName"] as string;
                    string SB = dbState["Kolichestvo"] as string;
                    string SC = dbState["EdIzmTovara"] as string;
                    string SD = dbState["MyCenaEd"] as string;
                    string SE = dbState["SaleCenaEd"] as string;
                    string SF = dbState["Primechanie"] as string;
                    string SN = dbState["NKolichestvo"] as string;
                    string SM = dbState["Artikul"] as string;

                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF,NKOLICHESTVO=SN,ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            
        }

            if (SearchStatus.Text == "Ed")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE EdIzmTovara='" + TextBoxSearchEd.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {

                    int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    string SA = dbState["TovarName"] as string;
                    string SB = dbState["Kolichestvo"] as string;
                    string SC = dbState["EdIzmTovara"] as string;
                    string SD = dbState["MyCenaEd"] as string;
                    string SE = dbState["SaleCenaEd"] as string;
                    string SF = dbState["Primechanie"] as string;
                    string SN = dbState["NKolichestvo"] as string;
                    string SM = dbState["Artikul"] as string;

                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO=SN,ARTIKUL=SM });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            

            if (SearchStatus.Text == "Primechanie")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE Primechanie='" + TextBoxSearchPrimechanie.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {

                    int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    string SA = dbState["TovarName"] as string;
                    string SB = dbState["Kolichestvo"] as string;
                    string SC = dbState["EdIzmTovara"] as string;
                    string SD = dbState["MyCenaEd"] as string;
                    string SE = dbState["SaleCenaEd"] as string;
                    string SF = dbState["Primechanie"] as string;
                    string SN = dbState["NKolichestvo"] as string;
                    string SM = dbState["Artikul"] as string;

                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF,NKOLICHESTVO=SN, ARTIKUL=SM });

                }

            }


            if (SearchStatus.Text == "Artikul")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE Artikul='" + TextBoxSearchArtikul.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {

                    int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    string SA = dbState["TovarName"] as string;
                    string SB = dbState["Kolichestvo"] as string;
                    string SC = dbState["EdIzmTovara"] as string;
                    string SD = dbState["MyCenaEd"] as string;
                    string SE = dbState["SaleCenaEd"] as string;
                    string SF = dbState["Primechanie"] as string;
                    string SN = dbState["NKolichestvo"] as string;
                    string SM = dbState["Artikul"] as string;

                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO = SN, ARTIKUL = SM });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            if (SearchStatus.Text == "Okonchanie")
            {
                this.Tovari.Clear();
                SQLitePCL.SQLiteConnection dbConnection0 = new SQLiteConnection("sdelkidatabase.db");
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase;";
                ISQLiteStatement dbState = dbConnection0.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {

                    int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    string SA = dbState["TovarName"] as string;
                    string SB = dbState["Kolichestvo"] as string;
                    string SC = dbState["EdIzmTovara"] as string;
                    string SD = dbState["MyCenaEd"] as string;
                    string SE = dbState["SaleCenaEd"] as string;
                    string SF = dbState["Primechanie"] as string;
                    string SN = dbState["NKolichestvo"] as string;
                    string SM = dbState["Artikul"] as string;

                    try
                    {
                        double M = Convert.ToDouble(dbState["Kolichestvo"]);
                        double MN = Convert.ToDouble(dbState["NKolichestvo"]);
                        if (MN > M)
                        {
                            Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO = SN, ARTIKUL = SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });
                        }
                    }
                    catch { }


                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            //ОБНУЛЯЕМ СОДЕРЖИМОЕ
            TextBoxTovarName1.Text="";
            TextBoxEdIzmTovara1.Text = "";
            TextBoxKolichestvoTovara1.Text = "";
            TextBoxNKolichestvoTovara1.Text = "";
            TextBoxMyPrice1.Text = "";
            TextBoxSalePrice1.Text = "";
            TextBoxPrimechanie1.Text = "";
            TextBoxTovarArtikul1.Text = "";

        }

        private async  void ContentDialogChangeTovar_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            ContentDialogChangeTovar.Hide();
            await ContentDialogDelete.ShowAsync();
        }

        private async void SkladListL_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextBoxTovarName1.Text = "";
            TextBoxEdIzmTovara1.Text = "";
            TextBoxKolichestvoTovara1.Text = "";
            TextBoxNKolichestvoTovara1.Text = "";
            TextBoxMyPrice1.Text = "";
            TextBoxSalePrice1.Text = "";
            TextBoxPrimechanie1.Text = "";
            TextBoxTovarArtikul1.Text = "";


            SkladData selectedTovar = (SkladData)e.ClickedItem;

            int NumberID = selectedTovar.Id;


            try
            {
               
                TextBoxTovarName1.Text = selectedTovar.TOVARNAME;
                TextBoxKolichestvoTovara1.Text = selectedTovar.KOLICHESTVO;
                TextBoxEdIzmTovara1.Text = selectedTovar.EDIZM;
                TextBoxMyPrice1.Text = selectedTovar.MYEDPRICE;
                TextBoxSalePrice1.Text = selectedTovar.SALEEDPRICE;
                TextBoxPrimechanie1.Text = selectedTovar.PRIMECHANIE;
            }
            catch { }

            try { TextBoxNKolichestvoTovara1.Text = selectedTovar.NKOLICHESTVO; }
            catch { }

            try { TextBoxTovarArtikul1.Text = selectedTovar.ARTIKUL; }
            catch { }

            await ContentDialogChangeTovar.ShowAsync();

        }

        private void Tovari_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) //что происходит при изменении коллекции
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                                                        //   SdelkiData newElement = e.NewItems[0] as SdelkiData;
                                                        //   StatusFile.Text = "Добавлен новый объект: " + newElement.KONTRNAME + " (номер договора " + newElement.DOGOVORNUMBER+")";
                                                        //////////////////////////////////////////////////////////////////////////////////////
                                                        //   SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                                                        //  string writeSQL = "INSERT INTO SdelkiBase ([IDSdelki],[KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma]) VALUES ('"+newElement.Id+ "','" + newElement.KONTRNAME+"','"+newElement.INAME + "','" +newElement.DOGOVORDATE + "','" +newElement.DOGOVORNUMBER + "','" +newElement.NAKLADNAJADATE + "','" +newElement.AKTDATE + "','" +newElement.RASXODI + "','" +newElement.SUMMAITOGO + "');";
                                                        //  dbConnection.Prepare(writeSQL).Step();
                                                        /////////////////////////////////////////////////////////////////////////////////////
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                                                           //SdelkiData oldElement = e.OldItems[0] as SdelkiData;
                                                           //StatusFile.Text = "Удален объект: " + oldElement.KONTRNAME + " (номер договора " + oldElement.DOGOVORNUMBER + ")";
                                                           //////////////////////////////////////////////////////////////////////////////////////
                                                           //SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
                                                           //string writeSQL1 = "DELETE FROM SdelkiBase WHERE IdSdelki="+oldElement.Id+";";
                                                           //dbConnection1.Prepare(writeSQL1).Step();
                                                           /////////////////////////////////////////////////////////////////////////////////////
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                                                            //    SdelkiData replacedElement = e.OldItems[0] as SdelkiData;
                                                            //SdelkiData replacingElement = e.NewItems[0] as SdelkiData;
                                                            //StatusFile.Text = "Объект "+replacedElement.KONTRNAME+ " " + replacedElement.DOGOVORDATE+" заменен объектом " + replacingElement.KONTRNAME +" "+ replacingElement.KONTRNAME;
                                                            ////////////////////////////////////////////////////////////////////////////////////////
                                                            //SQLitePCL.SQLiteConnection dbConnection2 = new SQLiteConnection("sdelkidatabase.db");
                                                            //string writeSQL2 = @"SELECT [KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma] FROM SdelkiBase";
                                                            //dbConnection2.Prepare(writeSQL2).Step();
                                                            /////////////////////////////////////////////////////////////////////////////////////
                    break;

            }
        }

        private void ButtonSearchName_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE TovarName='"+TextBoxSearchName.Text+"';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF,NKOLICHESTVO=SN,ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            SearchStatus.Text = "Name";
        }

        private void ButtonSearchEd_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE EdIzmTovara='" + TextBoxSearchEd.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF,NKOLICHESTVO=SN,ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            SearchStatus.Text = "Ed";
        }

        private void ButtonSearchPrimechanie_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE Primechanie='" + TextBoxSearchPrimechanie.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF,NKOLICHESTVO=SN,ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            SearchStatus.Text = "Primechanie";
        }

        private void ButtonShowWholeBase_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            ReadDataBase();
            AddListSuggestBoxes();
            SearchStatus.Text = "ALL";
        }

        private void ButtonSearchOpen_Click(object sender, RoutedEventArgs e)
        {
            string ButtonStatus = ButtonSearchOpen.Content.ToString();


            if (ButtonStatus == "+")
            {
                TextBlockSearchName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchEd.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Visible;

                TextBoxSearchName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchEd.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonSearchName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchEd.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonShowWholeBase.Visibility = Windows.UI.Xaml.Visibility.Visible;

                RazdelitelSearch.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonSearchOpen.Content = "-";
            }

            if (ButtonStatus == "-")
            {
                TextBlockSearchName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchEd.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxSearchName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchEd.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonSearchName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchEd.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchPrimechanie.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchArtikul.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonShowWholeBase.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                RazdelitelSearch.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonSearchOpen.Content = "+";
            }

        }

        private void TextBoxSearchName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args) //ОБРАБОТКА ИЗМЕНЕНИЯ ТЕКСТА В AUTOSUGGESTBOX
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchName.Text.ToLower();
                var results = tovariListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchName.ItemsSource = results;
            }
        }

        private void TextBoxSearchEd_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchEd.Text.ToLower();
                var results = edListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchEd.ItemsSource = results;
            }
        }

        private void TextBoxSearchPrimechanie_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchPrimechanie.Text.ToLower();
                var results = primechanieListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchPrimechanie.ItemsSource = results;
            }
        }

        private void ContentDialogDelete_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            SkladData DeleteItem = (SkladData)SkladListL.SelectedItem; //Sdelki+List -- выбор активного элемента коллекции


            //////////////////////////////////////////////////////////////////////////////////////
            SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL1 = "DELETE FROM SkladBase WHERE IdTovara=" + DeleteItem.Id + ";";
            dbConnection1.Prepare(writeSQL1).Step();
            /////////////////////////////////////////////////////////////////////////////////////
            StatusFile.Text = "Удален товар(услуга): " + DeleteItem.TOVARNAME;
            Tovari.Remove(DeleteItem);
            AddListSuggestBoxes();
        }

        private void ShowOkonchanie_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                try
                {
                    double M = Convert.ToDouble(dbState["Kolichestvo"]);
                    double MN = Convert.ToDouble(dbState["NKolichestvo"]);
                    if (MN > M)
                    {
                        Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO = SN, ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });
                    }
                }
                catch { }


            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            SearchStatus.Text = "Okonchanie";
        }

        private void ButtonOtobrazhenieOpen_Click(object sender, RoutedEventArgs e)
        {
            string ButtonStatus = ButtonOtobrazhenieOpen.Content.ToString();


            if (ButtonStatus == "+")
            {
                StackPanelOtobrazhenie.Visibility = Windows.UI.Xaml.Visibility.Visible;
                RazdelitelOtobrazhenie.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonOtobrazhenieOpen.Content = "-";
            }

            if (ButtonStatus == "-")
            {
                StackPanelOtobrazhenie.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RazdelitelOtobrazhenie.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonOtobrazhenieOpen.Content = "+";
            }

        
    }

        private void CheckBoxKolvo_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            KolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','KOLVO','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKolvo_Checked(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            KolvoVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','KOLVO','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxNKolvo_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            NKolvoVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockNKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','NKOLVO','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxNKolvo_Checked(object sender, RoutedEventArgs e)
        {
            
            this.Tovari.Clear();
            NKolvoVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockNKolvoTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','NKOLVO','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxEdIzm_Checked(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            EdIzmVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockEdIzmTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','EDIZM','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxEdIzm_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            EdIzmVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockEdIzmTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','EDIZM','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxArtikul_Checked(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            ArtikulVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockArtikulTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','ARTIKUL','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxArtikul_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            ArtikulVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockArtikulTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','ARTIKUL','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxMyEdPrice_Checked(object sender, RoutedEventArgs e)
        {
            
            this.Tovari.Clear();
            MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockMyEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','MYEDPRICE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxMyEdPrice_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            MyCenaEdVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockMyEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','MYEDPRICE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxSaleEdPrice_Checked(object sender, RoutedEventArgs e)
        {
            
            this.Tovari.Clear();
            SaleCenaVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockSaleEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','SALEEDPRICE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxSaleEdPrice_Unchecked(object sender, RoutedEventArgs e)
        {
            double S = 160;
            this.Tovari.Clear();
            SaleCenaVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockSaleEdPriceTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','SALEEDPRICE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxPrimechanie_Checked(object sender, RoutedEventArgs e)
        {
            
            this.Tovari.Clear();
            PrimechanieVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 1280)
            {
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width + S;
            Razdelitel2.Width = Razdelitel2.Width + S;
            Razdelitel3.Width = Razdelitel3.Width + S;
            }
            
            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','PRIMECHANIE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxPrimechanie_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            PrimechanieVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SKLADVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','PRIMECHANIE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void TextBoxSearchArtikul_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
                {
                    var term = TextBoxSearchArtikul.Text.ToLower();
                    var results = artikulListbox.Where(i => i.ToLower().Contains(term)).ToList();
                    TextBoxSearchArtikul.ItemsSource = results;
                }
        }

        private void ButtonSearchArtikul_Click(object sender, RoutedEventArgs e)
        {
            this.Tovari.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDTovara,TovarName,Kolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,NKolichestvo,Artikul FROM SkladBase WHERE Artikul='" + TextBoxSearchArtikul.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {

                int SNN = Convert.ToInt32(dbState["IDTovara"]); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                string SA = dbState["TovarName"] as string;
                string SB = dbState["Kolichestvo"] as string;
                string SC = dbState["EdIzmTovara"] as string;
                string SD = dbState["MyCenaEd"] as string;
                string SE = dbState["SaleCenaEd"] as string;
                string SF = dbState["Primechanie"] as string;
                string SN = dbState["NKolichestvo"] as string;
                string SM = dbState["Artikul"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Tovari.Add(new SkladData { Id = SNN, TOVARNAME = SA, KOLICHESTVO = SB, EDIZM = SC, MYEDPRICE = SD, SALEEDPRICE = SE, PRIMECHANIE = SF, NKOLICHESTVO = SN,ARTIKUL=SM, IsVisiblePRIMECHANIE = PrimechanieVisibility, IsVisibleARTIKUL = ArtikulVisibility, IsVisibleEDIZM = EdIzmVisibility, IsVisibleKOLICHESTVO = KolvoVisibility, IsVisibleMYEDPRICE = MyCenaEdVisibility, IsVisibleNKOLICHESTVO = NKolvoVisibility, IsVisibleSALEEDPRICE = SaleCenaVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            SearchStatus.Text = "Artikul";
        }



        private void TextBoxTovarName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxTovarName.Text.ToLower();
                var results = tovariListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxTovarName.ItemsSource = results;
            }
        }

        private void TextBoxTovarArtikul_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxTovarArtikul.Text.ToLower();
                var results = artikulListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxTovarArtikul.ItemsSource = results;
            }
        }

        private void TextBoxEdIzmTovara_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxEdIzmTovara.Text.ToLower();
                var results = edListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxEdIzmTovara.ItemsSource = results;
            }
        }

        private void TextBoxPrimechanie_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxPrimechanie.Text.ToLower();
                var results = primechanieListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxPrimechanie.ItemsSource = results;
            }
        }

        private void TextBoxTovarName1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxTovarName1.Text.ToLower();
                var results = tovariListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxTovarName1.ItemsSource = results;
            }
        }

        private void TextBoxTovarArtikul1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxTovarArtikul1.Text.ToLower();
                var results = artikulListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxTovarArtikul1.ItemsSource = results;
            }
        }

        private void TextBoxEdIzmTovara1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxEdIzmTovara1.Text.ToLower();
                var results = edListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxEdIzmTovara1.ItemsSource = results;
            }
        }

        private void TextBoxPrimechanie1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxPrimechanie1.Text.ToLower();
                var results = primechanieListbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxPrimechanie1.ItemsSource = results;
            }
        }

        
    }
}
