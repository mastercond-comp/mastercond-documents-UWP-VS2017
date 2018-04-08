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
using Windows.UI.Xaml.Media.Imaging; //для поддержки BitmapImage
using Windows.Graphics.Printing; //поддержка печати
using Windows.UI.Xaml.Printing; //поддержка печати
using SQLitePCL;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Tehzakl : Page
    {
        public string Logofilename = "";
        public string PechatPodpisfilename = "";

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
            //PreviewPages.Add(this.SkladListL);

            PreviewPages.Add(PanelPrePrint);

            //ТЕСТ МНОГОСТРАНИЧНОСТИ
            PreviewPages.Add(StackPanelPage1);
            PreviewPages.Add(StackPanelPage2);
            PreviewPages.Add(StackPanelPage3);
            PreviewPages.Add(StackPanelPage4);
            PreviewPages.Add(StackPanelPage5);
            PreviewPages.Add(StackPanelPage6);
            PreviewPages.Add(StackPanelPage7);
            PreviewPages.Add(StackPanelPage8);
            PreviewPages.Add(StackPanelPage9);
            PreviewPages.Add(StackPanelPage10);
            //КОНЕЦ ТЕСТ МНОГОСТРАНИЧНОСТИ

            //PreviewPages.Add(this.PanelZagolovokRow);
            //УСТАНАВЛИВАЕТ КОЛ-ВО СТРАНИЦ В ПРЕДПРОСМОТРЕ ПЕЧАТИ ПО КОЛ-ВУ ЭЛЕМЕНТОВ СПИСКА PREVIEWPAGES
            printDoc.SetPreviewPageCount(PreviewPages.Count, PreviewPageCountType.Intermediate);

        }


        private void GetPreviewPage(object sender, GetPreviewPageEventArgs e) //СТРАНИЦЫ В ПРЕДПРОСМОТР ДОБАВЛЯЮТСЯ, ВСЕ ОК
        {
            PreviewPages = new List<UIElement>();
            PreviewPages.Clear();
            //PreviewPages.Add(this.SkladListL);


            PreviewPages.Add(PanelPrePrint);

            //ТЕСТ МНОГОСТРАНИЧНОСТИ
            PreviewPages.Add(StackPanelPage1);
            PreviewPages.Add(StackPanelPage2);
            PreviewPages.Add(StackPanelPage3);
            PreviewPages.Add(StackPanelPage4);
            PreviewPages.Add(StackPanelPage5);
            PreviewPages.Add(StackPanelPage6);
            PreviewPages.Add(StackPanelPage7);
            PreviewPages.Add(StackPanelPage8);
            PreviewPages.Add(StackPanelPage9);
            PreviewPages.Add(StackPanelPage10);
            //КОНЕЦ ТЕСТ МНОГОСТРАНИЧНОСТИ

            //PreviewPages.Add(this.PanelZagolovokRow);

            for (int i = 0; i < PreviewPages.Count; i++)
            {
                printDoc.SetPreviewPage(i + 1, PreviewPages[i]); //ДОБАВЛЯЕМ СТРАНИЦЫ НА ПРЕДПРОСОМТР ПЕЧАТИ
            }

        }



        #endregion

        #region ДОБАВИТЬ СТРАНИЦЫ ДЛЯ ОТПРАВКИ НА ПРИНТЕР

        private void AddPages(object sender, AddPagesEventArgs e) //ДОБАВИТЬ СТРАНИЦЫ НА ПЕЧАТЬ
        {
            Pages = new List<UIElement>();
            Pages.Clear();

            MainPrintingText.Margin = new Thickness(10, 70, 0, 0);//возвращаем обратно

            Pages.Add(PanelPrePrint);

            //ТЕСТ МНОГОСТРАНИЧНОСТИ
            Pages.Add(StackPanelPage1);
            Pages.Add(StackPanelPage2);
            Pages.Add(StackPanelPage3);
            Pages.Add(StackPanelPage4);
            Pages.Add(StackPanelPage5);
            Pages.Add(StackPanelPage6);
            Pages.Add(StackPanelPage7);
            Pages.Add(StackPanelPage8);
            Pages.Add(StackPanelPage9);
            Pages.Add(StackPanelPage10);
            //КОНЕЦ ТЕСТ МНОГОСТРАНИЧНОСТИ


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

        #region ОТМЕНА РЕГИСТРАЦИИ ПЕЧАТИ ПРИ ПЕРЕХОДЕ С ДРУГОЙ СТРАНИЦЫ
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            UnregisterForPrinting();
        }
        #endregion

        #region НАЖАТИЕ НА КНОПКУ ПЕЧАТЬ
        private async void Print_Click(object sender, RoutedEventArgs e)
        {
            MoePolnoeNaimenovaniePrint.Text = TextBoxMoeNaimenovaniePolnoe5.Text;
            MoeSokrNaimenovaniePrint.Text = TextBoxMoeNaimenovanieSokr5.Text;
            MoeINNPrint.Text = TextBoxMojINN5.Text;
            MoeKPPPrint.Text = TextBoxMojKPP5.Text;
            MoeOGRNPrint.Text = TextBoxMojOGRN5.Text;
            MoeBankNaimenovaniePrint.Text = TextBoxMoiBankName5.Text;
            MoeBIKBankaPrint.Text = TextBoxMoiBankBIK5.Text;
            MoeKorrBankaPrint.Text = TextBoxMoiBankKorr5.Text;
            MoeNomerRSPrint.Text = TextBoxMoiRaschetnijSchet5.Text;
            MoeRukDolzhnostPrint.Text = TextBoxMojaRukDolzhnost5.Text;
            MoeVLicePrint.Text = TextBoxMojVlice5.Text;
            MoeUrAddressPrint.Text = TextBoxMojUrAddr5.Text;
            MoeFaktAddressPrint.Text = TextBoxMojFackAddr5.Text;
            MoeTelefonPrint.Text = TextBoxMojPhone5.Text;
            MoeMobTelefonPrint.Text = TextBoxMojMobile5.Text;
            MoeEmailPrint.Text = TextBoxMojEmail5.Text;
            MoeSajtPrint.Text = TextBoxMojSait5.Text;

            HeaderSlogan.Text = TextBoxMojSlogan5.Text;
            Image img = new Image();
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri("ms-appdata:///local/" + Logofilename);

            HeaderLogo.Source = bitmapImage;

            //HeaderSlogan.FontFamily = new FontFamily("Tahoma"); - задаем шрифт

            #region ТЕСТ МНОГОСТРАНИЧНОСТИ "ДЕДОВСКИМ СПОСОБОМ"

            var textblock001 = new TextBlock();
            textblock001.Text = "Test Text of NEW TEXTBLOCK))))";

            var textblock002 = new TextBlock();
            textblock002.Text = "Test Text of NEW TEXTBLOCK)))) PAGE 2!";

            StackPanelPage1.Children.Add(textblock001);
            StackPanelPage1.Children.Add(textblock002);

            //StackPanelPage1.Children.Insert(0,textblock001); //вставляет элемент под номером 1
            //StackPanelPage2.Children.Insert(0,textblock002);

            #endregion

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



        public Tehzakl()
        {
            this.InitializeComponent();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            try
            {

                // ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON PRINTING
                string readSQL1 = "SELECT Printing FROM PRINTINGSETTINGS WHERE ID=1;";
                ISQLiteStatement dbState1 = dbConnection.Prepare(readSQL1);
                while (dbState1.Step() == SQLiteResult.ROW)
                {
                    string PrintingStatusString = dbState1["Printing"] as string;
                    if (PrintingStatusString == "HTML") { TextBlockMoiPechatPodpisPDF.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ImageMoiPechatPodpis.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ButtonPechatPodpis.Visibility = Windows.UI.Xaml.Visibility.Collapsed; TextBlockMojLogoPDF.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ImageLogo.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ButtonLogo.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }

                    if (PrintingStatusString == "PDF") { TextBlockMoiPechatPodpis5.Visibility = Windows.UI.Xaml.Visibility.Collapsed; TextBoxMoiPechatPodpis5.Visibility = Windows.UI.Xaml.Visibility.Collapsed; TextBlockMojLogo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed; TextBoxMojLogo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

            }
            //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON PRINTING }

            catch { TextBlockMoiPechatPodpisPDF.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ImageMoiPechatPodpis.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ButtonPechatPodpis.Visibility = Windows.UI.Xaml.Visibility.Collapsed; TextBlockMojLogoPDF.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ImageLogo.Visibility = Windows.UI.Xaml.Visibility.Collapsed; ButtonLogo.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }

        }

        private async void LoadMoiRekv5_Click(object sender, RoutedEventArgs e)
        {
            var picker2 = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker2.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker2.FileTypeFilter.Add(".mrekv");

            Windows.Storage.StorageFile MyRekvfile = await picker2.PickSingleFileAsync();
            if (MyRekvfile != null)
            {
                // Application now has read/write access to the picked file
                this.TextBlockStatusFile5.Text = "Загружены реквизиты из файла: " + MyRekvfile.Name;
                ///здесь далее код на чтение данных из файла построчно
                var readFile = await Windows.Storage.FileIO.ReadLinesAsync(MyRekvfile);
                foreach (var line in readFile) ///перебор всех элементов первой строки
                {
                    TextBoxMoeNaimenovaniePolnoe5.Text = line.Split(';')[0];
                    TextBoxMoeNaimenovanieSokr5.Text = line.Split(';')[1];
                    TextBoxMojINN5.Text = line.Split(';')[2];
                    TextBoxMojKPP5.Text = line.Split(';')[3];
                    TextBoxMojOGRN5.Text = line.Split(';')[4];
                    TextBoxMoiBankName5.Text = line.Split(';')[5];
                    TextBoxMoiBankBIK5.Text = line.Split(';')[6];
                    TextBoxMoiBankKorr5.Text = line.Split(';')[7];
                    TextBoxMoiRaschetnijSchet5.Text = line.Split(';')[8];
                    TextBoxMojaRukDolzhnost5.Text = line.Split(';')[9];
                    TextBoxMojVlice5.Text = line.Split(';')[10];
                    TextBoxMojFIORuk5.Text = line.Split(';')[11];
                    TextBoxMojUrAddr5.Text = line.Split(';')[12];
                    TextBoxMojFackAddr5.Text = line.Split(';')[13];
                    TextBoxMojPhone5.Text = line.Split(';')[14];
                    TextBoxMojMobile5.Text = line.Split(';')[15];
                    TextBoxMojEmail5.Text = line.Split(';')[16];
                    TextBoxMojSait5.Text = line.Split(';')[17];
                    TextBoxMojSlogan5.Text = line.Split(';')[18];
                    TextBoxMojLogo5.Text = line.Split(';')[19];
                    TextBoxMoiPechatPodpis5.Text = line.Split(';')[20];
                    string TShapkaRead = line.Split(';')[21];
                    TextBoxUslugiPo5.Text = line.Split(';')[22];
                    if (TShapkaRead == "1") { CHeckBoxSchapka5.IsChecked = true; }

                    try
                    {
                        Logofilename = line.Split(';')[23];
                        PechatPodpisfilename = line.Split(';')[24];

                        if (Logofilename != "")
                        {

                            Image img = new Image();
                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.UriSource = new Uri("ms-appdata:///local/" + Logofilename);

                            ImageLogo.Source = bitmapImage;
                            HeaderLogo.Source = bitmapImage; //подгружаем в раздел печать
                        }

                        if (PechatPodpisfilename != "")
                        {
                            Image img = new Image();
                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.UriSource = new Uri("ms-appdata:///local/" + PechatPodpisfilename);

                            ImageMoiPechatPodpis.Source = bitmapImage;
                        }
                    }
                    catch { Logofilename = ""; PechatPodpisfilename = ""; ImageLogo.Source = null; HeaderLogo.Source = null; }

                }

            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция загрузки реквизитов прервана.";
            }
        }

        private async void SaveMoiNewRekv_Click(object sender, RoutedEventArgs e)
        {
            var savePicker5 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker5.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker5.FileTypeChoices.Add("Документ", new List<string>() { ".mrekv" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker5.SuggestedFileName = "Реквизиты моей организации";
            //
            Windows.Storage.StorageFile Myfile5 = await savePicker5.PickSaveFileAsync();
            if (Myfile5 != null)
            {
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile5);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени
                string TShapka = "";
                if (CHeckBoxSchapka5.IsChecked == true) { TShapka = "1"; }

                await FileIO.WriteTextAsync(Myfile5, TextBoxMoeNaimenovaniePolnoe5.Text + ";" + TextBoxMoeNaimenovanieSokr5.Text + ";" + TextBoxMojINN5.Text + ";" + TextBoxMojKPP5.Text + ";" + TextBoxMojOGRN5.Text + ";" + TextBoxMoiBankName5.Text + ";" + TextBoxMoiBankBIK5.Text + ";" + TextBoxMoiBankKorr5.Text + ";" + TextBoxMoiRaschetnijSchet5.Text + ";" + TextBoxMojaRukDolzhnost5.Text + ";" +
                    TextBoxMojVlice5.Text + ";" + TextBoxMojFIORuk5.Text + ";" + TextBoxMojUrAddr5.Text + ";" + TextBoxMojFackAddr5.Text + ";" + TextBoxMojPhone5.Text + ";" + TextBoxMojMobile5.Text + ";" + TextBoxMojEmail5.Text + ";" + TextBoxMojSait5.Text + ";" + TextBoxMojSlogan5.Text + ";" + TextBoxMojLogo5.Text + ";" + TextBoxMoiPechatPodpis5.Text + ";" + TShapka + ";" + TextBoxUslugiPo5.Text + ";");


                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile5);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл моих реквизитов " + Myfile5.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл моих реквизитов " + Myfile5.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла моих реквизитов была прервана.";
            }
        }

        private async void LoadRekviziti5_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".rekv");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                this.TextBlockStatusFile5.Text = "Загружены реквизиты из файла: " + file.Name;
                ///здесь далее код на чтение данных из файла построчно
                var readFile = await Windows.Storage.FileIO.ReadLinesAsync(file);
                foreach (var line in readFile) ///перебор всех элементов первой строки
                {
                    TextBoxFullNameKontr5.Text = line.Split(';')[0];
                    TextBoxSokrNameKontr5.Text = line.Split(';')[1];
                    TextBoxINN5.Text = line.Split(';')[2];
                    TextBoxKPP5.Text = line.Split(';')[3];
                    TextBoxOGRN5.Text = line.Split(';')[4];
                    TextBoxBankRekv5.Text = line.Split(';')[5];
                    TextBoxDolzhnostDirector5.Text = line.Split(';')[6];
                    TextBoxVlice5.Text = line.Split(';')[7];
                    TextBoxRukSokr5.Text = line.Split(';')[8];
                    TextBoxUrAddr5.Text = line.Split(';')[9];
                    TextBoxFactAddr5.Text = line.Split(';')[10];
                    TextBoxPhone5.Text = line.Split(';')[11];
                    TextBoxMobile5.Text = line.Split(';')[12];
                    TextBoxEmail5.Text = line.Split(';')[13];
                    TextBoxSajt5.Text = line.Split(';')[14];
                }

            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция загрузки реквизитов прервана.";
            }

        }

        private async void SaveNewRekviziti5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker4 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker4.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker4.FileTypeChoices.Add("Документ", new List<string>() { ".rekv" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker4.SuggestedFileName = "Реквизиты новой организации";
            //
            Windows.Storage.StorageFile Myfile4 = await savePicker4.PickSaveFileAsync();
            if (Myfile4 != null)
            {
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile4);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                await FileIO.WriteTextAsync(Myfile4, TextBoxFullNameKontr5.Text + ";" + TextBoxSokrNameKontr5.Text + ";" + TextBoxINN5.Text + ";" + TextBoxKPP5.Text + ";" + TextBoxOGRN5.Text + ";" + TextBoxBankRekv5.Text + ";" + TextBoxDolzhnostDirector5.Text + ";" +
                    TextBoxVlice5.Text + ";" + TextBoxRukSokr5.Text + ";" + TextBoxUrAddr5.Text + ";" + TextBoxFactAddr5.Text + ";" + TextBoxPhone5.Text + ";" + TextBoxMobile5.Text + ";" + TextBoxEmail5.Text + ";" + TextBoxSajt5.Text + ";");


                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile4);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл реквизитов " + Myfile4.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл реквизитов " + Myfile4.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла реквизитов была прервана.";
            }
        }





        private async void SaveNastrojki5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker5 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker5.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker5.FileTypeChoices.Add("Документ", new List<string>() { ".tehdata" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker5.SuggestedFileName = "Техническое заключение";
            //
            Windows.Storage.StorageFile Myfile5 = await savePicker5.PickSaveFileAsync();
            if (Myfile5 != null)
            {
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile5);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени
                string TShapkaWrite = "";
                if (CHeckBoxSchapka5.IsChecked == true) { TShapkaWrite = "1"; }

                await FileIO.WriteTextAsync(Myfile5, TextBoxFullNameKontr5.Text + ";" + TextBoxSokrNameKontr5.Text + ";" + TextBoxINN5.Text + ";" + TextBoxKPP5.Text + ";" + TextBoxOGRN5.Text + ";" + TextBoxBankRekv5.Text + ";" + TextBoxDolzhnostDirector5.Text + ";" + TextBoxVlice5.Text + ";" + TextBoxRukSokr5.Text + ";" + TextBoxUrAddr5.Text + ";" + TextBoxFactAddr5.Text + ";" + TextBoxPhone5.Text + ";"+TextBoxFIOOtvetstvennij5.Text+";"+ TextBoxMobile5.Text + ";" + TextBoxEmail5.Text + ";" + TextBoxSajt5.Text + ";" + TextBoxMoeNaimenovaniePolnoe5.Text + ";" + TextBoxMoeNaimenovanieSokr5.Text + ";" + TextBoxMojINN5.Text + ";" + TextBoxMojKPP5.Text + ";" + TextBoxMojOGRN5.Text + ";" + TextBoxMoiBankName5.Text + ";" + TextBoxMoiBankBIK5.Text + ";" + TextBoxMoiBankKorr5.Text + ";" + TextBoxMoiRaschetnijSchet5.Text + ";" + TextBoxMojaRukDolzhnost5.Text + ";" + TextBoxMojVlice5.Text + ";" + TextBoxMojFIORuk5.Text + ";" + TextBoxMojUrAddr5.Text + ";" + TextBoxMojFackAddr5.Text + ";" + TextBoxMojPhone5.Text + ";" + TextBoxMojMobile5.Text + ";" + TextBoxMojEmail5.Text + ";" + TextBoxMojSait5.Text + ";" + TextBoxMojSlogan5.Text + ";" + TextBoxMojLogo5.Text + ";" + TextBoxMoiPechatPodpis5.Text + ";" + TShapkaWrite + ";" + TextBoxUslugiPo5.Text + ";"+TextBoxDataTehZakl5.Text+";"+TextBoxNomerTehZakl.Text+";"+TextBoxKDogovory.Text+";"+TextBoxGorodZaklDogovora.Text+";"+TextBoxNaimenovanieOborudovanija.Text+";"+TextBoxMestoUastanovkiOborudovanija.Text+";"+TextBoxPrichinaObrvService.Text+";"+TextBoxDopInfo.Text+";"+TextBoxZakl.Text+";" );


                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile5);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл данных технического заключения" + Myfile5.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл данных технического заключения" + Myfile5.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла данных технического заключения была прервана.";
            }
        }

        private async void LoadNastrojki5_Click(object sender, RoutedEventArgs e)
        {
            var picker3 = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker3.FileTypeFilter.Add(".tehdata");
            Windows.Storage.StorageFile file3 = await picker3.PickSingleFileAsync();
            if (file3 != null)
            {
                // Application now has read/write access to the picked file
                this.TextBlockStatusFile5.Text = "Загружены данные из файла: " + file3.Name;
                ///здесь далее код на чтение данных из файла построчно
                var readFile3 = await Windows.Storage.FileIO.ReadLinesAsync(file3);
                foreach (var line in readFile3) ///перебор всех элементов первой строки
                {
                    TextBoxFullNameKontr5.Text = line.Split(';')[0];
                    TextBoxSokrNameKontr5.Text = line.Split(';')[1];
                    TextBoxINN5.Text = line.Split(';')[2];
                    TextBoxKPP5.Text = line.Split(';')[3];
                    TextBoxOGRN5.Text = line.Split(';')[4];
                    TextBoxBankRekv5.Text = line.Split(';')[5];
                    TextBoxDolzhnostDirector5.Text = line.Split(';')[6];
                    TextBoxVlice5.Text = line.Split(';')[7];
                    TextBoxRukSokr5.Text = line.Split(';')[8];
                    TextBoxUrAddr5.Text = line.Split(';')[9];
                    TextBoxFactAddr5.Text = line.Split(';')[10];
                    TextBoxPhone5.Text = line.Split(';')[11];
                    TextBoxFIOOtvetstvennij5.Text = line.Split(';')[12];

                    TextBoxMobile5.Text = line.Split(';')[13];
                    TextBoxEmail5.Text = line.Split(';')[14];
                    TextBoxSajt5.Text = line.Split(';')[15];
                    TextBoxMoeNaimenovaniePolnoe5.Text = line.Split(';')[16];
                    TextBoxMoeNaimenovanieSokr5.Text = line.Split(';')[17];
                    TextBoxMojINN5.Text = line.Split(';')[18];
                    TextBoxMojKPP5.Text = line.Split(';')[19];
                    TextBoxMojOGRN5.Text = line.Split(';')[20];
                    TextBoxMoiBankName5.Text = line.Split(';')[21];
                    TextBoxMoiBankBIK5.Text = line.Split(';')[22];
                    TextBoxMoiBankKorr5.Text = line.Split(';')[23];
                    TextBoxMoiRaschetnijSchet5.Text = line.Split(';')[24];
                    TextBoxMojaRukDolzhnost5.Text = line.Split(';')[25];
                    TextBoxMojVlice5.Text = line.Split(';')[26];
                    TextBoxMojFIORuk5.Text = line.Split(';')[27];
                    TextBoxMojUrAddr5.Text = line.Split(';')[28];
                    TextBoxMojFackAddr5.Text = line.Split(';')[29];
                    TextBoxMojPhone5.Text = line.Split(';')[30];
                    TextBoxMojMobile5.Text = line.Split(';')[31];
                    TextBoxMojEmail5.Text = line.Split(';')[32];
                    TextBoxMojSait5.Text = line.Split(';')[33];
                    TextBoxMojSlogan5.Text = line.Split(';')[34];
                    TextBoxMojLogo5.Text = line.Split(';')[35];
                    TextBoxMoiPechatPodpis5.Text = line.Split(';')[36];
                    string TShapka = line.Split(';')[37];
                    TextBoxUslugiPo5.Text = line.Split(';')[38];
                    
                    TextBoxDataTehZakl5.Text = line.Split(';')[39];
                    TextBoxNomerTehZakl.Text = line.Split(';')[40];
                    TextBoxKDogovory.Text = line.Split(';')[41];
                    TextBoxGorodZaklDogovora.Text = line.Split(';')[42];
                    TextBoxNaimenovanieOborudovanija.Text = line.Split(';')[43];
                    TextBoxMestoUastanovkiOborudovanija.Text = line.Split(';')[44];
                    TextBoxPrichinaObrvService.Text = line.Split(';')[45];
                    TextBoxDopInfo.Text = line.Split(';')[46];
                    TextBoxZakl.Text = line.Split(';')[47];


                    if (TShapka == "1") { CHeckBoxSchapka5.IsChecked = true; }



                }

            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция загрузки данных тех.заключения прервана.";
            }
        }

//ДАЛЕЕ ВЫВОД ДАННЫХ В HTML

        private async void SaveTZAKLP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новое техзаключение";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile3);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                await FileIO.WriteTextAsync(Myfile3, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile3, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile3, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile3, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<style type=\"text/css\">");
                await FileIO.AppendTextAsync(Myfile3, "@page {} table {border-collapse: collapse;border-spacing: 0;empty-cells: show;} td, th {vertical-align: top;font-size: 12pt;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, "h1, h2, h3, h4, h5, h6 {clear: both;} * {margin: 0;} .P10 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P13 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: center !important;color: #000000;font-weight: bold;} .P113 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;} .P25 {font-size: 5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;color: #000000;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;}.P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P54 {font-size: 9.5pt;line-height: 100%;margin-left: 0.762cm;margin-right: 0cm;text-align: center !important;text-indent: 0cm;font-family: Tahoma;writing-mode: page;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".T5 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;} .T7 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;background-color: transparent;}</style></head>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</head><body style=\"width: 19cm; \"> \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка договора
                    await FileIO.AppendTextAsync(Myfile3, "<table width=\"100% \"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile3, "</p></td><td style=\"text-align:right; \"><p class=\"P250\" align=\"right\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P250\" align=\"right\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P250\" align=\"right\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки договора
                }
                /// начало документа: заголовок, город, дата
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">ТЕХНИЧЕСКОЕ ЗАКЛЮЧЕНИЕ № ТЗ-" + TextBoxNomerTehZakl.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxKDogovory.Text+ "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataTehZakl5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", выполнив диагностику оборудования Заказчика "+TextBoxSokrNameKontr5.Text+", сообщает нижеследующее:</p><p class=\"P25\"> </p>\r\n");
               
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Наименование оборудования: <span style=\"font-weight:bold;\">"+TextBoxNaimenovanieOborudovanija.Text+"</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Место установки оборудования: <span style=\"font-weight:bold;\">" + TextBoxMestoUastanovkiOborudovanija.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Причина обращения в сервисно-ремонтную службу: <span style=\"font-weight:bold;\">" + TextBoxPrichinaObrvService.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Дополнительная информация: <span style=\"font-weight:bold;\">" + TextBoxDopInfo.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Специалистом Исполнителя установлено: <span style=\"font-weight:bold;\">" + TextBoxZakl.Text + "</span></p><p class=\"P25\"> </p><p class=\"P25\"> </p>");


                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"P550\"><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\" >" + " / " + TextBoxMojFIORuk5.Text + "</p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataTehZakl5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataTehZakl5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");



                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл техзаключения " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл техзаключения " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла техзаключения была прервана.";
            }
        }


        private async void SaveTZAKL_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новое техзаключение";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile3);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                await FileIO.WriteTextAsync(Myfile3, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile3, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile3, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile3, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<style type=\"text/css\">");
                await FileIO.AppendTextAsync(Myfile3, "@page {} table {border-collapse: collapse;border-spacing: 0;empty-cells: show;} td, th {vertical-align: top;font-size: 12pt;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, "h1, h2, h3, h4, h5, h6 {clear: both;} * {margin: 0;} .P10 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P13 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: center !important;color: #000000;font-weight: bold;} .P113 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;} .P25 {font-size: 5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;color: #000000;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;}.P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".P54 {font-size: 9.5pt;line-height: 100%;margin-left: 0.762cm;margin-right: 0cm;text-align: center !important;text-indent: 0cm;font-family: Tahoma;writing-mode: page;}\r\n");
                await FileIO.AppendTextAsync(Myfile3, ".T5 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;} .T7 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;background-color: transparent;}</style></head>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</head><body style=\"width: 19cm; \"> \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка договора
                    await FileIO.AppendTextAsync(Myfile3, "<table width=\"100% \"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile3, "</p></td><td style=\"text-align:right; \"><p class=\"P250\" align=\"right\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P250\" align=\"right\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P250\" align=\"right\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки договора
                }
                /// начало документа: заголовок, город, дата
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">ТЕХНИЧЕСКОЕ ЗАКЛЮЧЕНИЕ № ТЗ-" + TextBoxNomerTehZakl.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxKDogovory.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataTehZakl5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", выполнив диагностику оборудования Заказчика " + TextBoxSokrNameKontr5.Text + ", сообщает нижеследующее:</p><p class=\"P25\"> </p>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Наименование оборудования: <span style=\"font-weight:bold;\">" + TextBoxNaimenovanieOborudovanija.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Место установки оборудования: <span style=\"font-weight:bold;\">" + TextBoxMestoUastanovkiOborudovanija.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Причина обращения в сервисно-ремонтную службу: <span style=\"font-weight:bold;\">" + TextBoxPrichinaObrvService.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Дополнительная информация: <span style=\"font-weight:bold;\">" + TextBoxDopInfo.Text + "</span></p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Специалистом Исполнителя установлено: <span style=\"font-weight:bold;\">" + TextBoxZakl.Text + "</span></p><p class=\"P25\"> </p><p class=\"P25\"> </p>");


                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxMojFIORuk5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataTehZakl5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataTehZakl5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");



                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл техзаключения " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл техзаключения " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла техзаключения была прервана.";
            }
        }


        private async void ButtonPechatPodpis_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder localFolder1 = ApplicationData.Current.LocalFolder; //Путь доступа к папке ms-appdata:///local/

            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

            //  string DelFile = PechatPodpisfilename;

            if (file != null)
            {
                try
                {

                    string dbfile = file.Name.ToString();
                    await file.CopyAsync(localFolder1, dbfile, NameCollisionOption.ReplaceExisting);
                    PechatPodpisfilename = dbfile;

                    Image img = new Image();
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.UriSource = new Uri("ms-appdata:///local/" + dbfile);

                    ImageMoiPechatPodpis.Source = bitmapImage;

                    //  if (DelFile!=PechatPodpisfilename) //удаляем старый файл изображения печати и подписи
                    //  {
                    //      try { StorageFile DFile = await localFolder1.GetFileAsync(DelFile); await DFile.DeleteAsync(); }
                    //      catch { }

                    //  }

                    TextBlockStatusFile5.Text = "Файл печати и подписи " + dbfile + " успешно скопирован (импортирован) в рабочую папку приложения.";
                }
                catch
                {
                    TextBlockStatusFile5.Text = "Не удалось скопировать файл печати и подписи в рабочую папку приложения.";
                }
            }
        }

        private async void ButtonLogo_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder localFolder1 = ApplicationData.Current.LocalFolder; //Путь доступа к папке ms-appdata:///local/

            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();

            //string DelFile = Logofilename;

            if (file != null)
            {
                try
                {
                    string dbfile = file.Name.ToString();
                    await file.CopyAsync(localFolder1, dbfile, NameCollisionOption.ReplaceExisting);
                    Logofilename = dbfile;

                    Image img = new Image();
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.UriSource = new Uri("ms-appdata:///local/" + dbfile);

                    ImageLogo.Source = bitmapImage;

                    //  if (DelFile != Logofilename) //удаляем старый файл изображения логотипа
                    //  {
                    //      try { StorageFile DFile = await localFolder1.GetFileAsync(DelFile); await DFile.DeleteAsync(); }
                    //      catch { }

                    //  }

                    TextBlockStatusFile5.Text = "Файл логотипа " + dbfile + " успешно скопирован (импортирован) в рабочую папку приложения.";
                }
                catch
                {
                    TextBlockStatusFile5.Text = "Не удалось скопировать файл логотипа в рабочую папку приложения.";
                }
            }
        }

    }
}
