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
using Windows.UI.Xaml.Media.Imaging; //для поддержки BitmapImage

using Windows.Graphics.Printing; //поддержка печати
using Windows.UI.Xaml.Printing; //поддержка печати

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{
   
    public sealed partial class AddMoiRekviziti : Page
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



        public AddMoiRekviziti()
        {
            this.InitializeComponent();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            try { 

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

                        if (Logofilename!="")
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
                    TextBoxMojVlice5.Text + ";" + TextBoxMojFIORuk5.Text + ";" + TextBoxMojUrAddr5.Text + ";" + TextBoxMojFackAddr5.Text + ";" + TextBoxMojPhone5.Text + ";" + TextBoxMojMobile5.Text + ";" + TextBoxMojEmail5.Text + ";" + TextBoxMojSait5.Text + ";" + TextBoxMojSlogan5.Text + ";" + TextBoxMojLogo5.Text + ";" + TextBoxMoiPechatPodpis5.Text + ";" + TShapka + ";" + TextBoxUslugiPo5.Text + ";"+Logofilename+";"+PechatPodpisfilename+";");


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
