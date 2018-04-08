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

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class AddRekviziti : Page
    {
        public AddRekviziti()
        {
            this.InitializeComponent();
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
    }
}
