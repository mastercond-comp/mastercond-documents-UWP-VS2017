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
    public sealed partial class CreateDocuments30 : Page
    {
        public CreateDocuments30()
        {
            this.InitializeComponent();

            ComboBoxModule1.SelectedItem = Combo011;

            TextBlockLoadNastrojkiMessage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar2Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar2RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar3Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar3RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar4Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar4RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar5Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar5RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar6Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar6RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar7Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar7RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar7.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar8Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar8RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar8.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar9Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar9RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar9.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar10Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar10RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar10.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar11Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar11RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar11.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar12Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar12RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar12.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar13Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar13RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar13.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar14Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar14RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar14.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar15Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar15RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar15.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar16Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar16RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar16.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar17Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar17RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar17.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar18Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar18RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar18.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar19Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar19RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar19.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar20Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar20RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar20.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar21Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar21RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar21.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar22Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar22RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar22.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar23Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar23RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar23.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar24Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar24RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar24.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar25Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar25RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar25.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar26Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar26RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar26.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar27Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar27RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar27.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar28Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar28RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar28.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar29Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar29RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar29.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBoxTovar30Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar30RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar30.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar30Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
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

        private async void SaveSchet5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker1 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker1.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker1.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker1.SuggestedFileName = "Новый счет";
            //
            Windows.Storage.StorageFile Myfile1 = await savePicker1.PickSaveFileAsync();
            if (Myfile1 != null)
            {
                int Number = 0;
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile1);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                ///Вывод файла счета
                await FileIO.WriteTextAsync(Myfile1, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile1, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile1, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile1, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile1, "<style type=\"text/css\"> \r\n");
                await FileIO.AppendTextAsync(Myfile1, "table { border-collapse:collapse; border-spacing:0; empty-cells:show } td, th { vertical - align:top; font - size:12pt;} h1, h2, h3, h4, h5, h6 { clear: both } ol, ul { margin: 0; padding: 0;} li { list - style: none; margin: 0; padding: 0;} li span. { clear: both; line - height:0; width: 0; height: 0; margin: 0; padding: 0;} span.footnodeNumber { padding - right:1em;} span.annotation_style_by_filter {font - size:95 %; font - family:Arial; background - color:#fff000;  margin:0; border:0; padding:0;} * { margin: 0;}  \r\n");
                await FileIO.AppendTextAsync(Myfile1, ".P1 {color:#00000a; font-size:14.5pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; font-weight:bold; } .P10 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; } .P101 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P11 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P12 {color:#00000a; font-size:9pt; line-height:140%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P13 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P14 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P15 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P16 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P17 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P18 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; font-weight:bold; }.P19 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; }.P2 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P20 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; font-weight:bold; }.P21 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0.353cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; } /r/n .P22 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P23 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P24 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0.529cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P25 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P26 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P27 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P28 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P29 {color:#000000; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; font-style:normal; font-weight:normal; }.P3 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P30 {color:#00000a; font-size:8pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P31 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }");
                await FileIO.AppendTextAsync(Myfile1, ".P4 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P5 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P6 {color:#000000; font-size:8pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P7 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P8 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P9 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }");
                await FileIO.AppendTextAsync(Myfile1, ".Standard {font - size:9pt; font - family:Arial; writing - mode:lr - tb; margin - top:0cm; margin - bottom:0cm; line - height:100 %; text - align:left !important; color:#00000a; }.Таблица1 { width: 18.706cm; margin - left:-0.191cm; margin - right:-1.515cm; margin - top:0cm; margin - bottom:0cm; float:none; writing - mode:lr - tb;}.Таблица2 { width: 18.694cm; margin - left:-0.191cm; margin - top:0cm; margin - bottom:0cm; writing - mode:lr - tb;}.Таблица3 { width: 18.694cm; margin - left:-0.191cm; margin - top:0cm; margin - bottom:0cm; writing - mode:lr - tb;}.Таблица1_A1 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-width:0.018cm; border-top-style:solid; border-top-color:#00000a; border-bottom-style:none; }.Таблица1_A3 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_E1 {vertical - align:middle; background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_F2 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-style:none; }.Таблица1_F4 {background-color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-width:0.018cm; border-top-style:solid; border-top-color:#00000a; border-bottom-style:none; }.Таблица2_A1 {background - color:#ffffff; padding-left:0.191cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-style:none; }.Таблица3_A1 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }");
                await FileIO.AppendTextAsync(Myfile1, ".Таблица3_A4 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-width:0.018cm; border-bottom-style:solid; border-bottom-color:#00000a; }.Таблица3_B4 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-width:0.018cm; border-bottom-style:solid; border-bottom-color:#00000a; }.Таблица3_C3 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_A { width: 1.723cm; }.Таблица1_B { width: 6.145cm;}.Таблица1_C { width: 1.812cm;}.Таблица1_D { width: 1.194cm;}.Таблица1_E { width: 1.482cm;}.Таблица1_F { width: 6.352cm;}.Таблица2_A { width: 2.193cm;}.Таблица2_B { width: 16.501cm;}.Таблица3_A { width: 0.93cm;}.Таблица3_B { width: 9.745cm;}.Таблица3_C { width: 1.535cm;}.Таблица3_D { width: 1.334cm;}.Таблица3_E { width: 2.35cm;}.Таблица3_F { width: 2.801cm; }.Internet_20_link {color:#000080; text-decoration:underline; }.T1 { font - size:10pt;}.T13 {color:#000000; font-size:9pt; font-style:normal; font-weight:normal; }.T15 { font-size:14.5pt; font-weight:bold;}.T16 { font-size:14.5pt; font-weight:bold;}.T17 { font-family:Tahoma; font-size:10pt;}.T18 {font-family:Tahoma; font-size:10pt;}.T19 { font-family:Tahoma; font-weight:normal;}.T2 { font-size:10pt;}.T3 { font-size:10pt;}.T4 {font-size:10pt; text-decoration:none !important;}.T6 { font-size:9pt;}.T7 { font-size:9pt;}.Таблица1.1.Таблица2.1.Таблица2.2.Таблица3.1.Таблица3.2.Таблица3.5.T10.T11.T12.T14.T5.T8.T9 {} </style>");
                await FileIO.AppendTextAsync(Myfile1, "</head><body style = \"max-width:19cm; \" > \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка счета
                    await FileIO.AppendTextAsync(Myfile1, "<table width=\"100%\"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile1, "</p></td><td><p class=\"P101\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P101\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P101\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки счета
                }
                ///таблица образца платежного поручения 
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P6\">Образец заполнения платежного поручения</p><p class=\"P26\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse:collapse\" class=\"Таблица1\"><colgroup><col width=\"75\"/><col width=\"269\"/><col width=\"79\"/><col width=\"52\"/><col width=\"65\"/><col width=\"278\"/></colgroup><tr class=\"Таблица11\"><td colspan=\"4\" rowspan=\"2\" style=\"text-align:left; width: 1.723cm;\" class=\"Таблица1_A1\"><p class=\"P7\"><span class=\"T14\">" + TextBoxMoiBankName5.Text + "</span></p></td><td style=\"text - align:left; width: 1.482cm;\" class=\"Таблица1_E1\"><p class=\"P7\">БИК</p></td><td style=\"text - align:left; width: 6.352cm; \" class=\"Таблица1_A1\"><p class=\"P28\">" + TextBoxMoiBankBIK5.Text + "</p></td></tr><tr class=\"Таблица11\"><td style=\"text-align:left; width: 1.482cm;\" class=\"Таблица1_A1\"><p class=\"P7\">Сч. №</p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_F2\"><p class=\"P29\">" + TextBoxMoiBankKorr5.Text + "</p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A3\"><p class=\"P30\">Банк получателя</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A3\"><p class=\"P9\"></p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_A3\"><p class=\"P9\"></p></td></tr><tr class=\"Таблица11\"><td style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_E1\"><p class=\"P7\">ИНН</p></td><td style=\"text-align:left; width: 6.145cm; \" class=\"Таблица1_A3\"><p class=\"P7\">" + TextBoxMojINN5.Text + "</p></td><td style=\"text-align:left; width: 1.812cm; \" class=\"Таблица1_E1\"><p class=\"P7\">КПП</p></td><td style=\"text-align:left; width: 1.194cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A1\">");
                ///конец таблицы образца платежного поручения

                /// секция реквизитов Продавца и Покупателя
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P7\">Сч. №</p></td><td style=\"text - align:right; width: 6.352cm; \" class=\"Таблица1_F4\"><p class=\"P31\">" + TextBoxMoiRaschetnijSchet5.Text + "</p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A1\"><p class=\"P7\">" + TextBoxMoeNaimenovaniePolnoe5.Text + "</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_F2\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_F2\"><p class=\"P9\"> </p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A3\"><p class=\"P30\">Получатель</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td></tr></table><br><p class=\"P5\"><span class=\"T16\">Счет на оплату № C-" + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "<br><br>к договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</span></p><br>");
                await FileIO.AppendTextAsync(Myfile1, "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"Таблица2\"><colgroup><col width=\"96\"/><col width=\"721\"/></colgroup><tr class=\"Таблица21\"><td style=\"text-align:left;width:2.193cm; \" class=\"Таблица2_A1\"><p class=\"P15\">Поставщик:</p></td><td style=\"text-align:left;width:16.501cm; \" class=\"Таблица2_A1\">");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P18\">" + TextBoxMoeNaimenovaniePolnoe5.Text + "</p><p class=\"P15\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P15\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P15\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P15\">ИНН " + TextBoxMojINN5.Text + "</p><p class=\"P15\">Р/cчет " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + "</p><p class=\"P15\">БИК " + TextBoxMoiBankBIK5.Text + " корр.счет " + TextBoxMoiBankKorr5.Text + "</p>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P15\">Тел.: " + TextBoxMojPhone5.Text + "</p>" + "<p class=\"P15\">Моб.: " + TextBoxMojMobile5.Text + "</p><p class=\"P15\">Эл.почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P15\"><span class=\"T19\">Сайт: " + TextBoxMojSait5.Text + "</span></p><br>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P8\"></p></td></tr><tr class=\"Таблица22\"><td style=\"text-align:left; width: 2.193cm; \" class=\"Таблица2_A1\"><p class=\"P15\">Покупатель:</p></td><td style=\"text-align:left;width:16.501cm; \" class=\"Таблица2_A1\">");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P18\">" + TextBoxFullNameKontr5.Text + "</p><p class=\"P15\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P15\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P15\">ИНН " + TextBoxINN5.Text + " КПП " + TextBoxKPP5.Text + " ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P15\">" + TextBoxBankRekv5.Text + "</p><p class=\"P15\">Тел: " + TextBoxPhone5.Text + "</p><p class=\"P15\">Моб.: " + TextBoxMobile5.Text + "</p><p class=\"P15\">Эл.почта: " + TextBoxEmail5.Text + "</p><p class=\"P15\">Сайт: " + TextBoxSajt5.Text + "</p></td></tr></table><br>");
                ///конец секции реквизитов Продавца и Покупателя

                ///таблица товаров и услуг
                await FileIO.AppendTextAsync(Myfile1, "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"Таблица3\"><colgroup><col width=\"41\"/><col width=\"426\"/><col width=\"67\"/><col width=\"58\"/><col width=\"103\"/><col width=\"122\"/></colgroup>");
                await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">№</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Товары(работы, услуги)</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Кол-во</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Ед.</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Цена</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Сумма</p></td></tr>");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar2Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>");
                }


                if (TextBoxTovar4Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar5Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar6Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar11Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar17Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar18Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar19Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar20Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar22Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar23Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar24Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar25Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar27Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar28Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar29Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar30Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>");
                }



                await FileIO.AppendTextAsync(Myfile1, "</table><br><p class=\"P18\">Всего к оплате: " + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + ").</p>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P24\"><span class=\"T4\">_____________________________</span><span class=\"T3\">" + TextBoxMojaRukDolzhnost5.Text + " " + TextBoxMojFIORuk5.Text + "</span></p><p class=\"P25\">                                           МП</p></body></html>");
                await FileIO.AppendTextAsync(Myfile1, "</body></html>");
                await FileIO.AppendTextAsync(Myfile1, "");
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile1);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл счета " + Myfile1.Name + " успешно сохранен.";

                    
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл счета " + Myfile1.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция сохранения файла счёта была прервана.";
            }
        }

        private async void SaveDogovor5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker2 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker2.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker2.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker2.SuggestedFileName = "Новый договор";
            //
            Windows.Storage.StorageFile Myfile2 = await savePicker2.PickSaveFileAsync();
            if (Myfile2 != null)
            {
                int Number = 0;
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile2);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                ///начало файла договора
                await FileIO.WriteTextAsync(Myfile2, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile2, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile2, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile2, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<style type=\"text/css\">");
                await FileIO.AppendTextAsync(Myfile2, "@page {} table {border-collapse: collapse;border-spacing: 0;empty-cells: show;} td, th {vertical-align: top;font-size: 12pt;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, "h1, h2, h3, h4, h5, h6 {clear: both;} * {margin: 0;} .P10 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P13 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: center !important;color: #000000;font-weight: bold;} .P25 {font-size: 5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;color: #000000;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P54 {font-size: 9.5pt;line-height: 100%;margin-left: 0.762cm;margin-right: 0cm;text-align: center !important;text-indent: 0cm;font-family: Tahoma;writing-mode: page;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".T5 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;} .T7 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;background-color: transparent;}</style></head>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "</head><body style=\"width: 19cm; \"> \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка договора
                    await FileIO.AppendTextAsync(Myfile2, "<table width=\"100% \"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile2, "</p></td><td style=\"text-align:right; \"><p class=\"P250\" align=\"right\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P250\" align=\"right\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P250\" align=\"right\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки договора
                }
                await FileIO.AppendTextAsync(Myfile2, "<h1 class=\"P54\">ДОГОВОР № " + TextBoxNomerDogovora5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">на оказание услуг по " + TextBoxUslugiPo5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">" + TextBoxMoeNaimenovaniePolnoe5.Text + ", именуемый(ое) в дальнейшем <span class=\"T5\">Исполнитель</span>, в лице " + TextBoxMojVlice5.Text + ", с одной стороны и " + TextBoxFullNameKontr5.Text + ", в лице " + TextBoxVlice5.Text + ", именуемый(ое) в дальнейшем <span class=\"T5\">Заказчик</span>, с другой стороны, вместе именуемые в дальнейшем «Стороны» и по отдельности «Сторона», заключили настоящий договор, в дальнейшем Договор, о нижеследующем:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">1. ПРЕДМЕТ ДОГОВОРА</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">1.1 В соответствии с условиями настоящего Договора <span class=\"T6\">Исполнитель</span> обязуется поставить товары и оказать услуги, а <span class=\"T6\">Заказчик</span> принять и оплатить товары и услуги по " + TextBoxUslugiPo5.Text + " в соответствии с Перечнем товаров и оказываемых услуг.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">2. СТОИМОСТЬ И ПОРЯДОК РАСЧЕТОВ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.1 Стоимость товаров и услуг по " + TextBoxUslugiPo5.Text + " составляет <span class=\"T7\">" + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + "), без НДС (Исполнитель применяет УСН)</span></p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.2 Услуги по " + TextBoxUslugiPo5.Text + " оказываются, товары по настоящему Договору поставляются " + TextBoxSrokiIspolnenija5.Text + ".</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.3 Оплата за товары и услуги по " + TextBoxUslugiPo5.Text + " производится " + TextBoxUslovijaOplati5.Text + ".</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P25\"> </p><p class=\"P13\">3. ПЕРЕЧЕНЬ ТОВАРОВ И ОКАЗЫВАЕМЫХ УСЛУГ</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile2, "</table><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">4. ГАРАНТИЙНЫЕ ОБЯЗАТЕЛЬСТВА</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">4.1 " + TextBoxGarantija5.Text + "</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">5. ОТВЕТСТВЕННОСТЬ СТОРОН</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.1 Исполнитель обязуется оказать услуги по " + TextBoxUslugiPo5.Text + " в соответствии с нормативно-технической документацией, установленной для данного вида работ (СНиП, ПУЭ, ППБ, ГОСТ).</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.2 Исполнитель обязуется оказать услуги лично или с помощью иных квалифицированных лиц, с использованием своих расходных материалов или материалов Заказчика, в зависимости от вида оказываемых услуг. Ответственность за оказанные услуги, осуществленные с привлечением третьих лиц, несет Исполнитель.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.3 Исполнитель обязуется по окончании оказания услуг по " + TextBoxUslugiPo5.Text + " подписать с Заказчиком <span class=\"T5\">Акт об оказанных услугах по " + TextBoxUslugiPo5.Text + "</span>.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.4 Исполнитель обязан до заключения настоящего договора предоставить Заказчику необходимую и достоверную информацию об оказываемых услугах, видах и об особенностях, о цене и форме оплаты, а также сообщить Заказчику по его просьбе другие относящиеся к договору и соответствующим услугам сведения.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.5 Заказчик обязан по окончании оказания услуг по " + TextBoxUslugiPo5.Text + " подписать с Исполнителем <span class=\"T5\">Акт об оказанных услугах  по " + TextBoxUslugiPo5.Text + ".</span></p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.6 Заказчик обязан оплатить товары и услуги Исполнителю в соответствии с условиями п. 2.1, 2.3 настоящего Договора.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.7 Заказчик обязуется обеспечить Исполнителю доступ к месту проведения работ.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.8 Заказчик вправе в любое время проверять ход и качество оказываемых услуг Исполнителем, не вмешиваясь при этом в его деятельность.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.9 Заказчик вправе в любое время до завершения оказания услуг отказаться от исполнения договора, уплатив Исполнителю часть установленной цены пропорционально части услуг, оказанных до уведомления об отказе от исполнения договора, и возместив Исполнителю расходы, произведенные до этого момента в целях исполнения договора, если они не входят в указанную часть цены оказанных услуг.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">6. ФОРС-МАЖОР</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.1 В случае пожара; наводнения; землетрясения; стихийных бедствий; аварий на транспорте; мятежей; гражданских беспорядков; забастовок; войны и военных действий; публикаций нормативных актов запрещающего характера; действий (бездействий) сотрудников государственных органов, препятствующих выполнению Сторонами взятых на себя обязательств; а также других чрезвычайных обстоятельств непреодолимой силы, возникших после подписания настоящего Договора, которые Стороны не могли предвидеть или предотвратить, срок исполнения обязательств по Договору отодвигается соразмерно времени, в течение которого будут действовать эти обстоятельства, но не более чем на 3 (три) месяца.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.2 Указанные обстоятельства должны носить чрезвычайный, непредвиденный и непредотвратимый характер и возникнуть после заключения Договора.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.3 Если действие обстоятельств непреодолимой силы продлится более 6 (шести) месяцев, любая из Сторон вправе расторгнуть Договор в одностороннем порядке, направив другой Стороне соответствующее уведомление.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.4 Сторона, для которой создалась невозможность выполнения обязательства по Договору, должна немедленно, но в любом случае не позднее 3 (трех) дней с момента, когда Стороне стало известно о наступлении обстоятельств непреодолимой силы известить другую Сторону о наступлении обстоятельств непреодолимой силы, препятствующих выполнению обязательств. Такое уведомление должно содержать данные о характере обстоятельств и их оценку, чтобы определить возможные потери и время, необходимое для их устранения.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.5 Возникновение и (или) существование обстоятельств непреодолимой силы должно быть подтверждено документами, выданными компетентными органами.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.6 В случае возникновения обстоятельств непреодолимой силы Стороны обязуются консультироваться друг с другом относительно дальнейшего выполнения действий по Договору и прилагать все усилия к скорейшему исполнению своих обязательств.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.7 После прекращения обстоятельств непреодолимой силы Сторона, ссылавшаяся на такие обстоятельства, должна немедленно, но в любом случае не позднее 3 (трех) дней после прекращения действия обстоятельств непреодолимой силы, известить другую Сторону об этом и исполнить соответствующие обязательства по Договору. Сторона, не известившая или несвоевременно известившая другую Сторону о прекращении обстоятельств непреодолимой силы, обязана возместить другой Стороне все убытки, связанные с таким не извещением или несвоевременным извещением.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.8 Обязанность доказывания наличия обстоятельств непреодолимой силы возлагается на заявившую об этом Сторону.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">7.  ОСОБЫЕ УСЛОВИЯ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">" + TextBoxOsobieUslovijaDogovora5.Text + "<p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">8.  ПОРЯДОК РАЗРЕШЕНИЯ СПОРОВ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">Все споры, вытекающие  из условий настоящего  Договора, Стороны будут стремиться  разрешать путем переговоров. При этом заинтересованная сторона направляет другой Стороне письменную претензию.  Ответ на претензию должен быть направлен не позднее 10 дней с момента её получения. Если Стороны в ходе переговоров не смогут достичь соглашения, то спор подлежит рассмотрению в суде. Место рассмотрения спора " + TextBoxSud5.Text + ".</p><p class=\"P50\">Настоящий Договор составлен в двух одинаковых экземплярах, имеющих равную юридическую силу, по одному экземпляру для каждой из Сторон.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">Стороны договорились о том, что факсимильные и электронные копии договоров и иных документов, отправленные посредством электронной почты со стороны Исполнителя Заказчику и со стороны Заказчика Исполнителю имеют силу оригинала.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">9.  АДРЕСА МЕСТОНАХОЖДЕНИЯ, БАНКОВСКИЕ РЕКВИЗИТЫ И ПОДПИСИ СТОРОН</p><p class=\"P25\"> </p>\r\n");
                ///раздел с реквизитами сторон
                await FileIO.AppendTextAsync(Myfile2, "<table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile2, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxMojFIORuk5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataDogovora5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataDogovora5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile2, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile2, "\r\n");

                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile2);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл договора " + Myfile2.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл договора" + Myfile2.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция сохранения файла договора была прервана.";
            }
        }

        private async void SaveAkt5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новый акт";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">АКТ № А-" + TextBoxNomerDogovora5.Text + " об оказанных услугах по " + TextBoxUslugiPo5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataAkta5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", с одной стороны и Заказчик " + TextBoxFullNameKontr5.Text + ", в лице " + TextBoxVlice5.Text + ", с другой стороны, составили настоящий Акт о нижеследующем:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0 & CheckBoxTovar1.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0 & CheckBoxTovar2.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0 & CheckBoxTovar3.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0 & CheckBoxTovar4.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0 & CheckBoxTovar5.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0 & CheckBoxTovar6.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0 & CheckBoxTovar7.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0 & CheckBoxTovar8.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0 & CheckBoxTovar9.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0 & CheckBoxTovar10.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0 & CheckBoxTovar11.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0 & CheckBoxTovar12.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0 & CheckBoxTovar13.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0 & CheckBoxTovar14.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0 & CheckBoxTovar15.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0 & CheckBoxTovar16.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0 & CheckBoxTovar17.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0 & CheckBoxTovar18.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0 & CheckBoxTovar19.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0 & CheckBoxTovar20.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0 & CheckBoxTovar21.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0 & CheckBoxTovar22.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0 & CheckBoxTovar23.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0 & CheckBoxTovar24.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0 & CheckBoxTovar25.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0 & CheckBoxTovar26.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0 & CheckBoxTovar27.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0 & CheckBoxTovar28.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0 & CheckBoxTovar29.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0 & CheckBoxTovar30.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }



                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость оказанных услуг: " + TextBoxItogoSummaPoAktu5.Text + " рублей, без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Перечисленные выше услуги со стороны Исполнителя Заказчику в полном объеме и в оговоренные Сторонами сроки оказаны.</p><p class=\"P25\"> </p><p class=\"P113\">ЗАКАЗЧИК К ИСПОЛНИТЕЛЮ ПРЕТЕНЗИЙ НЕ ИМЕЕТ.</p>");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxMojFIORuk5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataAkta5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataAkta5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
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
                    this.TextBlockStatusFile5.Text = "Файл акта " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл акта " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла акта была прервана.";
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
                    string text1 = await Windows.Storage.FileIO.ReadTextAsync(Myfile4);
                    string text02 = text1.Replace("\r\n", " ");
                    string text002 = text02.Replace("\n", " ");
                    string text2 = text002.Replace("\r", " ");
                    FileTextBlock.Text = text2;
                    await FileIO.WriteTextAsync(Myfile4, text2);

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
            savePicker5.FileTypeChoices.Add("Документ", new List<string>() { ".docdata" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker5.SuggestedFileName = "Комплект документов к сделке";
            //
            Windows.Storage.StorageFile Myfile5 = await savePicker5.PickSaveFileAsync();
            if (Myfile5 != null)
            {
                ProgressRing1.IsActive = true;
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile5);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени
                string TShapkaWrite = "";
                if (CHeckBoxSchapka5.IsChecked == true) { TShapkaWrite = "1"; }

                await FileIO.WriteTextAsync(Myfile5, TextBoxFullNameKontr5.Text + ";" + TextBoxSokrNameKontr5.Text + ";" + TextBoxINN5.Text + ";" + TextBoxKPP5.Text + ";" + TextBoxOGRN5.Text + ";" + TextBoxBankRekv5.Text + ";" + TextBoxDolzhnostDirector5.Text + ";" + TextBoxVlice5.Text + ";" + TextBoxRukSokr5.Text + ";" + TextBoxUrAddr5.Text + ";" + TextBoxFactAddr5.Text + ";" + TextBoxPhone5.Text + ";" + TextBoxMobile5.Text + ";" + TextBoxEmail5.Text + ";" + TextBoxSajt5.Text + ";" + TextBoxMoeNaimenovaniePolnoe5.Text + ";" + TextBoxMoeNaimenovanieSokr5.Text + ";" + TextBoxMojINN5.Text + ";" + TextBoxMojKPP5.Text + ";" + TextBoxMojOGRN5.Text + ";" + TextBoxMoiBankName5.Text + ";" + TextBoxMoiBankBIK5.Text + ";" + TextBoxMoiBankKorr5.Text + ";" + TextBoxMoiRaschetnijSchet5.Text + ";" + TextBoxMojaRukDolzhnost5.Text + ";" + TextBoxMojVlice5.Text + ";" + TextBoxMojFIORuk5.Text + ";" + TextBoxMojUrAddr5.Text + ";" + TextBoxMojFackAddr5.Text + ";" + TextBoxMojPhone5.Text + ";" + TextBoxMojMobile5.Text + ";" + TextBoxMojEmail5.Text + ";" + TextBoxMojSait5.Text + ";" + TextBoxMojSlogan5.Text + ";" + TextBoxMojLogo5.Text + ";" + TextBoxMoiPechatPodpis5.Text + ";" + TShapkaWrite + ";" + TextBoxUslugiPo5.Text + ";" + TextBoxDataDogovora5.Text + ";" + TextBoxNomerDogovora5.Text + ";" + TextBoxDataNakladnoj5.Text + ";" + TextBoxDataAkta5.Text + ";" + TextBoxGarantija5.Text + ";" + TextBoxUslovijaOplati5.Text + ";" + TextBoxSrokiIspolnenija5.Text + ";" + TextBoxOsobieUslovijaDogovora5.Text + ";" + TextBoxGorodZaklDogovora5.Text + ";" + TextBoxSud5.Text + ";" + TextBoxDataSmeti5.Text + ";" + TextBoxDataDejstvijaSmeti5.Text + ";" + TextBoxFIOOtvetstvennij5.Text + ";" + TextBoxTovar1Naimenovanie5.Text + ";" + TextBoxTovar1Kolvo5.Text + ";" + TextBoxTovar1Ed5.Text + ";" + TextBoxTovar1CenaEd5.Text + ";" + TextBoxTovar1Stoimost5.Text + ";" + TextBoxTovar2Naimenovanie5.Text + ";" + TextBoxTovar2Kolvo5.Text + ";" + TextBoxTovar2Ed5.Text + ";" + TextBoxTovar2CenaEd5.Text + ";" + TextBoxTovar2Stoimost5.Text + ";" + TextBoxTovar3Naimenovanie5.Text + ";" + TextBoxTovar3Kolvo5.Text + ";" + TextBoxTovar3Ed5.Text + ";" + TextBoxTovar3CenaEd5.Text + ";" + TextBoxTovar3Stoimost5.Text + ";" + TextBoxTovar4Naimenovanie5.Text + ";" + TextBoxTovar4Kolvo5.Text + ";" + TextBoxTovar4Ed5.Text + ";" + TextBoxTovar4CenaEd5.Text + ";" + TextBoxTovar4Stoimost5.Text + ";" + TextBoxTovar5Naimenovanie5.Text + ";" + TextBoxTovar5Kolvo5.Text + ";" + TextBoxTovar5Ed5.Text + ";" + TextBoxTovar5CenaEd5.Text + ";" + TextBoxTovar5Stoimost5.Text + ";" + TextBoxTovar6Naimenovanie5.Text + ";" + TextBoxTovar6Kolvo5.Text + ";" + TextBoxTovar6Ed5.Text + ";" + TextBoxTovar6CenaEd5.Text + ";" + TextBoxTovar6Stoimost5.Text + ";" + TextBoxTovar7Naimenovanie5.Text + ";" + TextBoxTovar7Kolvo5.Text + ";" + TextBoxTovar7Ed5.Text + ";" + TextBoxTovar7CenaEd5.Text + ";" + TextBoxTovar7Stoimost5.Text + ";" + TextBoxTovar8Naimenovanie5.Text + ";" + TextBoxTovar8Kolvo5.Text + ";" + TextBoxTovar8Ed5.Text + ";" + TextBoxTovar8CenaEd5.Text + ";" + TextBoxTovar8Stoimost5.Text + ";" + TextBoxTovar9Naimenovanie5.Text + ";" + TextBoxTovar9Kolvo5.Text + ";" + TextBoxTovar9Ed5.Text + ";" + TextBoxTovar9CenaEd5.Text + ";" + TextBoxTovar9Stoimost5.Text + ";" + TextBoxTovar10Naimenovanie5.Text + ";" + TextBoxTovar10Kolvo5.Text + ";" + TextBoxTovar10Ed5.Text + ";" + TextBoxTovar10CenaEd5.Text + ";" + TextBoxTovar10Stoimost5.Text + ";"
                    + TextBoxTovar11Naimenovanie5.Text + ";" + TextBoxTovar11Kolvo5.Text + ";" + TextBoxTovar11Ed5.Text + ";" + TextBoxTovar11CenaEd5.Text + ";" + TextBoxTovar11Stoimost5.Text + ";" + TextBoxTovar12Naimenovanie5.Text + ";" + TextBoxTovar12Kolvo5.Text + ";" + TextBoxTovar12Ed5.Text + ";" + TextBoxTovar12CenaEd5.Text + ";" + TextBoxTovar12Stoimost5.Text + ";" + TextBoxTovar13Naimenovanie5.Text + ";" + TextBoxTovar13Kolvo5.Text + ";" + TextBoxTovar13Ed5.Text + ";" + TextBoxTovar13CenaEd5.Text + ";" + TextBoxTovar13Stoimost5.Text + ";" + TextBoxTovar14Naimenovanie5.Text + ";" + TextBoxTovar14Kolvo5.Text + ";" + TextBoxTovar14Ed5.Text + ";" + TextBoxTovar14CenaEd5.Text + ";" + TextBoxTovar14Stoimost5.Text + ";" + TextBoxTovar15Naimenovanie5.Text + ";" + TextBoxTovar15Kolvo5.Text + ";" + TextBoxTovar15Ed5.Text + ";" + TextBoxTovar15CenaEd5.Text + ";" + TextBoxTovar15Stoimost5.Text + ";"
                    + TextBoxTovar16Naimenovanie5.Text + ";" + TextBoxTovar16Kolvo5.Text + ";" + TextBoxTovar16Ed5.Text + ";" + TextBoxTovar16CenaEd5.Text + ";" + TextBoxTovar16Stoimost5.Text + ";" + TextBoxTovar17Naimenovanie5.Text + ";" + TextBoxTovar17Kolvo5.Text + ";" + TextBoxTovar17Ed5.Text + ";" + TextBoxTovar17CenaEd5.Text + ";" + TextBoxTovar17Stoimost5.Text + ";" + TextBoxTovar18Naimenovanie5.Text + ";" + TextBoxTovar18Kolvo5.Text + ";" + TextBoxTovar18Ed5.Text + ";" + TextBoxTovar18CenaEd5.Text + ";" + TextBoxTovar18Stoimost5.Text + ";" + TextBoxTovar19Naimenovanie5.Text + ";" + TextBoxTovar19Kolvo5.Text + ";" + TextBoxTovar19Ed5.Text + ";" + TextBoxTovar19CenaEd5.Text + ";" + TextBoxTovar19Stoimost5.Text + ";" + TextBoxTovar20Naimenovanie5.Text + ";" + TextBoxTovar20Kolvo5.Text + ";" + TextBoxTovar20Ed5.Text + ";" + TextBoxTovar20CenaEd5.Text + ";" + TextBoxTovar20Stoimost5.Text + ";"
                     + TextBoxTovar21Naimenovanie5.Text + ";" + TextBoxTovar21Kolvo5.Text + ";" + TextBoxTovar21Ed5.Text + ";" + TextBoxTovar21CenaEd5.Text + ";" + TextBoxTovar21Stoimost5.Text + ";" + TextBoxTovar22Naimenovanie5.Text + ";" + TextBoxTovar22Kolvo5.Text + ";" + TextBoxTovar22Ed5.Text + ";" + TextBoxTovar22CenaEd5.Text + ";" + TextBoxTovar22Stoimost5.Text + ";" + TextBoxTovar23Naimenovanie5.Text + ";" + TextBoxTovar23Kolvo5.Text + ";" + TextBoxTovar23Ed5.Text + ";" + TextBoxTovar23CenaEd5.Text + ";" + TextBoxTovar23Stoimost5.Text + ";" + TextBoxTovar24Naimenovanie5.Text + ";" + TextBoxTovar24Kolvo5.Text + ";" + TextBoxTovar24Ed5.Text + ";" + TextBoxTovar24CenaEd5.Text + ";" + TextBoxTovar24Stoimost5.Text + ";" + TextBoxTovar25Naimenovanie5.Text + ";" + TextBoxTovar25Kolvo5.Text + ";" + TextBoxTovar25Ed5.Text + ";" + TextBoxTovar25CenaEd5.Text + ";" + TextBoxTovar25Stoimost5.Text + ";"
                    + TextBoxTovar26Naimenovanie5.Text + ";" + TextBoxTovar26Kolvo5.Text + ";" + TextBoxTovar26Ed5.Text + ";" + TextBoxTovar26CenaEd5.Text + ";" + TextBoxTovar26Stoimost5.Text + ";" + TextBoxTovar27Naimenovanie5.Text + ";" + TextBoxTovar27Kolvo5.Text + ";" + TextBoxTovar27Ed5.Text + ";" + TextBoxTovar27CenaEd5.Text + ";" + TextBoxTovar27Stoimost5.Text + ";" + TextBoxTovar28Naimenovanie5.Text + ";" + TextBoxTovar28Kolvo5.Text + ";" + TextBoxTovar28Ed5.Text + ";" + TextBoxTovar28CenaEd5.Text + ";" + TextBoxTovar28Stoimost5.Text + ";" + TextBoxTovar29Naimenovanie5.Text + ";" + TextBoxTovar29Kolvo5.Text + ";" + TextBoxTovar29Ed5.Text + ";" + TextBoxTovar29CenaEd5.Text + ";" + TextBoxTovar29Stoimost5.Text + ";" + TextBoxTovar30Naimenovanie5.Text + ";" + TextBoxTovar30Kolvo5.Text + ";" + TextBoxTovar30Ed5.Text + ";" + TextBoxTovar30CenaEd5.Text + ";" + TextBoxTovar30Stoimost5.Text + ";"
                      + TextBoxItogo5.Text + ";" + TextBoxItogoPropis5.Text + ";" + TextBoxItogoNomerovPoNakladnoj5.Text + ";" + TextBoxItogoSummaPoNakladnoj5.Text + ";");

                if (CheckBoxTovar1.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar2.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar3.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar4.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar5.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                if (CheckBoxTovar6.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar7.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar8.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar9.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar10.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                if (CheckBoxTovar11.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar12.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar13.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar14.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar15.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                if (CheckBoxTovar16.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar17.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar18.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar19.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar20.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                if (CheckBoxTovar21.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar22.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar23.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar24.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar25.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                if (CheckBoxTovar26.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar27.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar28.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar29.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }
                if (CheckBoxTovar30.IsChecked == true) { await FileIO.AppendTextAsync(Myfile5, "1;"); } else { await FileIO.AppendTextAsync(Myfile5, ";"); }

                
                await FileIO.AppendTextAsync(Myfile5, TextBlockLoadNastrojkiMessage.Text+";"+TextBoxItogoSummaPoAktu5.Text+";");

                if (ComboBoxModule1.SelectedItem.Equals(Combo11) == true) { await FileIO.AppendTextAsync(Myfile5, "Сделано предложение;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo12) == true) { await FileIO.AppendTextAsync(Myfile5, "Заключен договор, выставлен счет;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo13) == true) { await FileIO.AppendTextAsync(Myfile5, "В работе;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo14) == true) { await FileIO.AppendTextAsync(Myfile5, "Исполнена, ожидает подписания актов/накладных;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo15) == true) { await FileIO.AppendTextAsync(Myfile5, "Ожидание оплаты;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo16) == true) { await FileIO.AppendTextAsync(Myfile5, "Завершена;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo17) == true) { await FileIO.AppendTextAsync(Myfile5, "Договор расторгнут;"); }
                if (ComboBoxModule1.SelectedItem.Equals(Combo011) == true) { await FileIO.AppendTextAsync(Myfile5, "Выберите статус;"); }

                if (ComboBoxKvartal.SelectedItem.Equals(ComboKvartalSearch0) == true) { await FileIO.AppendTextAsync(Myfile5, "Выберите квартал;"); }
                if (ComboBoxKvartal.SelectedItem.Equals(ComboKvartalSearch1) == true) { await FileIO.AppendTextAsync(Myfile5, "Первый квартал;"); }
                if (ComboBoxKvartal.SelectedItem.Equals(ComboKvartalSearch2) == true) { await FileIO.AppendTextAsync(Myfile5, "Второй квартал;"); }
                if (ComboBoxKvartal.SelectedItem.Equals(ComboKvartalSearch3) == true) { await FileIO.AppendTextAsync(Myfile5, "Третий квартал;"); }
                if (ComboBoxKvartal.SelectedItem.Equals(ComboKvartalSearch4) == true) { await FileIO.AppendTextAsync(Myfile5, "Четвертый квартал;"); }

                await FileIO.AppendTextAsync(Myfile5, TextBoxNalogYear.Text+";");

                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile5);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    string text1 = await Windows.Storage.FileIO.ReadTextAsync(Myfile5);
                    string text02 = text1.Replace("\r\n", " ");
                    string text002 = text02.Replace("\n", " ");
                    string text2 = text002.Replace("\r", " ");
                    FileTextBlock.Text = text2;
                    await FileIO.WriteTextAsync(Myfile5, text2);

                    ProgressRing1.IsActive = false;
                    this.TextBlockStatusFile5.Text = "Файл данных " + Myfile5.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл данных " + Myfile5.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла данных была прервана.";
            }
        }

        private async void LoadNastrojki5_Click(object sender, RoutedEventArgs e)
        {
            var picker3 = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker3.FileTypeFilter.Add(".docdata");
            Windows.Storage.StorageFile file3 = await picker3.PickSingleFileAsync();
            if (file3 != null)
            {
                //ОТКРЫВАЕМ ПОПАП
                this.PopupFileLoad.IsOpen = true;
                //КОНЕЦ ОТКРЫВАЕМ ПОПАП

                TextBlockLoadNastrojkiMessage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar2Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar2Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar2Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar2CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar2RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar2Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar3Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar3Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar3Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar3CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar3RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar3Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar4Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar4Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar4Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar4CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar4RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar4Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar5Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar5Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar5Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar5CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar5RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar5Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar6Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar6Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar6Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar6CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar6RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar6Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar7Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar7Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar7Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar7CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar7RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar7Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar7.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar8Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar8Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar8Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar8CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar8RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar8Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar8.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar9Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar9Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar9Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar9CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar9RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar9Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar9.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar10Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar10Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar10Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar10CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar10RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar10Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar10.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar11Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar11Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar11Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar11CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar11RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar11Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar11.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar12Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar12Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar12Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar12CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar12RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar12Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar12.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar13Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar13Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar13Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar13CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar13RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar13Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar13.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar14Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar14Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar14Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar14CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar14RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar14Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar14.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar15Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar15Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar15Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar15CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar15RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar15Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar15.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar16Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar16Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar16Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar16CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar16RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar16Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar16.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar17Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar17Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar17Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar17CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar17RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar17Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar17.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar18Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar18Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar18Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar18CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar18RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar18Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar18.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar19Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar19Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar19Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar19CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar19RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar19Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar19.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar20Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar20Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar20Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar20CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar20RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar20Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar20.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar21Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar21Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar21Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar21CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar21RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar21Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar21.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar22Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar22Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar22Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar22CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar22RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar22Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar22.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar23Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar23Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar23Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar23CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar23RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar23Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar23.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar24Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar24Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar24Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar24CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar24RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar24Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar24.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar25Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar25Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar25Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar25CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar25RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar25Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar25.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar26Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar26Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar26Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar26CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar26RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar26Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar26.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar27Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar27Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar27Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar27CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar27RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar27Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar27.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar28Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar28Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar28Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar28CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar28RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar28Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar28.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar29Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar29Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar29Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar29CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar29RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar29Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar29.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar30Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar30Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar30Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar30CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonTovar30RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxTovar30Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CheckBoxTovar30.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                RemoveTovar30Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxTovar2Naimenovanie5.Text = "";
                TextBoxTovar2Kolvo5.Text = "";
                TextBoxTovar2Ed5.Text = "";
                TextBoxTovar2CenaEd5.Text = "";
                TextBoxTovar2Stoimost5.Text = "";
                CheckBoxTovar2.IsChecked = false;

                TextBoxTovar3Naimenovanie5.Text = "";
                TextBoxTovar3Kolvo5.Text = "";
                TextBoxTovar3Ed5.Text = "";
                TextBoxTovar3CenaEd5.Text = "";
                TextBoxTovar3Stoimost5.Text = "";
                CheckBoxTovar3.IsChecked = false;

                TextBoxTovar4Naimenovanie5.Text = "";
                TextBoxTovar4Kolvo5.Text = "";
                TextBoxTovar4Ed5.Text = "";
                TextBoxTovar4CenaEd5.Text = "";
                TextBoxTovar4Stoimost5.Text = "";
                CheckBoxTovar4.IsChecked = false;

                TextBoxTovar5Naimenovanie5.Text = "";
                TextBoxTovar5Kolvo5.Text = "";
                TextBoxTovar5Ed5.Text = "";
                TextBoxTovar5CenaEd5.Text = "";
                TextBoxTovar5Stoimost5.Text = "";
                CheckBoxTovar5.IsChecked = false;

                TextBoxTovar6Naimenovanie5.Text = "";
                TextBoxTovar6Kolvo5.Text = "";
                TextBoxTovar6Ed5.Text = "";
                TextBoxTovar6CenaEd5.Text = "";
                TextBoxTovar6Stoimost5.Text = "";
                CheckBoxTovar6.IsChecked = false;

                TextBoxTovar7Naimenovanie5.Text = "";
                TextBoxTovar7Kolvo5.Text = "";
                TextBoxTovar7Ed5.Text = "";
                TextBoxTovar7CenaEd5.Text = "";
                TextBoxTovar7Stoimost5.Text = "";
                CheckBoxTovar7.IsChecked = false;

                TextBoxTovar8Naimenovanie5.Text = "";
                TextBoxTovar8Kolvo5.Text = "";
                TextBoxTovar8Ed5.Text = "";
                TextBoxTovar8CenaEd5.Text = "";
                TextBoxTovar8Stoimost5.Text = "";
                CheckBoxTovar8.IsChecked = false;

                TextBoxTovar9Naimenovanie5.Text = "";
                TextBoxTovar9Kolvo5.Text = "";
                TextBoxTovar9Ed5.Text = "";
                TextBoxTovar9CenaEd5.Text = "";
                TextBoxTovar9Stoimost5.Text = "";
                CheckBoxTovar9.IsChecked = false;

                TextBoxTovar10Naimenovanie5.Text = "";
                TextBoxTovar10Kolvo5.Text = "";
                TextBoxTovar10Ed5.Text = "";
                TextBoxTovar10CenaEd5.Text = "";
                TextBoxTovar10Stoimost5.Text = "";
                CheckBoxTovar10.IsChecked = false;

                TextBoxTovar11Naimenovanie5.Text = "";
                TextBoxTovar11Kolvo5.Text = "";
                TextBoxTovar11Ed5.Text = "";
                TextBoxTovar11CenaEd5.Text = "";
                TextBoxTovar11Stoimost5.Text = "";
                CheckBoxTovar11.IsChecked = false;

                TextBoxTovar12Naimenovanie5.Text = "";
                TextBoxTovar12Kolvo5.Text = "";
                TextBoxTovar12Ed5.Text = "";
                TextBoxTovar12CenaEd5.Text = "";
                TextBoxTovar12Stoimost5.Text = "";
                CheckBoxTovar12.IsChecked = false;

                TextBoxTovar13Naimenovanie5.Text = "";
                TextBoxTovar13Kolvo5.Text = "";
                TextBoxTovar13Ed5.Text = "";
                TextBoxTovar13CenaEd5.Text = "";
                TextBoxTovar13Stoimost5.Text = "";
                CheckBoxTovar13.IsChecked = false;

                TextBoxTovar14Naimenovanie5.Text = "";
                TextBoxTovar14Kolvo5.Text = "";
                TextBoxTovar14Ed5.Text = "";
                TextBoxTovar14CenaEd5.Text = "";
                TextBoxTovar14Stoimost5.Text = "";
                CheckBoxTovar14.IsChecked = false;

                TextBoxTovar15Naimenovanie5.Text = "";
                TextBoxTovar15Kolvo5.Text = "";
                TextBoxTovar15Ed5.Text = "";
                TextBoxTovar15CenaEd5.Text = "";
                TextBoxTovar15Stoimost5.Text = "";
                CheckBoxTovar15.IsChecked = false;

                TextBoxTovar16Naimenovanie5.Text = "";
                TextBoxTovar16Kolvo5.Text = "";
                TextBoxTovar16Ed5.Text = "";
                TextBoxTovar16CenaEd5.Text = "";
                TextBoxTovar16Stoimost5.Text = "";
                CheckBoxTovar16.IsChecked = false;

                TextBoxTovar17Naimenovanie5.Text = "";
                TextBoxTovar17Kolvo5.Text = "";
                TextBoxTovar17Ed5.Text = "";
                TextBoxTovar17CenaEd5.Text = "";
                TextBoxTovar17Stoimost5.Text = "";
                CheckBoxTovar17.IsChecked = false;

                TextBoxTovar18Naimenovanie5.Text = "";
                TextBoxTovar18Kolvo5.Text = "";
                TextBoxTovar18Ed5.Text = "";
                TextBoxTovar18CenaEd5.Text = "";
                TextBoxTovar18Stoimost5.Text = "";
                CheckBoxTovar18.IsChecked = false;

                TextBoxTovar19Naimenovanie5.Text = "";
                TextBoxTovar19Kolvo5.Text = "";
                TextBoxTovar19Ed5.Text = "";
                TextBoxTovar19CenaEd5.Text = "";
                TextBoxTovar19Stoimost5.Text = "";
                CheckBoxTovar19.IsChecked = false;

                TextBoxTovar20Naimenovanie5.Text = "";
                TextBoxTovar20Kolvo5.Text = "";
                TextBoxTovar20Ed5.Text = "";
                TextBoxTovar20CenaEd5.Text = "";
                TextBoxTovar20Stoimost5.Text = "";
                CheckBoxTovar20.IsChecked = false;

                TextBoxTovar21Naimenovanie5.Text = "";
                TextBoxTovar21Kolvo5.Text = "";
                TextBoxTovar21Ed5.Text = "";
                TextBoxTovar21CenaEd5.Text = "";
                TextBoxTovar21Stoimost5.Text = "";
                CheckBoxTovar21.IsChecked = false;

                TextBoxTovar22Naimenovanie5.Text = "";
                TextBoxTovar22Kolvo5.Text = "";
                TextBoxTovar22Ed5.Text = "";
                TextBoxTovar22CenaEd5.Text = "";
                TextBoxTovar22Stoimost5.Text = "";
                CheckBoxTovar22.IsChecked = false;

                TextBoxTovar23Naimenovanie5.Text = "";
                TextBoxTovar23Kolvo5.Text = "";
                TextBoxTovar23Ed5.Text = "";
                TextBoxTovar23CenaEd5.Text = "";
                TextBoxTovar23Stoimost5.Text = "";
                CheckBoxTovar23.IsChecked = false;

                TextBoxTovar24Naimenovanie5.Text = "";
                TextBoxTovar24Kolvo5.Text = "";
                TextBoxTovar24Ed5.Text = "";
                TextBoxTovar24CenaEd5.Text = "";
                TextBoxTovar24Stoimost5.Text = "";
                CheckBoxTovar24.IsChecked = false;

                TextBoxTovar25Naimenovanie5.Text = "";
                TextBoxTovar25Kolvo5.Text = "";
                TextBoxTovar25Ed5.Text = "";
                TextBoxTovar25CenaEd5.Text = "";
                TextBoxTovar25Stoimost5.Text = "";
                CheckBoxTovar25.IsChecked = false;

                TextBoxTovar26Naimenovanie5.Text = "";
                TextBoxTovar26Kolvo5.Text = "";
                TextBoxTovar26Ed5.Text = "";
                TextBoxTovar26CenaEd5.Text = "";
                TextBoxTovar26Stoimost5.Text = "";
                CheckBoxTovar26.IsChecked = false;

                TextBoxTovar27Naimenovanie5.Text = "";
                TextBoxTovar27Kolvo5.Text = "";
                TextBoxTovar27Ed5.Text = "";
                TextBoxTovar27CenaEd5.Text = "";
                TextBoxTovar27Stoimost5.Text = "";
                CheckBoxTovar27.IsChecked = false;

                TextBoxTovar28Naimenovanie5.Text = "";
                TextBoxTovar28Kolvo5.Text = "";
                TextBoxTovar28Ed5.Text = "";
                TextBoxTovar28CenaEd5.Text = "";
                TextBoxTovar28Stoimost5.Text = "";
                CheckBoxTovar28.IsChecked = false;

                TextBoxTovar29Naimenovanie5.Text = "";
                TextBoxTovar29Kolvo5.Text = "";
                TextBoxTovar29Ed5.Text = "";
                TextBoxTovar29CenaEd5.Text = "";
                TextBoxTovar29Stoimost5.Text = "";
                CheckBoxTovar29.IsChecked = false;

                TextBoxTovar30Naimenovanie5.Text = "";
                TextBoxTovar30Kolvo5.Text = "";
                TextBoxTovar30Ed5.Text = "";
                TextBoxTovar30CenaEd5.Text = "";
                TextBoxTovar30Stoimost5.Text = "";
                CheckBoxTovar30.IsChecked = false;

                TextBoxItogoSummaPoAktu5.Text = "";
                TextBoxItogoSummaPoNakladnoj5.Text = "";
                TextBoxItogoNomerovPoNakladnoj5.Text = "";
                TextBoxItogoPropis5.Text = "";
                TextBoxItogo5.Text = "";

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
                    TextBoxMobile5.Text = line.Split(';')[12];
                    TextBoxEmail5.Text = line.Split(';')[13];
                    TextBoxSajt5.Text = line.Split(';')[14];
                    TextBoxMoeNaimenovaniePolnoe5.Text = line.Split(';')[15];
                    TextBoxMoeNaimenovanieSokr5.Text = line.Split(';')[16];
                    TextBoxMojINN5.Text = line.Split(';')[17];
                    TextBoxMojKPP5.Text = line.Split(';')[18];
                    TextBoxMojOGRN5.Text = line.Split(';')[19];
                    TextBoxMoiBankName5.Text = line.Split(';')[20];
                    TextBoxMoiBankBIK5.Text = line.Split(';')[21];
                    TextBoxMoiBankKorr5.Text = line.Split(';')[22];
                    TextBoxMoiRaschetnijSchet5.Text = line.Split(';')[23];
                    TextBoxMojaRukDolzhnost5.Text = line.Split(';')[24];
                    TextBoxMojVlice5.Text = line.Split(';')[25];
                    TextBoxMojFIORuk5.Text = line.Split(';')[26];
                    TextBoxMojUrAddr5.Text = line.Split(';')[27];
                    TextBoxMojFackAddr5.Text = line.Split(';')[28];
                    TextBoxMojPhone5.Text = line.Split(';')[29];
                    TextBoxMojMobile5.Text = line.Split(';')[30];
                    TextBoxMojEmail5.Text = line.Split(';')[31];
                    TextBoxMojSait5.Text = line.Split(';')[32];
                    TextBoxMojSlogan5.Text = line.Split(';')[33];
                    TextBoxMojLogo5.Text = line.Split(';')[34];
                    TextBoxMoiPechatPodpis5.Text = line.Split(';')[35];

                    string TShapka = line.Split(';')[36];

                    TextBoxUslugiPo5.Text = line.Split(';')[37];
                    TextBoxDataDogovora5.Text = line.Split(';')[38];
                    TextBoxNomerDogovora5.Text = line.Split(';')[39];
                    TextBoxDataNakladnoj5.Text = line.Split(';')[40];
                    TextBoxDataAkta5.Text = line.Split(';')[41];
                    TextBoxGarantija5.Text = line.Split(';')[42];
                    TextBoxUslovijaOplati5.Text = line.Split(';')[43];
                    TextBoxSrokiIspolnenija5.Text = line.Split(';')[44];

                    TextBoxOsobieUslovijaDogovora5.Text = line.Split(';')[45];
                    TextBoxGorodZaklDogovora5.Text = line.Split(';')[46];
                    TextBoxSud5.Text = line.Split(';')[47];
                    TextBoxDataSmeti5.Text = line.Split(';')[48];
                    TextBoxDataDejstvijaSmeti5.Text = line.Split(';')[49];
                    TextBoxFIOOtvetstvennij5.Text = line.Split(';')[50];

                    TextBoxTovar1Naimenovanie5.Text = line.Split(';')[51];
                    TextBoxTovar1Kolvo5.Text = line.Split(';')[52];
                    TextBoxTovar1Ed5.Text = line.Split(';')[53];
                    TextBoxTovar1CenaEd5.Text = line.Split(';')[54];
                    TextBoxTovar1Stoimost5.Text = line.Split(';')[55];

                    TextBoxTovar2Naimenovanie5.Text = line.Split(';')[56];
                    TextBoxTovar2Kolvo5.Text = line.Split(';')[57];
                    TextBoxTovar2Ed5.Text = line.Split(';')[58];
                    TextBoxTovar2CenaEd5.Text = line.Split(';')[59];
                    TextBoxTovar2Stoimost5.Text = line.Split(';')[60];

                    TextBoxTovar3Naimenovanie5.Text = line.Split(';')[61];
                    TextBoxTovar3Kolvo5.Text = line.Split(';')[62];
                    TextBoxTovar3Ed5.Text = line.Split(';')[63];
                    TextBoxTovar3CenaEd5.Text = line.Split(';')[64];
                    TextBoxTovar3Stoimost5.Text = line.Split(';')[65];

                    TextBoxTovar4Naimenovanie5.Text = line.Split(';')[66];
                    TextBoxTovar4Kolvo5.Text = line.Split(';')[67];
                    TextBoxTovar4Ed5.Text = line.Split(';')[68];
                    TextBoxTovar4CenaEd5.Text = line.Split(';')[69];
                    TextBoxTovar4Stoimost5.Text = line.Split(';')[70];

                    TextBoxTovar5Naimenovanie5.Text = line.Split(';')[71];
                    TextBoxTovar5Kolvo5.Text = line.Split(';')[72];
                    TextBoxTovar5Ed5.Text = line.Split(';')[73];
                    TextBoxTovar5CenaEd5.Text = line.Split(';')[74];
                    TextBoxTovar5Stoimost5.Text = line.Split(';')[75];

                    TextBoxTovar6Naimenovanie5.Text = line.Split(';')[76];
                    TextBoxTovar6Kolvo5.Text = line.Split(';')[77];
                    TextBoxTovar6Ed5.Text = line.Split(';')[78];
                    TextBoxTovar6CenaEd5.Text = line.Split(';')[79];
                    TextBoxTovar6Stoimost5.Text = line.Split(';')[80];

                    TextBoxTovar7Naimenovanie5.Text = line.Split(';')[81];
                    TextBoxTovar7Kolvo5.Text = line.Split(';')[82];
                    TextBoxTovar7Ed5.Text = line.Split(';')[83];
                    TextBoxTovar7CenaEd5.Text = line.Split(';')[84];
                    TextBoxTovar7Stoimost5.Text = line.Split(';')[85];

                    TextBoxTovar8Naimenovanie5.Text = line.Split(';')[86];
                    TextBoxTovar8Kolvo5.Text = line.Split(';')[87];
                    TextBoxTovar8Ed5.Text = line.Split(';')[88];
                    TextBoxTovar8CenaEd5.Text = line.Split(';')[89];
                    TextBoxTovar8Stoimost5.Text = line.Split(';')[90];

                    TextBoxTovar9Naimenovanie5.Text = line.Split(';')[91];
                    TextBoxTovar9Kolvo5.Text = line.Split(';')[92];
                    TextBoxTovar9Ed5.Text = line.Split(';')[93];
                    TextBoxTovar9CenaEd5.Text = line.Split(';')[94];
                    TextBoxTovar9Stoimost5.Text = line.Split(';')[95];

                    TextBoxTovar10Naimenovanie5.Text = line.Split(';')[96];
                    TextBoxTovar10Kolvo5.Text = line.Split(';')[97];
                    TextBoxTovar10Ed5.Text = line.Split(';')[98];
                    TextBoxTovar10CenaEd5.Text = line.Split(';')[99];
                    TextBoxTovar10Stoimost5.Text = line.Split(';')[100];

                    TextBoxTovar11Naimenovanie5.Text = line.Split(';')[101];
                    TextBoxTovar11Kolvo5.Text = line.Split(';')[102];
                    TextBoxTovar11Ed5.Text = line.Split(';')[103];
                    TextBoxTovar11CenaEd5.Text = line.Split(';')[104];
                    TextBoxTovar11Stoimost5.Text = line.Split(';')[105];

                    TextBoxTovar12Naimenovanie5.Text = line.Split(';')[106];
                    TextBoxTovar12Kolvo5.Text = line.Split(';')[107];
                    TextBoxTovar12Ed5.Text = line.Split(';')[108];
                    TextBoxTovar12CenaEd5.Text = line.Split(';')[109];
                    TextBoxTovar12Stoimost5.Text = line.Split(';')[110];

                    TextBoxTovar13Naimenovanie5.Text = line.Split(';')[111];
                    TextBoxTovar13Kolvo5.Text = line.Split(';')[112];
                    TextBoxTovar13Ed5.Text = line.Split(';')[113];
                    TextBoxTovar13CenaEd5.Text = line.Split(';')[114];
                    TextBoxTovar13Stoimost5.Text = line.Split(';')[115];

                    TextBoxTovar14Naimenovanie5.Text = line.Split(';')[116];
                    TextBoxTovar14Kolvo5.Text = line.Split(';')[117];
                    TextBoxTovar14Ed5.Text = line.Split(';')[118];
                    TextBoxTovar14CenaEd5.Text = line.Split(';')[119];
                    TextBoxTovar14Stoimost5.Text = line.Split(';')[120];

                    TextBoxTovar15Naimenovanie5.Text = line.Split(';')[121];
                    TextBoxTovar15Kolvo5.Text = line.Split(';')[122];
                    TextBoxTovar15Ed5.Text = line.Split(';')[123];
                    TextBoxTovar15CenaEd5.Text = line.Split(';')[124];
                    TextBoxTovar15Stoimost5.Text = line.Split(';')[125];

                    TextBoxTovar16Naimenovanie5.Text = line.Split(';')[126];
                    TextBoxTovar16Kolvo5.Text = line.Split(';')[127];
                    TextBoxTovar16Ed5.Text = line.Split(';')[128];
                    TextBoxTovar16CenaEd5.Text = line.Split(';')[129];
                    TextBoxTovar16Stoimost5.Text = line.Split(';')[130];

                    TextBoxTovar17Naimenovanie5.Text = line.Split(';')[131];
                    TextBoxTovar17Kolvo5.Text = line.Split(';')[132];
                    TextBoxTovar17Ed5.Text = line.Split(';')[133];
                    TextBoxTovar17CenaEd5.Text = line.Split(';')[134];
                    TextBoxTovar17Stoimost5.Text = line.Split(';')[135];

                    TextBoxTovar18Naimenovanie5.Text = line.Split(';')[136];
                    TextBoxTovar18Kolvo5.Text = line.Split(';')[137];
                    TextBoxTovar18Ed5.Text = line.Split(';')[138];
                    TextBoxTovar18CenaEd5.Text = line.Split(';')[139];
                    TextBoxTovar18Stoimost5.Text = line.Split(';')[140];

                    TextBoxTovar19Naimenovanie5.Text = line.Split(';')[141];
                    TextBoxTovar19Kolvo5.Text = line.Split(';')[142];
                    TextBoxTovar19Ed5.Text = line.Split(';')[143];
                    TextBoxTovar19CenaEd5.Text = line.Split(';')[144];
                    TextBoxTovar19Stoimost5.Text = line.Split(';')[145];

                    TextBoxTovar20Naimenovanie5.Text = line.Split(';')[146];
                    TextBoxTovar20Kolvo5.Text = line.Split(';')[147];
                    TextBoxTovar20Ed5.Text = line.Split(';')[148];
                    TextBoxTovar20CenaEd5.Text = line.Split(';')[149];
                    TextBoxTovar20Stoimost5.Text = line.Split(';')[150];

                    TextBoxTovar21Naimenovanie5.Text = line.Split(';')[151];
                    TextBoxTovar21Kolvo5.Text = line.Split(';')[152];
                    TextBoxTovar21Ed5.Text = line.Split(';')[153];
                    TextBoxTovar21CenaEd5.Text = line.Split(';')[154];
                    TextBoxTovar21Stoimost5.Text = line.Split(';')[155];

                    TextBoxTovar22Naimenovanie5.Text = line.Split(';')[156];
                    TextBoxTovar22Kolvo5.Text = line.Split(';')[157];
                    TextBoxTovar22Ed5.Text = line.Split(';')[158];
                    TextBoxTovar22CenaEd5.Text = line.Split(';')[159];
                    TextBoxTovar22Stoimost5.Text = line.Split(';')[160];

                    TextBoxTovar23Naimenovanie5.Text = line.Split(';')[161];
                    TextBoxTovar23Kolvo5.Text = line.Split(';')[162];
                    TextBoxTovar23Ed5.Text = line.Split(';')[163];
                    TextBoxTovar23CenaEd5.Text = line.Split(';')[164];
                    TextBoxTovar23Stoimost5.Text = line.Split(';')[165];

                    TextBoxTovar24Naimenovanie5.Text = line.Split(';')[166];
                    TextBoxTovar24Kolvo5.Text = line.Split(';')[167];
                    TextBoxTovar24Ed5.Text = line.Split(';')[168];
                    TextBoxTovar24CenaEd5.Text = line.Split(';')[169];
                    TextBoxTovar24Stoimost5.Text = line.Split(';')[170];

                    TextBoxTovar25Naimenovanie5.Text = line.Split(';')[171];
                    TextBoxTovar25Kolvo5.Text = line.Split(';')[172];
                    TextBoxTovar25Ed5.Text = line.Split(';')[173];
                    TextBoxTovar25CenaEd5.Text = line.Split(';')[174];
                    TextBoxTovar25Stoimost5.Text = line.Split(';')[175];

                    TextBoxTovar26Naimenovanie5.Text = line.Split(';')[176];
                    TextBoxTovar26Kolvo5.Text = line.Split(';')[177];
                    TextBoxTovar26Ed5.Text = line.Split(';')[178];
                    TextBoxTovar26CenaEd5.Text = line.Split(';')[179];
                    TextBoxTovar26Stoimost5.Text = line.Split(';')[180];

                    TextBoxTovar27Naimenovanie5.Text = line.Split(';')[181];
                    TextBoxTovar27Kolvo5.Text = line.Split(';')[182];
                    TextBoxTovar27Ed5.Text = line.Split(';')[183];
                    TextBoxTovar27CenaEd5.Text = line.Split(';')[184];
                    TextBoxTovar27Stoimost5.Text = line.Split(';')[185];

                    TextBoxTovar28Naimenovanie5.Text = line.Split(';')[186];
                    TextBoxTovar28Kolvo5.Text = line.Split(';')[187];
                    TextBoxTovar28Ed5.Text = line.Split(';')[188];
                    TextBoxTovar28CenaEd5.Text = line.Split(';')[189];
                    TextBoxTovar28Stoimost5.Text = line.Split(';')[190];

                    TextBoxTovar29Naimenovanie5.Text = line.Split(';')[191];
                    TextBoxTovar29Kolvo5.Text = line.Split(';')[192];
                    TextBoxTovar29Ed5.Text = line.Split(';')[193];
                    TextBoxTovar29CenaEd5.Text = line.Split(';')[194];
                    TextBoxTovar29Stoimost5.Text = line.Split(';')[195];

                    TextBoxTovar30Naimenovanie5.Text = line.Split(';')[196];
                    TextBoxTovar30Kolvo5.Text = line.Split(';')[197];
                    TextBoxTovar30Ed5.Text = line.Split(';')[198];
                    TextBoxTovar30CenaEd5.Text = line.Split(';')[199];
                    TextBoxTovar30Stoimost5.Text = line.Split(';')[200];

                    TextBoxItogo5.Text = line.Split(';')[201];
                    TextBoxItogoPropis5.Text = line.Split(';')[202];
                    TextBoxItogoNomerovPoNakladnoj5.Text = line.Split(';')[203];
                    TextBoxItogoSummaPoNakladnoj5.Text = line.Split(';')[204];

                    string T1 = line.Split(';')[205];
                    string T2 = line.Split(';')[206];
                    string T3 = line.Split(';')[207];
                    string T4 = line.Split(';')[208];
                    string T5 = line.Split(';')[209];
                    string T6 = line.Split(';')[210];
                    string T7 = line.Split(';')[211];
                    string T8 = line.Split(';')[212];
                    string T9 = line.Split(';')[213];
                    string T10 = line.Split(';')[214];
                    string T11 = line.Split(';')[215];
                    string T12 = line.Split(';')[216];
                    string T13 = line.Split(';')[217];
                    string T14 = line.Split(';')[218];
                    string T15 = line.Split(';')[219];
                    string T16 = line.Split(';')[220];
                    string T17 = line.Split(';')[221];
                    string T18 = line.Split(';')[222];
                    string T19 = line.Split(';')[223];
                    string T20 = line.Split(';')[224];
                    string T21 = line.Split(';')[225];
                    string T22 = line.Split(';')[226];
                    string T23 = line.Split(';')[227];
                    string T24 = line.Split(';')[228];
                    string T25 = line.Split(';')[229];
                    string T26 = line.Split(';')[230];
                    string T27 = line.Split(';')[231];
                    string T28 = line.Split(';')[232];
                    string T29 = line.Split(';')[233];
                    string T30 = line.Split(';')[234];

                    string TPage = line.Split(';')[235];

                    if (T1 == "1") { CheckBoxTovar1.IsChecked = true; }
                    if (T2 == "1") { CheckBoxTovar2.IsChecked = true; }
                    if (T3 == "1") { CheckBoxTovar3.IsChecked = true; }
                    if (T4 == "1") { CheckBoxTovar4.IsChecked = true; }
                    if (T5 == "1") { CheckBoxTovar5.IsChecked = true; }
                    if (T6 == "1") { CheckBoxTovar6.IsChecked = true; }
                    if (T7 == "1") { CheckBoxTovar7.IsChecked = true; }
                    if (T8 == "1") { CheckBoxTovar8.IsChecked = true; }
                    if (T9 == "1") { CheckBoxTovar9.IsChecked = true; }
                    if (T10 == "1") { CheckBoxTovar10.IsChecked = true; }
                    if (T11 == "1") { CheckBoxTovar11.IsChecked = true; }
                    if (T12 == "1") { CheckBoxTovar12.IsChecked = true; }
                    if (T13 == "1") { CheckBoxTovar13.IsChecked = true; }
                    if (T14 == "1") { CheckBoxTovar14.IsChecked = true; }
                    if (T15 == "1") { CheckBoxTovar15.IsChecked = true; }
                    if (T16 == "1") { CheckBoxTovar16.IsChecked = true; }
                    if (T17 == "1") { CheckBoxTovar17.IsChecked = true; }
                    if (T18 == "1") { CheckBoxTovar18.IsChecked = true; }
                    if (T19 == "1") { CheckBoxTovar19.IsChecked = true; }
                    if (T20 == "1") { CheckBoxTovar20.IsChecked = true; }
                    if (T21 == "1") { CheckBoxTovar21.IsChecked = true; }
                    if (T22 == "1") { CheckBoxTovar22.IsChecked = true; }
                    if (T23 == "1") { CheckBoxTovar23.IsChecked = true; }
                    if (T24 == "1") { CheckBoxTovar24.IsChecked = true; }
                    if (T25 == "1") { CheckBoxTovar25.IsChecked = true; }
                    if (T26 == "1") { CheckBoxTovar26.IsChecked = true; }
                    if (T27 == "1") { CheckBoxTovar27.IsChecked = true; }
                    if (T28 == "1") { CheckBoxTovar28.IsChecked = true; }
                    if (T29 == "1") { CheckBoxTovar29.IsChecked = true; }
                    if (T30 == "1") { CheckBoxTovar30.IsChecked = true; }

                    if (TShapka == "1") { CHeckBoxSchapka5.IsChecked = true; }

                    //if (TPage != "10" && TPage != "5" && TPage != "15" && TPage != "20" && TPage != "25" && TPage != "30") { TextBlockLoadNastrojkiMessage.Text = "Этот документ выполнен на странице " + TPage + " товаров/услуг. Рекомендуем перезагрузить файл в нужном разделе."; } else { TextBlockLoadNastrojkiMessage.Text = ""; }

                    if (TPage == "2") { this.AddTovar1Next_Click(this, e); }
                    if (TPage == "3") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); }
                    if (TPage == "4") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); }
                    if (TPage == "5") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); }
                    if (TPage == "6") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); }
                    if (TPage == "7") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); }
                    if (TPage == "8") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); }
                    if (TPage == "9") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); }
                    if (TPage == "10") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); }
                    if (TPage == "11") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); }
                    if (TPage == "12") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); }
                    if (TPage == "13") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); }
                    if (TPage == "14") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); }
                    if (TPage == "15") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); }
                    if (TPage == "16") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); }
                    if (TPage == "17") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); }
                    if (TPage == "18") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); }
                    if (TPage == "19") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); }
                    if (TPage == "20") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); }
                    if (TPage == "21") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); }
                    if (TPage == "22") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); }
                    if (TPage == "23") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); }
                    if (TPage == "24") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); }
                    if (TPage == "25") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); }
                    if (TPage == "26") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); this.AddTovar25Next_Click(this, e); }
                    if (TPage == "27") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); this.AddTovar25Next_Click(this, e); this.AddTovar26Next_Click(this, e); }
                    if (TPage == "28") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); this.AddTovar25Next_Click(this, e); this.AddTovar26Next_Click(this, e); this.AddTovar27Next_Click(this, e); }
                    if (TPage == "29") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); this.AddTovar25Next_Click(this, e); this.AddTovar26Next_Click(this, e); this.AddTovar27Next_Click(this, e); this.AddTovar28Next_Click(this, e); }
                    if (TPage == "30") { this.AddTovar1Next_Click(this, e); this.AddTovar2Next_Click(this, e); this.AddTovar3Next_Click(this, e); this.AddTovar4Next_Click(this, e); this.AddTovar5Next_Click(this, e); this.AddTovar6Next_Click(this, e); this.AddTovar7Next_Click(this, e); this.AddTovar8Next_Click(this, e); this.AddTovar9Next_Click(this, e); this.AddTovar10Next_Click(this, e); this.AddTovar11Next_Click(this, e); this.AddTovar12Next_Click(this, e); this.AddTovar13Next_Click(this, e); this.AddTovar14Next_Click(this, e); this.AddTovar15Next_Click(this, e); this.AddTovar16Next_Click(this, e); this.AddTovar17Next_Click(this, e); this.AddTovar18Next_Click(this, e); this.AddTovar19Next_Click(this, e); this.AddTovar20Next_Click(this, e); this.AddTovar21Next_Click(this, e); this.AddTovar22Next_Click(this, e); this.AddTovar23Next_Click(this, e); this.AddTovar24Next_Click(this, e); this.AddTovar25Next_Click(this, e); this.AddTovar26Next_Click(this, e); this.AddTovar27Next_Click(this, e); this.AddTovar28Next_Click(this, e); this.AddTovar29Next_Click(this, e); }

                    try
                    {
                        TextBoxItogoSummaPoAktu5.Text = line.Split(';')[236];
                    }
                    catch
                    { }

                    try
                    {
                        string t1 = line.Split(';')[237];
                        if (t1 == "Сделано предложение") { ComboBoxModule1.SelectedItem = Combo11; }
                        if (t1 == "Заключен договор, выставлен счет") { ComboBoxModule1.SelectedItem = Combo12; }
                        if (t1 == "В работе") { ComboBoxModule1.SelectedItem = Combo13; }
                        if (t1 == "Исполнена, ожидает подписания актов/накладных") { ComboBoxModule1.SelectedItem = Combo14; }
                        if (t1 == "Ожидание оплаты") { ComboBoxModule1.SelectedItem = Combo15; }
                        if (t1 == "Завершена") { ComboBoxModule1.SelectedItem = Combo16; }
                        if (t1 == "Договор расторгнут") { ComboBoxModule1.SelectedItem = Combo17; }
                        if (t1 == "Выберите статус" || t1 == "") { ComboBoxModule1.SelectedItem = Combo011; }
                    }

                    catch { }

                    try
                    {
                        string t2 = line.Split(';')[238];
                        if (t2 == "Выберите квартал" || t2=="") { ComboBoxKvartal.SelectedItem = ComboKvartalSearch0; }
                        if (t2 == "Первый квартал") { ComboBoxKvartal.SelectedItem = ComboKvartalSearch1; }
                        if (t2 == "Второй квартал") { ComboBoxKvartal.SelectedItem = ComboKvartalSearch2; }
                        if (t2 == "Третий квартал") { ComboBoxKvartal.SelectedItem = ComboKvartalSearch3; }
                        if (t2 == "Четвертый квартал") { ComboBoxKvartal.SelectedItem = ComboKvartalSearch4; }
                        TextBoxNalogYear.Text= line.Split(';')[239];
                    }

                    catch { }


                    this.PopupFileLoad.IsOpen = false;
                    this.TextBlockStatusFile5.Text = "Загружены данные из файла: " + file3.Name;
                    
                }
            }
            else
            {
                PopupFileLoad.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                this.TextBlockStatusFile5.Text = "Операция загрузки данных прервана.";
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

                    string text1 = await Windows.Storage.FileIO.ReadTextAsync(Myfile5);
                    string text02 = text1.Replace("\r\n", " ");
                    string text002 = text02.Replace("\n", " ");
                    string text2 = text002.Replace("\r", " ");
                    FileTextBlock.Text = text2;
                    await FileIO.WriteTextAsync(Myfile5, text2);

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
                }

            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция загрузки реквизитов прервана.";
            }
        }


        private void ButtonTovar1RaschetStoimost5_Click(object sender, RoutedEventArgs e)
        {

            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar1Kolvo5.Text) || !float.TryParse(TextBoxTovar1Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar1CenaEd5.Text) || !float.TryParse(TextBoxTovar1CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar1Kolvo5.Text) * float.Parse(TextBoxTovar1CenaEd5.Text);
            TextBoxTovar1Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar2RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar2Kolvo5.Text) || !float.TryParse(TextBoxTovar2Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar2CenaEd5.Text) || !float.TryParse(TextBoxTovar2CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar2Kolvo5.Text) * float.Parse(TextBoxTovar2CenaEd5.Text);
            TextBoxTovar2Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar3RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar3Kolvo5.Text) || !float.TryParse(TextBoxTovar3Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar3CenaEd5.Text) || !float.TryParse(TextBoxTovar3CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar3Kolvo5.Text) * float.Parse(TextBoxTovar3CenaEd5.Text);
            TextBoxTovar3Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar4RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar4Kolvo5.Text) || !float.TryParse(TextBoxTovar4Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar4CenaEd5.Text) || !float.TryParse(TextBoxTovar4CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar4Kolvo5.Text) * float.Parse(TextBoxTovar4CenaEd5.Text);
            TextBoxTovar4Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar5RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar5Kolvo5.Text) || !float.TryParse(TextBoxTovar5Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar5CenaEd5.Text) || !float.TryParse(TextBoxTovar5CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar5Kolvo5.Text) * float.Parse(TextBoxTovar5CenaEd5.Text);
            TextBoxTovar5Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar6RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar6Kolvo5.Text) || !float.TryParse(TextBoxTovar6Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar6CenaEd5.Text) || !float.TryParse(TextBoxTovar6CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar6Kolvo5.Text) * float.Parse(TextBoxTovar6CenaEd5.Text);
            TextBoxTovar6Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar7RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar7Kolvo5.Text) || !float.TryParse(TextBoxTovar7Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar7CenaEd5.Text) || !float.TryParse(TextBoxTovar7CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar7Kolvo5.Text) * float.Parse(TextBoxTovar7CenaEd5.Text);
            TextBoxTovar7Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar8RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar8Kolvo5.Text) || !float.TryParse(TextBoxTovar8Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar8CenaEd5.Text) || !float.TryParse(TextBoxTovar8CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar8Kolvo5.Text) * float.Parse(TextBoxTovar8CenaEd5.Text);
            TextBoxTovar8Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar9RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar9Kolvo5.Text) || !float.TryParse(TextBoxTovar9Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar9CenaEd5.Text) || !float.TryParse(TextBoxTovar9CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar9Kolvo5.Text) * float.Parse(TextBoxTovar9CenaEd5.Text);
            TextBoxTovar9Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar10RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar10Kolvo5.Text) || !float.TryParse(TextBoxTovar10Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar10CenaEd5.Text) || !float.TryParse(TextBoxTovar10CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar10Kolvo5.Text) * float.Parse(TextBoxTovar10CenaEd5.Text);
            TextBoxTovar10Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar11RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar11Kolvo5.Text) || !float.TryParse(TextBoxTovar11Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar11CenaEd5.Text) || !float.TryParse(TextBoxTovar11CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar11Kolvo5.Text) * float.Parse(TextBoxTovar11CenaEd5.Text);
            TextBoxTovar11Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar12RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar12Kolvo5.Text) || !float.TryParse(TextBoxTovar12Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar12CenaEd5.Text) || !float.TryParse(TextBoxTovar12CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar12Kolvo5.Text) * float.Parse(TextBoxTovar12CenaEd5.Text);
            TextBoxTovar12Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar13RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar13Kolvo5.Text) || !float.TryParse(TextBoxTovar13Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar13CenaEd5.Text) || !float.TryParse(TextBoxTovar13CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar13Kolvo5.Text) * float.Parse(TextBoxTovar13CenaEd5.Text);
            TextBoxTovar13Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar14RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar14Kolvo5.Text) || !float.TryParse(TextBoxTovar14Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar14CenaEd5.Text) || !float.TryParse(TextBoxTovar14CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar14Kolvo5.Text) * float.Parse(TextBoxTovar14CenaEd5.Text);
            TextBoxTovar14Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar15RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar15Kolvo5.Text) || !float.TryParse(TextBoxTovar15Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar15CenaEd5.Text) || !float.TryParse(TextBoxTovar15CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar15Kolvo5.Text) * float.Parse(TextBoxTovar15CenaEd5.Text);
            TextBoxTovar15Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar16RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar16Kolvo5.Text) || !float.TryParse(TextBoxTovar16Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar16CenaEd5.Text) || !float.TryParse(TextBoxTovar16CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar16Kolvo5.Text) * float.Parse(TextBoxTovar16CenaEd5.Text);
            TextBoxTovar16Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar17RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar17Kolvo5.Text) || !float.TryParse(TextBoxTovar17Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar17CenaEd5.Text) || !float.TryParse(TextBoxTovar17CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar17Kolvo5.Text) * float.Parse(TextBoxTovar17CenaEd5.Text);
            TextBoxTovar17Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar18RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar18Kolvo5.Text) || !float.TryParse(TextBoxTovar18Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar18CenaEd5.Text) || !float.TryParse(TextBoxTovar18CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar18Kolvo5.Text) * float.Parse(TextBoxTovar18CenaEd5.Text);
            TextBoxTovar18Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar19RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar19Kolvo5.Text) || !float.TryParse(TextBoxTovar19Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar19CenaEd5.Text) || !float.TryParse(TextBoxTovar19CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar19Kolvo5.Text) * float.Parse(TextBoxTovar19CenaEd5.Text);
            TextBoxTovar19Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar20RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar20Kolvo5.Text) || !float.TryParse(TextBoxTovar20Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar20CenaEd5.Text) || !float.TryParse(TextBoxTovar20CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar20Kolvo5.Text) * float.Parse(TextBoxTovar20CenaEd5.Text);
            TextBoxTovar20Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar21RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar21Kolvo5.Text) || !float.TryParse(TextBoxTovar21Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar21CenaEd5.Text) || !float.TryParse(TextBoxTovar21CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar21Kolvo5.Text) * float.Parse(TextBoxTovar21CenaEd5.Text);
            TextBoxTovar21Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar22RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar22Kolvo5.Text) || !float.TryParse(TextBoxTovar22Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar22CenaEd5.Text) || !float.TryParse(TextBoxTovar22CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar22Kolvo5.Text) * float.Parse(TextBoxTovar22CenaEd5.Text);
            TextBoxTovar22Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar23RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar23Kolvo5.Text) || !float.TryParse(TextBoxTovar23Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar23CenaEd5.Text) || !float.TryParse(TextBoxTovar23CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar23Kolvo5.Text) * float.Parse(TextBoxTovar23CenaEd5.Text);
            TextBoxTovar23Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar24RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar24Kolvo5.Text) || !float.TryParse(TextBoxTovar24Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar24CenaEd5.Text) || !float.TryParse(TextBoxTovar24CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar24Kolvo5.Text) * float.Parse(TextBoxTovar24CenaEd5.Text);
            TextBoxTovar24Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar25RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar25Kolvo5.Text) || !float.TryParse(TextBoxTovar25Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar25CenaEd5.Text) || !float.TryParse(TextBoxTovar25CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar25Kolvo5.Text) * float.Parse(TextBoxTovar25CenaEd5.Text);
            TextBoxTovar25Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar26RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar26Kolvo5.Text) || !float.TryParse(TextBoxTovar26Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar26CenaEd5.Text) || !float.TryParse(TextBoxTovar26CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar26Kolvo5.Text) * float.Parse(TextBoxTovar26CenaEd5.Text);
            TextBoxTovar26Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar27RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar27Kolvo5.Text) || !float.TryParse(TextBoxTovar27Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar27CenaEd5.Text) || !float.TryParse(TextBoxTovar27CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar27Kolvo5.Text) * float.Parse(TextBoxTovar27CenaEd5.Text);
            TextBoxTovar27Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar28RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar28Kolvo5.Text) || !float.TryParse(TextBoxTovar28Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar28CenaEd5.Text) || !float.TryParse(TextBoxTovar28CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar28Kolvo5.Text) * float.Parse(TextBoxTovar28CenaEd5.Text);
            TextBoxTovar28Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar29RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar29Kolvo5.Text) || !float.TryParse(TextBoxTovar29Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar29CenaEd5.Text) || !float.TryParse(TextBoxTovar29CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar29Kolvo5.Text) * float.Parse(TextBoxTovar29CenaEd5.Text);
            TextBoxTovar29Stoimost5.Text = Result.ToString();
        }

        private void ButtonTovar30RaschetStoimosti5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar30Kolvo5.Text) || !float.TryParse(TextBoxTovar30Kolvo5.Text, out Result) || String.IsNullOrEmpty(TextBoxTovar30CenaEd5.Text) || !float.TryParse(TextBoxTovar30CenaEd5.Text, out Result))
            {
                return;
            }
            Result = float.Parse(TextBoxTovar30Kolvo5.Text) * float.Parse(TextBoxTovar30CenaEd5.Text);
            TextBoxTovar30Stoimost5.Text = Result.ToString();
        }



        private void ButtonItogoSummaRaschet5_Click(object sender, RoutedEventArgs e)
        {
            float Result;

            if (String.IsNullOrEmpty(TextBoxTovar1Stoimost5.Text)) { TextBoxTovar1Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar2Stoimost5.Text)) { TextBoxTovar2Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar3Stoimost5.Text)) { TextBoxTovar3Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar4Stoimost5.Text)) { TextBoxTovar4Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar5Stoimost5.Text)) { TextBoxTovar5Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar6Stoimost5.Text)) { TextBoxTovar6Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar7Stoimost5.Text)) { TextBoxTovar7Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar8Stoimost5.Text)) { TextBoxTovar8Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar9Stoimost5.Text)) { TextBoxTovar9Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar10Stoimost5.Text)) { TextBoxTovar10Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar11Stoimost5.Text)) { TextBoxTovar11Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar12Stoimost5.Text)) { TextBoxTovar12Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar13Stoimost5.Text)) { TextBoxTovar13Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar14Stoimost5.Text)) { TextBoxTovar14Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar15Stoimost5.Text)) { TextBoxTovar15Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar16Stoimost5.Text)) { TextBoxTovar16Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar17Stoimost5.Text)) { TextBoxTovar17Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar18Stoimost5.Text)) { TextBoxTovar18Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar19Stoimost5.Text)) { TextBoxTovar19Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar20Stoimost5.Text)) { TextBoxTovar20Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar21Stoimost5.Text)) { TextBoxTovar21Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar22Stoimost5.Text)) { TextBoxTovar22Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar23Stoimost5.Text)) { TextBoxTovar23Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar24Stoimost5.Text)) { TextBoxTovar24Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar25Stoimost5.Text)) { TextBoxTovar25Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar26Stoimost5.Text)) { TextBoxTovar26Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar27Stoimost5.Text)) { TextBoxTovar27Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar28Stoimost5.Text)) { TextBoxTovar28Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar29Stoimost5.Text)) { TextBoxTovar29Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar30Stoimost5.Text)) { TextBoxTovar30Stoimost5.Text = "0"; }

            if (!float.TryParse(TextBoxTovar1Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar2Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar3Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar4Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar5Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar6Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar7Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar8Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar9Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar10Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar11Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar12Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar13Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar14Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar15Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar16Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar17Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar18Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar19Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar20Stoimost5.Text, out Result)
                 || !float.TryParse(TextBoxTovar21Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar22Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar23Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar24Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar25Stoimost5.Text, out Result)
                 || !float.TryParse(TextBoxTovar26Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar27Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar28Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar29Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar30Stoimost5.Text, out Result))
           
            {
                return;
            }
            Result = float.Parse(TextBoxTovar1Stoimost5.Text) + float.Parse(TextBoxTovar2Stoimost5.Text) + float.Parse(TextBoxTovar3Stoimost5.Text) + float.Parse(TextBoxTovar4Stoimost5.Text) + float.Parse(TextBoxTovar5Stoimost5.Text) + float.Parse(TextBoxTovar6Stoimost5.Text) + float.Parse(TextBoxTovar7Stoimost5.Text) + float.Parse(TextBoxTovar8Stoimost5.Text) + float.Parse(TextBoxTovar9Stoimost5.Text) + float.Parse(TextBoxTovar10Stoimost5.Text) + float.Parse(TextBoxTovar11Stoimost5.Text) + float.Parse(TextBoxTovar12Stoimost5.Text) + float.Parse(TextBoxTovar13Stoimost5.Text) + float.Parse(TextBoxTovar14Stoimost5.Text) + float.Parse(TextBoxTovar15Stoimost5.Text) + float.Parse(TextBoxTovar16Stoimost5.Text) + float.Parse(TextBoxTovar17Stoimost5.Text) + float.Parse(TextBoxTovar18Stoimost5.Text) + float.Parse(TextBoxTovar19Stoimost5.Text) + float.Parse(TextBoxTovar20Stoimost5.Text)
                 + float.Parse(TextBoxTovar21Stoimost5.Text) + float.Parse(TextBoxTovar22Stoimost5.Text) + float.Parse(TextBoxTovar23Stoimost5.Text) + float.Parse(TextBoxTovar24Stoimost5.Text) + float.Parse(TextBoxTovar25Stoimost5.Text)
                 + float.Parse(TextBoxTovar26Stoimost5.Text) + float.Parse(TextBoxTovar27Stoimost5.Text) + float.Parse(TextBoxTovar28Stoimost5.Text) + float.Parse(TextBoxTovar29Stoimost5.Text) + float.Parse(TextBoxTovar30Stoimost5.Text);
            TextBoxItogo5.Text = Result.ToString();
        }



        private async void SaveSmeta5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новая смета";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">СМЕТА (ПРЕДЛОЖЕНИЕ) № СМ-" + TextBoxNomerDogovora5.Text + " на поставку товаров и оказание услуг по " + TextBoxUslugiPo5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">для " + TextBoxSokrNameKontr5.Text + " от " + TextBoxDataSmeti5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataAkta5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Потенциальный Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", предлагает " + TextBoxSokrNameKontr5.Text + ", свои товары и услуги:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость товаров, работ и услуг: " + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + "), без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Настоящее предложение действительно до " + TextBoxDataDejstvijaSmeti5.Text + ".</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");


                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ПОТЕНЦИАЛЬНЫЙ ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxMojFIORuk5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataSmeti5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataSmeti5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");


                ProgressRing1.IsActive = false;
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл сметы " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл сметы " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла сметы была прервана.";
            }
        }



        private async void SaveSmetaP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новая смета";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">СМЕТА (ПРЕДЛОЖЕНИЕ) № СМ-" + TextBoxNomerDogovora5.Text + " на поставку товаров и оказание услуг по " + TextBoxUslugiPo5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">для " + TextBoxSokrNameKontr5.Text + " от " + TextBoxDataSmeti5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataAkta5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Потенциальный Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", предлагает " + TextBoxSokrNameKontr5.Text + ", свои товары и услуги:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость товаров, работ и услуг: " + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + "), без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Настоящее предложение действительно до " + TextBoxDataDejstvijaSmeti5.Text + ".</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");


                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ПОТЕНЦИАЛЬНЫЙ ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"P550\"><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\" >" + " / " + TextBoxMojFIORuk5.Text + "</p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataSmeti5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataSmeti5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");


                ProgressRing1.IsActive = false;
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл сметы " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл сметы " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла сметы была прервана.";
            }
        }



        private async void SaveDogovorP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker2 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker2.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker2.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker2.SuggestedFileName = "Новый договор";
            //
            Windows.Storage.StorageFile Myfile2 = await savePicker2.PickSaveFileAsync();
            if (Myfile2 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile2);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                ///начало файла договора
                await FileIO.WriteTextAsync(Myfile2, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile2, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile2, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile2, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<style type=\"text/css\">");
                await FileIO.AppendTextAsync(Myfile2, "@page {} table {border-collapse: collapse;border-spacing: 0;empty-cells: show;} td, th {vertical-align: top;font-size: 12pt;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, "h1, h2, h3, h4, h5, h6 {clear: both;} * {margin: 0;} .P10 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: left !important;color: #000000;font-weight: bold;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P13 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: center !important;color: #000000;font-weight: bold;} .P25 {font-size: 5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;color: #000000;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".P54 {font-size: 9.5pt;line-height: 100%;margin-left: 0.762cm;margin-right: 0cm;text-align: center !important;text-indent: 0cm;font-family: Tahoma;writing-mode: page;}\r\n");
                await FileIO.AppendTextAsync(Myfile2, ".T5 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;} .T7 {color: #000000;font-family: Tahoma;font-size: 6.5pt;font-weight: bold;background-color: transparent;}</style></head>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "</head><body style=\"width: 19cm; \"> \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка договора
                    await FileIO.AppendTextAsync(Myfile2, "<table width=\"100% \"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile2, "</p></td><td style=\"text-align:right; \"><p class=\"P250\" align=\"right\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P250\" align=\"right\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P250\" align=\"right\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки договора
                }
                await FileIO.AppendTextAsync(Myfile2, "<h1 class=\"P54\">ДОГОВОР № " + TextBoxNomerDogovora5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">на оказание услуг по " + TextBoxUslugiPo5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">" + TextBoxMoeNaimenovaniePolnoe5.Text + ", именуемый(ое) в дальнейшем <span class=\"T5\">Исполнитель</span>, в лице " + TextBoxMojVlice5.Text + ", с одной стороны и " + TextBoxFullNameKontr5.Text + ", в лице " + TextBoxVlice5.Text + ", именуемый(ое) в дальнейшем <span class=\"T5\">Заказчик</span>, с другой стороны, вместе именуемые в дальнейшем «Стороны» и по отдельности «Сторона», заключили настоящий договор, в дальнейшем Договор, о нижеследующем:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">1. ПРЕДМЕТ ДОГОВОРА</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">1.1 В соответствии с условиями настоящего Договора <span class=\"T6\">Исполнитель</span> обязуется поставить товары и оказать услуги, а <span class=\"T6\">Заказчик</span> принять и оплатить товары и услуги по " + TextBoxUslugiPo5.Text + " в соответствии с Перечнем товаров и оказываемых услуг.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">2. СТОИМОСТЬ И ПОРЯДОК РАСЧЕТОВ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.1 Стоимость товаров и услуг по " + TextBoxUslugiPo5.Text + " составляет <span class=\"T7\">" + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + "), без НДС (Исполнитель применяет УСН)</span></p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.2 Услуги по " + TextBoxUslugiPo5.Text + " оказываются, товары по настоящему Договору поставляются " + TextBoxSrokiIspolnenija5.Text + ".</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">2.3 Оплата за товары и услуги по " + TextBoxUslugiPo5.Text + " производится " + TextBoxUslovijaOplati5.Text + ".</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P25\"> </p><p class=\"P13\">3. ПЕРЕЧЕНЬ ТОВАРОВ И ОКАЗЫВАЕМЫХ УСЛУГ</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }


                if (TextBoxTovar26Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile2, "</table><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">4. ГАРАНТИЙНЫЕ ОБЯЗАТЕЛЬСТВА</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">4.1 " + TextBoxGarantija5.Text + "</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">5. ОТВЕТСТВЕННОСТЬ СТОРОН</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.1 Исполнитель обязуется оказать услуги по " + TextBoxUslugiPo5.Text + " в соответствии с нормативно-технической документацией, установленной для данного вида работ (СНиП, ПУЭ, ППБ, ГОСТ).</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.2 Исполнитель обязуется оказать услуги лично или с помощью иных квалифицированных лиц, с использованием своих расходных материалов или материалов Заказчика, в зависимости от вида оказываемых услуг. Ответственность за оказанные услуги, осуществленные с привлечением третьих лиц, несет Исполнитель.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.3 Исполнитель обязуется по окончании оказания услуг по " + TextBoxUslugiPo5.Text + " подписать с Заказчиком <span class=\"T5\">Акт об оказанных услугах по " + TextBoxUslugiPo5.Text + "</span>.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.4 Исполнитель обязан до заключения настоящего договора предоставить Заказчику необходимую и достоверную информацию об оказываемых услугах, видах и об особенностях, о цене и форме оплаты, а также сообщить Заказчику по его просьбе другие относящиеся к договору и соответствующим услугам сведения.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.5 Заказчик обязан по окончании оказания услуг по " + TextBoxUslugiPo5.Text + " подписать с Исполнителем <span class=\"T5\">Акт об оказанных услугах  по " + TextBoxUslugiPo5.Text + ".</span></p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.6 Заказчик обязан оплатить товары и услуги Исполнителю в соответствии с условиями п. 2.1, 2.3 настоящего Договора.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.7 Заказчик обязуется обеспечить Исполнителю доступ к месту проведения работ.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.8 Заказчик вправе в любое время проверять ход и качество оказываемых услуг Исполнителем, не вмешиваясь при этом в его деятельность.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">5.9 Заказчик вправе в любое время до завершения оказания услуг отказаться от исполнения договора, уплатив Исполнителю часть установленной цены пропорционально части услуг, оказанных до уведомления об отказе от исполнения договора, и возместив Исполнителю расходы, произведенные до этого момента в целях исполнения договора, если они не входят в указанную часть цены оказанных услуг.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">6. ФОРС-МАЖОР</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.1 В случае пожара; наводнения; землетрясения; стихийных бедствий; аварий на транспорте; мятежей; гражданских беспорядков; забастовок; войны и военных действий; публикаций нормативных актов запрещающего характера; действий (бездействий) сотрудников государственных органов, препятствующих выполнению Сторонами взятых на себя обязательств; а также других чрезвычайных обстоятельств непреодолимой силы, возникших после подписания настоящего Договора, которые Стороны не могли предвидеть или предотвратить, срок исполнения обязательств по Договору отодвигается соразмерно времени, в течение которого будут действовать эти обстоятельства, но не более чем на 3 (три) месяца.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.2 Указанные обстоятельства должны носить чрезвычайный, непредвиденный и непредотвратимый характер и возникнуть после заключения Договора.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.3 Если действие обстоятельств непреодолимой силы продлится более 6 (шести) месяцев, любая из Сторон вправе расторгнуть Договор в одностороннем порядке, направив другой Стороне соответствующее уведомление.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.4 Сторона, для которой создалась невозможность выполнения обязательства по Договору, должна немедленно, но в любом случае не позднее 3 (трех) дней с момента, когда Стороне стало известно о наступлении обстоятельств непреодолимой силы известить другую Сторону о наступлении обстоятельств непреодолимой силы, препятствующих выполнению обязательств. Такое уведомление должно содержать данные о характере обстоятельств и их оценку, чтобы определить возможные потери и время, необходимое для их устранения.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.5 Возникновение и (или) существование обстоятельств непреодолимой силы должно быть подтверждено документами, выданными компетентными органами.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.6 В случае возникновения обстоятельств непреодолимой силы Стороны обязуются консультироваться друг с другом относительно дальнейшего выполнения действий по Договору и прилагать все усилия к скорейшему исполнению своих обязательств.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.7 После прекращения обстоятельств непреодолимой силы Сторона, ссылавшаяся на такие обстоятельства, должна немедленно, но в любом случае не позднее 3 (трех) дней после прекращения действия обстоятельств непреодолимой силы, известить другую Сторону об этом и исполнить соответствующие обязательства по Договору. Сторона, не известившая или несвоевременно известившая другую Сторону о прекращении обстоятельств непреодолимой силы, обязана возместить другой Стороне все убытки, связанные с таким не извещением или несвоевременным извещением.</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P31\">6.8 Обязанность доказывания наличия обстоятельств непреодолимой силы возлагается на заявившую об этом Сторону.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">7.  ОСОБЫЕ УСЛОВИЯ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">" + TextBoxOsobieUslovijaDogovora5.Text + "<p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">8.  ПОРЯДОК РАЗРЕШЕНИЯ СПОРОВ</p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">Все споры, вытекающие  из условий настоящего  Договора, Стороны будут стремиться  разрешать путем переговоров. При этом заинтересованная сторона направляет другой Стороне письменную претензию.  Ответ на претензию должен быть направлен не позднее 10 дней с момента её получения. Если Стороны в ходе переговоров не смогут достичь соглашения, то спор подлежит рассмотрению в суде. Место рассмотрения спора " + TextBoxSud5.Text + ".</p><p class=\"P50\">Настоящий Договор составлен в двух одинаковых экземплярах, имеющих равную юридическую силу, по одному экземпляру для каждой из Сторон.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P50\">Стороны договорились о том, что факсимильные и электронные копии договоров и иных документов, отправленные посредством электронной почты со стороны Исполнителя Заказчику и со стороны Заказчика Исполнителю имеют силу оригинала.</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<p class=\"P13\">9.  АДРЕСА МЕСТОНАХОЖДЕНИЯ, БАНКОВСКИЕ РЕКВИЗИТЫ И ПОДПИСИ СТОРОН</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");
                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile2, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"P550\"><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\" >" + " / " + TextBoxMojFIORuk5.Text + "</p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataDogovora5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile2, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataDogovora5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile2, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile2, "\r\n");

                ProgressRing1.IsActive = false;
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile2);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл договора " + Myfile2.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл договора" + Myfile2.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция сохранения файла договора была прервана.";
            }
        }

        private async void SaveSchetP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker1 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker1.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker1.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker1.SuggestedFileName = "Новый счет";
            //
            Windows.Storage.StorageFile Myfile1 = await savePicker1.PickSaveFileAsync();
            if (Myfile1 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
                // Prevent updates to the remote version of the file until
                // we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.DeferUpdates(Myfile1);
                // write to file
                //await Windows.Storage.FileIO.WriteTextAsync(file, file.Name); //запись в файл имени

                ///Вывод файла счета
                await FileIO.WriteTextAsync(Myfile1, "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN \" > \r\n");
                await FileIO.AppendTextAsync(Myfile1, "<?xml version= \" 1.0 \" encoding=\"UTF-8\" ?> \r\n ");
                await FileIO.AppendTextAsync(Myfile1, "<html><head> \r\n");
                await FileIO.AppendTextAsync(Myfile1, "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = UTF-8\">\r\n");
                await FileIO.AppendTextAsync(Myfile1, "<style type=\"text/css\"> \r\n");
                await FileIO.AppendTextAsync(Myfile1, "table { border-collapse:collapse; border-spacing:0; empty-cells:show } td, th { vertical - align:top; font - size:12pt;} h1, h2, h3, h4, h5, h6 { clear: both } ol, ul { margin: 0; padding: 0;} li { list - style: none; margin: 0; padding: 0;} li span. { clear: both; line - height:0; width: 0; height: 0; margin: 0; padding: 0;} span.footnodeNumber { padding - right:1em;} span.annotation_style_by_filter {font - size:95 %; font - family:Arial; background - color:#fff000;  margin:0; border:0; padding:0;} * { margin: 0;}  \r\n");
                await FileIO.AppendTextAsync(Myfile1, ".P1 {color:#00000a; font-size:14.5pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; font-weight:bold; } .P10 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; } .P101 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P11 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P12 {color:#00000a; font-size:9pt; line-height:140%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P13 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P14 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P15 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P16 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P17 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P18 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; font-weight:bold; }.P19 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; }.P2 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P20 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; font-weight:bold; }.P21 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0.353cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; margin-left:0cm; margin-right:0cm; text-indent:0cm; } /r/n .P22 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P23 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; }.P24 {color:#00000a; font-size:9pt; line-height:120%; margin-bottom:0cm; margin-top:0.529cm; text-align:right ! important; font-family:Tahoma; writing-mode:lr-tb; } .P24 span {vertical-align:middle;} .P24 img {vertical-align:middle;} .P25 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0.529cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P26 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P27 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P28 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P29 {color:#000000; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; font-style:normal; font-weight:normal; }.P3 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P30 {color:#00000a; font-size:8pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P31 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }");
                await FileIO.AppendTextAsync(Myfile1, ".P4 {color:#00000a; font-size:10pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P5 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:center ! important; font-family:Tahoma; writing-mode:lr-tb; }.P6 {color:#000000; font-size:8pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P7 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }.P8 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Tahoma; writing-mode:lr-tb; }.P9 {color:#00000a; font-size:9pt; line-height:100%; margin-bottom:0cm; margin-top:0cm; text-align:left ! important; font-family:Arial; writing-mode:lr-tb; }");
                await FileIO.AppendTextAsync(Myfile1, ".Standard {font - size:9pt; font - family:Arial; writing - mode:lr - tb; margin - top:0cm; margin - bottom:0cm; line - height:100 %; text - align:left !important; color:#00000a; }.Таблица1 { width: 18.706cm; margin - left:-0.191cm; margin - right:-1.515cm; margin - top:0cm; margin - bottom:0cm; float:none; writing - mode:lr - tb;}.Таблица2 { width: 18.694cm; margin - left:-0.191cm; margin - top:0cm; margin - bottom:0cm; writing - mode:lr - tb;}.Таблица3 { width: 18.694cm; margin - left:-0.191cm; margin - top:0cm; margin - bottom:0cm; writing - mode:lr - tb;}.Таблица1_A1 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-width:0.018cm; border-top-style:solid; border-top-color:#00000a; border-bottom-style:none; }.Таблица1_A3 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_E1 {vertical - align:middle; background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_F2 {background - color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-style:none; }.Таблица1_F4 {background-color:#ffffff; padding-left:0.173cm; padding-right:0.191cm; padding-top:0.101cm; padding-bottom:0.101cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-width:0.018cm; border-top-style:solid; border-top-color:#00000a; border-bottom-style:none; }.Таблица2_A1 {background - color:#ffffff; padding-left:0.191cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-style:none; }.Таблица3_A1 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }");
                await FileIO.AppendTextAsync(Myfile1, ".Таблица3_A4 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-width:0.018cm; border-bottom-style:solid; border-bottom-color:#00000a; }.Таблица3_B4 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-left-width:0.018cm; border-left-style:solid; border-left-color:#00000a; border-right-width:0.018cm; border-right-style:solid; border-right-color:#00000a; border-top-style:none; border-bottom-width:0.018cm; border-bottom-style:solid; border-bottom-color:#00000a; }.Таблица3_C3 {vertical - align:middle; background - color:#ffffff; padding-left:0.155cm; padding-right:0.191cm; padding-top:0cm; padding-bottom:0cm; border-width:0.018cm; border-style:solid; border-color:#00000a; }.Таблица1_A { width: 1.723cm; }.Таблица1_B { width: 6.145cm;}.Таблица1_C { width: 1.812cm;}.Таблица1_D { width: 1.194cm;}.Таблица1_E { width: 1.482cm;}.Таблица1_F { width: 6.352cm;}.Таблица2_A { width: 2.193cm;}.Таблица2_B { width: 16.501cm;}.Таблица3_A { width: 0.93cm;}.Таблица3_B { width: 9.745cm;}.Таблица3_C { width: 1.535cm;}.Таблица3_D { width: 1.334cm;}.Таблица3_E { width: 2.35cm;}.Таблица3_F { width: 2.801cm; }.Internet_20_link {color:#000080; text-decoration:underline; }.T1 { font - size:10pt;}.T13 {color:#000000; font-size:9pt; font-style:normal; font-weight:normal; }.T15 { font-size:14.5pt; font-weight:bold;}.T16 { font-size:14.5pt; font-weight:bold;}.T17 { font-family:Tahoma; font-size:10pt;}.T18 {font-family:Tahoma; font-size:10pt;}.T19 { font-family:Tahoma; font-weight:normal;}.T2 { font-size:10pt;}.T3 { font-size:10pt;}.T4 {font-size:10pt; text-decoration:none !important;}.T6 { font-size:9pt;}.T7 { font-size:9pt;}.Таблица1.1.Таблица2.1.Таблица2.2.Таблица3.1.Таблица3.2.Таблица3.5.T10.T11.T12.T14.T5.T8.T9 {} </style>");
                await FileIO.AppendTextAsync(Myfile1, "</head><body style = \"max-width: 19cm; \" > \r\n");

                if (CHeckBoxSchapka5.IsChecked == true)
                {
                    ///шапка счета
                    await FileIO.AppendTextAsync(Myfile1, "<table width=\"100%\"><tr><td><p align = \"left\"><img width=\"180px\" src = \"data:image/jpeg;base64," + TextBoxMojLogo5.Text + "\" >");
                    await FileIO.AppendTextAsync(Myfile1, "</p></td><td><p class=\"P101\">" + TextBoxMojSlogan5.Text + "</p><p class=\"P101\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P101\">Телефон: " + TextBoxMojPhone5.Text + "</p></td></tr></table><br><br> \r\n");
                    ///конец шапки счета
                }
                ///таблица образца платежного поручения 
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P6\">Образец заполнения платежного поручения</p><p class=\"P26\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse:collapse\" class=\"Таблица1\"><colgroup><col width=\"75\"/><col width=\"269\"/><col width=\"79\"/><col width=\"52\"/><col width=\"65\"/><col width=\"278\"/></colgroup><tr class=\"Таблица11\"><td colspan=\"4\" rowspan=\"2\" style=\"text-align:left; width: 1.723cm;\" class=\"Таблица1_A1\"><p class=\"P7\"><span class=\"T14\">" + TextBoxMoiBankName5.Text + "</span></p></td><td style=\"text - align:left; width: 1.482cm;\" class=\"Таблица1_E1\"><p class=\"P7\">БИК</p></td><td style=\"text - align:left; width: 6.352cm; \" class=\"Таблица1_A1\"><p class=\"P28\">" + TextBoxMoiBankBIK5.Text + "</p></td></tr><tr class=\"Таблица11\"><td style=\"text-align:left; width: 1.482cm;\" class=\"Таблица1_A1\"><p class=\"P7\">Сч. №</p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_F2\"><p class=\"P29\">" + TextBoxMoiBankKorr5.Text + "</p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A3\"><p class=\"P30\">Банк получателя</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A3\"><p class=\"P9\"></p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_A3\"><p class=\"P9\"></p></td></tr><tr class=\"Таблица11\"><td style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_E1\"><p class=\"P7\">ИНН</p></td><td style=\"text-align:left; width: 6.145cm; \" class=\"Таблица1_A3\"><p class=\"P7\">" + TextBoxMojINN5.Text + "</p></td><td style=\"text-align:left; width: 1.812cm; \" class=\"Таблица1_E1\"><p class=\"P7\">КПП</p></td><td style=\"text-align:left; width: 1.194cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A1\">");
                ///конец таблицы образца платежного поручения

                /// секция реквизитов Продавца и Покупателя
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P7\">Сч. №</p></td><td style=\"text - align:right; width: 6.352cm; \" class=\"Таблица1_F4\"><p class=\"P31\">" + TextBoxMoiRaschetnijSchet5.Text + "</p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A1\"><p class=\"P7\">" + TextBoxMoeNaimenovaniePolnoe5.Text + "</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_F2\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_F2\"><p class=\"P9\"> </p></td></tr><tr class=\"Таблица11\"><td colspan=\"4\" style=\"text-align:left; width: 1.723cm; \" class=\"Таблица1_A3\"><p class=\"P30\">Получатель</p></td><td style=\"text-align:left; width: 1.482cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td><td style=\"text-align:left; width: 6.352cm; \" class=\"Таблица1_A3\"><p class=\"P9\"> </p></td></tr></table><br><p class=\"P5\"><span class=\"T16\">Счет на оплату № C-" + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "<br><br>к договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</span></p><br>");
                await FileIO.AppendTextAsync(Myfile1, "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"Таблица2\"><colgroup><col width=\"96\"/><col width=\"721\"/></colgroup><tr class=\"Таблица21\"><td style=\"text-align:left;width:2.193cm; \" class=\"Таблица2_A1\"><p class=\"P15\">Поставщик:</p></td><td style=\"text-align:left;width:16.501cm; \" class=\"Таблица2_A1\">");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P18\">" + TextBoxMoeNaimenovaniePolnoe5.Text + "</p><p class=\"P15\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P15\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P15\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P15\">ИНН " + TextBoxMojINN5.Text + "</p><p class=\"P15\">Р/cчет " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + "</p><p class=\"P15\">БИК " + TextBoxMoiBankBIK5.Text + " корр.счет " + TextBoxMoiBankKorr5.Text + "</p>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P15\">Тел.: " + TextBoxMojPhone5.Text + "</p>" + "<p class=\"P15\">Моб.: " + TextBoxMojMobile5.Text + "</p><p class=\"P15\">Эл.почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P15\"><span class=\"T19\">Сайт: " + TextBoxMojSait5.Text + "</span></p><br>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P8\"></p></td></tr><tr class=\"Таблица22\"><td style=\"text-align:left; width: 2.193cm; \" class=\"Таблица2_A1\"><p class=\"P15\">Покупатель:</p></td><td style=\"text-align:left;width:16.501cm; \" class=\"Таблица2_A1\">");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P18\">" + TextBoxFullNameKontr5.Text + "</p><p class=\"P15\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P15\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P15\">ИНН " + TextBoxINN5.Text + " КПП " + TextBoxKPP5.Text + " ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P15\">" + TextBoxBankRekv5.Text + "</p><p class=\"P15\">Тел: " + TextBoxPhone5.Text + "</p><p class=\"P15\">Моб.: " + TextBoxMobile5.Text + "</p><p class=\"P15\">Эл.почта: " + TextBoxEmail5.Text + "</p><p class=\"P15\">Сайт: " + TextBoxSajt5.Text + "</p></td></tr></table><br>");
                ///конец секции реквизитов Продавца и Покупателя

                ///таблица товаров и услуг
                await FileIO.AppendTextAsync(Myfile1, "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"Таблица3\"><colgroup><col width=\"41\"/><col width=\"426\"/><col width=\"67\"/><col width=\"58\"/><col width=\"103\"/><col width=\"122\"/></colgroup>");
                await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">№</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Товары(работы, услуги)</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Кол-во</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Ед.</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Цена</p></td>");
                await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">Сумма</p></td></tr>");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar2Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>");
                }


                if (TextBoxTovar4Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar5Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar6Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar11Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>");
                }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar17Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar18Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar19Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar20Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar22Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar23Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar24Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar25Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar27Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar28Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar29Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>");
                }

                if (TextBoxTovar30Naimenovanie5.Text.Length != 0)
                {
                    Number = Number + 1;
                    await FileIO.AppendTextAsync(Myfile1, "<tr class=\"Таблица31\"><td style =\"text-align:left;width:0.93cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + Number + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:9.745cm; \" class=\"Таблица3_A1\"><p class=\"P12\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style=\"text-align:left;width:1.535cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Kolvo5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:1.334cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Ed5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style = \"text-align:left;width:2.35cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30CenaEd5.Text + "</p></td>");
                    await FileIO.AppendTextAsync(Myfile1, "<td style =\"text-align:left;width:2.801cm; \" class=\"Таблица3_A1\"><p class=\"P16\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>");
                }


                await FileIO.AppendTextAsync(Myfile1, "</table><br><p class=\"P18\">Всего к оплате: " + TextBoxItogo5.Text + " рублей (" + TextBoxItogoPropis5.Text + ").</p>");
                await FileIO.AppendTextAsync(Myfile1, "<p class=\"P24\"><span><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\"></span><span class=\"T3\"> / " + TextBoxMojaRukDolzhnost5.Text + " " + TextBoxMojFIORuk5.Text + "</span></p></body></html>");
                await FileIO.AppendTextAsync(Myfile1, "</body></html>");
                await FileIO.AppendTextAsync(Myfile1, "");

                ProgressRing1.IsActive = false;
                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile1);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл счета " + Myfile1.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл счета " + Myfile1.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция сохранения файла счёта была прервана.";
            }
        }

        private async void SaveAktP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новый акт";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">АКТ № А-" + TextBoxNomerDogovora5.Text + " об оказанных услугах по " + TextBoxUslugiPo5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataAkta5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Исполнитель " + TextBoxMoeNaimenovaniePolnoe5.Text + ", в лице " + TextBoxMojVlice5.Text + ", с одной стороны и Заказчик " + TextBoxFullNameKontr5.Text + ", в лице " + TextBoxVlice5.Text + ", с другой стороны, составили настоящий Акт о нижеследующем:</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров и услуг</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0 & CheckBoxTovar1.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0 & CheckBoxTovar2.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0 & CheckBoxTovar3.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0 & CheckBoxTovar4.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0 & CheckBoxTovar5.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0 & CheckBoxTovar6.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0 & CheckBoxTovar7.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0 & CheckBoxTovar8.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0 & CheckBoxTovar9.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0 & CheckBoxTovar10.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0 & CheckBoxTovar11.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0 & CheckBoxTovar12.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0 & CheckBoxTovar13.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0 & CheckBoxTovar14.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0 & CheckBoxTovar15.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0 & CheckBoxTovar16.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0 & CheckBoxTovar17.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0 & CheckBoxTovar18.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0 & CheckBoxTovar19.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0 & CheckBoxTovar20.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0 & CheckBoxTovar21.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0 & CheckBoxTovar22.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0 & CheckBoxTovar23.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0 & CheckBoxTovar24.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0 & CheckBoxTovar25.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0 & CheckBoxTovar26.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0 & CheckBoxTovar27.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0 & CheckBoxTovar28.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0 & CheckBoxTovar29.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0 & CheckBoxTovar30.IsChecked == false) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость оказанных услуг: " + TextBoxItogoSummaPoAktu5.Text + " рублей, без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Перечисленные выше услуги со стороны Исполнителя Заказчику в полном объеме и в оговоренные Сторонами сроки оказаны.</p><p class=\"P25\"> </p><p class=\"P113\">ЗАКАЗЧИК К ИСПОЛНИТЕЛЮ ПРЕТЕНЗИЙ НЕ ИМЕЕТ.</p>");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"P550\"><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\" >" + " / " + TextBoxMojFIORuk5.Text + "</p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataAkta5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataAkta5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");

                ProgressRing1.IsActive = false;

                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл акта " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл акта " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла акта была прервана.";
            }
        }

        private async void SaveNakladnaja5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новая накладная";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">ТОВАРНАЯ НАКЛАДНАЯ № Н-" + TextBoxNomerDogovora5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataNakladnoj5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0 & CheckBoxTovar1.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0 & CheckBoxTovar2.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0 & CheckBoxTovar3.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0 & CheckBoxTovar4.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0 & CheckBoxTovar5.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0 & CheckBoxTovar6.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0 & CheckBoxTovar7.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0 & CheckBoxTovar8.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0 & CheckBoxTovar9.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0 & CheckBoxTovar10.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0 & CheckBoxTovar11.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0 & CheckBoxTovar12.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0 & CheckBoxTovar13.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0 & CheckBoxTovar14.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0 & CheckBoxTovar15.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0 & CheckBoxTovar16.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0 & CheckBoxTovar17.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0 & CheckBoxTovar18.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0 & CheckBoxTovar19.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0 & CheckBoxTovar20.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0 & CheckBoxTovar21.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0 & CheckBoxTovar22.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0 & CheckBoxTovar23.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0 & CheckBoxTovar24.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0 & CheckBoxTovar25.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0 & CheckBoxTovar26.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0 & CheckBoxTovar27.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0 & CheckBoxTovar28.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0 & CheckBoxTovar29.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0 & CheckBoxTovar30.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Товарная накладная содержит " + TextBoxItogoNomerovPoNakladnoj5.Text + " порядковых номеров записей</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость отгруженных товаров: " + TextBoxItogoSummaPoNakladnoj5.Text + " рублей, без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">ГРУЗ ПРИНЯЛ___________________________________________________________________________ПО ДОВЕРЕННОСТИ №____________________ОТ______________________</p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(должность, ФИО)</p><p class=\"P25\"> </p>");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Перечисленные выше товары со стороны Исполнителя Заказчику в полном объеме и в оговоренные Сторонами сроки были переданы.</p><p class=\"P25\"> </p><p class=\"P113\">ЗАКАЗЧИК К ИСПОЛНИТЕЛЮ ПРЕТЕНЗИЙ НЕ ИМЕЕТ.</p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxMojFIORuk5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataNakladnoj5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataNakladnoj5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");

                ProgressRing1.IsActive = false;

                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл товарной накладной " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл товарной накладной " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла товарной накладной была прервана.";
            }
        }

        private async void SaveNakladnajaP5_Click(object sender, RoutedEventArgs e)
        {
            var savePicker3 = new Windows.Storage.Pickers.FileSavePicker();
            savePicker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Поле выбора типа файла в диалоге
            savePicker3.FileTypeChoices.Add("Документ", new List<string>() { ".html" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker3.SuggestedFileName = "Новая накладная";
            //
            Windows.Storage.StorageFile Myfile3 = await savePicker3.PickSaveFileAsync();
            if (Myfile3 != null)
            {
                ProgressRing1.IsActive = true;
                int Number = 0;
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
                await FileIO.AppendTextAsync(Myfile3, ".P31 {font-size: 6.5pt;font-family: Tahoma;writing-mode: page;text-align: justify !important;} .P50 {font-size: 6.5pt; text-align: justify !important;font-family: Tahoma; writing-mode: page;color: #000000;} .P150 {font-size: 6.5pt; text-align: center !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P250 {font-size: 6.5pt; text-align: right !important; font-family: Tahoma; writing-mode: page;color: #000000;} .P450 {font-size: 6.5pt; text-align: left !important; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 {font-size: 6.5pt; text-align: left !important; vertical-align:middle; font-family: Tahoma; writing-mode: page;color: #000000; margin-left:10px;} .P550 img {vertical-align:middle;} .P550 p {vertical-align:middle;}\r\n");
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
                await FileIO.AppendTextAsync(Myfile3, "<h1 class=\"P54\">ТОВАРНАЯ НАКЛАДНАЯ № Н-" + TextBoxNomerDogovora5.Text + "</h1><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:8.5pt; text-align:center; font-weight:bold; \">к Договору № " + TextBoxNomerDogovora5.Text + " от " + TextBoxDataDogovora5.Text + "</p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100 %\"><tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:left;\"><span class=\"T7\">" + TextBoxGorodZaklDogovora5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td style=\"text-align:right; \"><span class=\"T7\">" + TextBoxDataNakladnoj5.Text + "</span></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "</tr></table><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");
                /// КОНЕЦ [начало документа: заголовок, город, дата]
                await FileIO.AppendTextAsync(Myfile3, "<table width=\"100%\" border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100% \" style=\"border-color:#999999;\"><tr><td width=\"10px\"><p class=\"P150\">№</p></td><td width=\"10cm\"><p class=\"P150\">Наименование товаров</p></td><td width=\"30px\"><p class=\"P150\">Кол-во</p></td><td width=\"40px\"><p class=\"P150\">Ед.изм.</p></td><td width=\"50px\"><p class=\"P150\">Цена за ед.</p></td><td width=\"60px\"><p class=\"P150\">Стоимость</p></td></tr>\r\n");

                if (TextBoxTovar1Naimenovanie5.Text.Length != 0 & CheckBoxTovar1.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"5%\"><p class=\"P150\">" + Number + "</p></td><td width=\"55%\"><p class=\"P450\">" + TextBoxTovar1Naimenovanie5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Kolvo5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Ed5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1CenaEd5.Text + "</p></td><td width=\"10%\"><p class=\"P150\">" + TextBoxTovar1Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar2Naimenovanie5.Text.Length != 0 & CheckBoxTovar2.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar2Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar2Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar2Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar2CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar2Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar3Naimenovanie5.Text.Length != 0 & CheckBoxTovar3.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar3Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar3Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar3Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar3CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar3Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar4Naimenovanie5.Text.Length != 0 & CheckBoxTovar4.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar4Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar4Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar4Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar4CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar4Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar5Naimenovanie5.Text.Length != 0 & CheckBoxTovar5.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar5Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar5Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar5Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar5CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar5Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar6Naimenovanie5.Text.Length != 0 & CheckBoxTovar6.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar6Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar6Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar6Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar6CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar6Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar7Naimenovanie5.Text.Length != 0 & CheckBoxTovar7.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar7Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar7Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar7Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar7CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar7Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar8Naimenovanie5.Text.Length != 0 & CheckBoxTovar8.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar8Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar8Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar8Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar8CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar8Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar9Naimenovanie5.Text.Length != 0 & CheckBoxTovar9.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar9Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar9Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar9Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar9CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar9Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar10Naimenovanie5.Text.Length != 0 & CheckBoxTovar10.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar10Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar10Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar10Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar10CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar10Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar11Naimenovanie5.Text.Length != 0 & CheckBoxTovar11.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar11Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar11Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar11Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar11CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar11Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar12Naimenovanie5.Text.Length != 0 & CheckBoxTovar12.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar12Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar12Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar12Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar12CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar12Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar13Naimenovanie5.Text.Length != 0 & CheckBoxTovar13.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar13Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar13Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar13Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar13CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar13Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar14Naimenovanie5.Text.Length != 0 & CheckBoxTovar14.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar14Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar14Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar14Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar14CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar14Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar15Naimenovanie5.Text.Length != 0 & CheckBoxTovar15.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar15Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar15Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar15Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar15CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar15Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar16Naimenovanie5.Text.Length != 0 & CheckBoxTovar16.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar16Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar16Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar16Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar16CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar16Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar17Naimenovanie5.Text.Length != 0 & CheckBoxTovar17.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar17Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar17Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar17Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar17CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar17Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar18Naimenovanie5.Text.Length != 0 & CheckBoxTovar18.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar18Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar18Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar18Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar18CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar18Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar19Naimenovanie5.Text.Length != 0 & CheckBoxTovar19.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar19Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar19Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar19Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar19CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar19Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar20Naimenovanie5.Text.Length != 0 & CheckBoxTovar20.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar20Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar20Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar20Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar20CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar20Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar21Naimenovanie5.Text.Length != 0 & CheckBoxTovar21.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar21Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar21Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar21Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar21CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar21Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar22Naimenovanie5.Text.Length != 0 & CheckBoxTovar22.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar22Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar22Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar22Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar22CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar22Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar23Naimenovanie5.Text.Length != 0 & CheckBoxTovar23.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar23Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar23Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar23Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar23CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar23Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar24Naimenovanie5.Text.Length != 0 & CheckBoxTovar24.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar24Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar24Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar24Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar24CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar24Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar25Naimenovanie5.Text.Length != 0 & CheckBoxTovar25.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar25Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar25Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar25Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar25CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar25Stoimost5.Text + "</p></td></tr>\r\n"); }

                if (TextBoxTovar26Naimenovanie5.Text.Length != 0 & CheckBoxTovar26.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar26Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar26Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar26Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar26CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar26Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar27Naimenovanie5.Text.Length != 0 & CheckBoxTovar27.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar27Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar27Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar27Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar27CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar27Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar28Naimenovanie5.Text.Length != 0 & CheckBoxTovar28.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar28Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar28Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar28Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar28CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar28Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar29Naimenovanie5.Text.Length != 0 & CheckBoxTovar29.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar29Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar29Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar29Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar29CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar29Stoimost5.Text + "</p></td></tr>\r\n"); }
                if (TextBoxTovar30Naimenovanie5.Text.Length != 0 & CheckBoxTovar30.IsChecked == true) { Number = Number + 1; await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"10px\"><p class=\"P150\">" + Number + "</p></td><td width=\"10cm\"><p class=\"P450\">" + TextBoxTovar30Naimenovanie5.Text + "</p></td><td width=\"30px\"><p class=\"P150\">" + TextBoxTovar30Kolvo5.Text + "</p></td><td width=\"40px\"><p class=\"P150\">" + TextBoxTovar30Ed5.Text + "</p></td><td width=\"50px\"><p class=\"P150\">" + TextBoxTovar30CenaEd5.Text + "</p></td><td width=\"60px\"><p class=\"P150\">" + TextBoxTovar30Stoimost5.Text + "</p></td></tr>\r\n"); }


                await FileIO.AppendTextAsync(Myfile3, "</table><p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Товарная накладная содержит " + TextBoxItogoNomerovPoNakladnoj5.Text + " порядковых номеров записей</p><p class=\"P25\"> </p>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p style=\"font-family:Tahoma; font-size:7.5pt; text-align:left; font-weight:bold; \">Общая стоимость отгруженных товаров: " + TextBoxItogoSummaPoNakladnoj5.Text + " рублей, без НДС (Исполнитель применяет УСН)</p><p class=\"P25\"> </p><p class=\"P25\"> </p>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">ГРУЗ ПРИНЯЛ___________________________________________________________________________ПО ДОВЕРЕННОСТИ №____________________ОТ______________________</p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(должность, ФИО)</p><p class=\"P25\"> </p>");

                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P50\">Перечисленные выше товары со стороны Исполнителя Заказчику в полном объеме и в оговоренные Сторонами сроки были переданы.</p><p class=\"P25\"> </p><p class=\"P113\">ЗАКАЗЧИК К ИСПОЛНИТЕЛЮ ПРЕТЕНЗИЙ НЕ ИМЕЕТ.</p>");
                await FileIO.AppendTextAsync(Myfile3, "<p class=\"P25\"> </p><p class=\"P25\"> </p><p class=\"P25\"> </p><table border=\"1px\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" style=\"border-color:#999999;\"><tr><td width=\"50%\" style=\"text-align:center;\" ><p class=\"P13\">ИСПОЛНИТЕЛЬ:</p><p class=\"P25\"> </p></td><td width = \"50%\" style=\"text-align:center;\"><p class=\"P13\">ЗАКАЗЧИК:</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\" style = \"text-align:center;\"><p class=\"T5\">" + TextBoxMoeNaimenovanieSokr5.Text + "</p><p class=\"P25\"> </p></td><td width=\"50%\" style=\"text-align:center;\"><p class=\"T5\">" + TextBoxSokrNameKontr5.Text + "</p><p class=\"P25\"> </p></td></tr>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<tr><td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxMojUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxMojFackAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон/Моб.: " + TextBoxMojPhone5.Text + " / " + TextBoxMojMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxMojEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxMojSait5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxMojOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxMojINN5.Text + " / " + TextBoxMojKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: p/c " + TextBoxMoiRaschetnijSchet5.Text + " в " + TextBoxMoiBankName5.Text + ", БИК " + TextBoxMoiBankBIK5.Text + ", к/с " + TextBoxMoiBankKorr5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"P50\" style=\"margin-left:7px;\">Юридический адрес: " + TextBoxUrAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Фактический адрес: " + TextBoxFactAddr5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Телефон: " + TextBoxPhone5.Text + "<p class=\"P50\" style=\"margin-left:7px;\">Ответственный за исполнение Договора: " + TextBoxFIOOtvetstvennij5.Text + ", моб.телефон " + TextBoxMobile5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Электронная почта: " + TextBoxEmail5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Сайт: " + TextBoxSajt5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ОГРН " + TextBoxOGRN5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">ИНН/КПП " + TextBoxINN5.Text + " / " + TextBoxKPP5.Text + "</p><p class=\"P50\" style=\"margin-left:7px;\">Банковские реквизиты: " + TextBoxBankRekv5.Text + "</p></td>\r\n");

                ///в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr><tr><td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxMojaRukDolzhnost5.Text + "</p><p class=\"P25\"> </p><p class=\"P550\"><img src = \"data:image/jpeg;base64," + TextBoxMoiPechatPodpis5.Text + "\" >" + " / " + TextBoxMojFIORuk5.Text + "</p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataNakladnoj5.Text + "</p></td>\r\n");
                await FileIO.AppendTextAsync(Myfile3, "<td width=\"50%\"><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDolzhnostDirector5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">_________________________ /" + TextBoxRukSokr5.Text + "/  </p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">" + TextBoxDataNakladnoj5.Text + "</p><p class=\"P25\"> </p><p class=\"T5\" style=\"margin-left:7px;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;М.П.</p></td>\r\n");
                ///КОНЕЦ в этом блоке отличия между с печатью и без печати
                await FileIO.AppendTextAsync(Myfile3, "</tr></table></body></html>\r\n");

                await FileIO.AppendTextAsync(Myfile3, "\r\n");

                ProgressRing1.IsActive = false;

                // Let Windows know that we're finished changing the file so
                // the other app can update the remote version of the file.
                // Completing updates may require Windows to ask for user input.
                Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(Myfile3);
                if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                {
                    this.TextBlockStatusFile5.Text = "Файл товарной накладной " + Myfile3.Name + " успешно сохранен.";
                }
                else
                {
                    this.TextBlockStatusFile5.Text = "Не удалось сохранить файл товарной накладной " + Myfile3.Name + ".";
                }
            }
            else
            {
                this.TextBlockStatusFile5.Text = "Операция записи файла товарной накладной была прервана.";
            }
        }

        private void ButtonItogoSummaPoNakladnoj5_Click(object sender, RoutedEventArgs e)
        {
            float Result = 0;
            int n = 0;

            if (String.IsNullOrEmpty(TextBoxTovar1Stoimost5.Text)) { TextBoxTovar1Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar2Stoimost5.Text)) { TextBoxTovar2Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar3Stoimost5.Text)) { TextBoxTovar3Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar4Stoimost5.Text)) { TextBoxTovar4Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar5Stoimost5.Text)) { TextBoxTovar5Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar6Stoimost5.Text)) { TextBoxTovar6Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar7Stoimost5.Text)) { TextBoxTovar7Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar8Stoimost5.Text)) { TextBoxTovar8Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar9Stoimost5.Text)) { TextBoxTovar9Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar10Stoimost5.Text)) { TextBoxTovar10Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar11Stoimost5.Text)) { TextBoxTovar11Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar12Stoimost5.Text)) { TextBoxTovar12Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar13Stoimost5.Text)) { TextBoxTovar13Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar14Stoimost5.Text)) { TextBoxTovar14Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar15Stoimost5.Text)) { TextBoxTovar15Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar16Stoimost5.Text)) { TextBoxTovar16Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar17Stoimost5.Text)) { TextBoxTovar17Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar18Stoimost5.Text)) { TextBoxTovar18Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar19Stoimost5.Text)) { TextBoxTovar19Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar20Stoimost5.Text)) { TextBoxTovar20Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar21Stoimost5.Text)) { TextBoxTovar21Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar22Stoimost5.Text)) { TextBoxTovar22Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar23Stoimost5.Text)) { TextBoxTovar23Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar24Stoimost5.Text)) { TextBoxTovar24Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar25Stoimost5.Text)) { TextBoxTovar25Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar26Stoimost5.Text)) { TextBoxTovar26Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar27Stoimost5.Text)) { TextBoxTovar27Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar28Stoimost5.Text)) { TextBoxTovar28Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar29Stoimost5.Text)) { TextBoxTovar29Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar30Stoimost5.Text)) { TextBoxTovar30Stoimost5.Text = "0"; }

            if (!float.TryParse(TextBoxTovar1Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar2Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar3Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar4Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar5Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar6Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar7Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar8Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar9Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar10Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar11Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar12Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar13Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar14Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar15Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar16Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar17Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar18Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar19Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar20Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar21Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar22Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar23Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar24Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar25Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar26Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar27Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar28Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar29Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar30Stoimost5.Text, out Result))
            {
                return;
            }
            Result = 0;
            if (CheckBoxTovar1.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar1Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar2.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar2Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar3.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar3Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar4.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar4Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar5.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar5Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar6.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar6Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar7.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar7Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar8.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar8Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar9.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar9Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar10.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar10Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar11.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar11Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar12.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar12Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar13.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar13Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar14.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar14Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar15.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar15Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar16.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar16Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar17.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar17Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar18.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar18Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar19.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar19Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar20.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar20Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar21.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar21Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar22.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar22Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar23.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar23Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar24.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar24Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar25.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar25Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar26.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar26Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar27.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar27Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar28.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar28Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar29.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar29Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar30.IsChecked == true) { Result = Result + float.Parse(TextBoxTovar30Stoimost5.Text); n = n + 1; }

            TextBoxItogoSummaPoNakladnoj5.Text = Result.ToString();
            TextBoxItogoNomerovPoNakladnoj5.Text = n.ToString();
        }

        private void AddTovar1Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar2Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar2Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar2Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar2CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar2RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar2Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar1Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "2";
        }

        private void AddTovar2Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar3Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar3Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar3Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar3CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar3RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar3Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar3.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "3";
        }

        private void AddTovar3Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar4Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar4Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar4Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar4CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar4RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar4Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar4.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "4";
        }

        private void AddTovar4Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar5Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar5Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar5Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar5CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar5RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar5Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "5";
        }

        private void AddTovar5Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar6Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar6Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar6Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar6CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar6RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar6Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar6.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "6";
        }

        private void AddTovar6Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar7Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar7Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar7Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar7CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar7RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar7Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar7.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "7";
        }

        private void AddTovar7Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar8Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar8Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar8Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar8CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar8RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar8Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar8.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "8";
        }

        private void AddTovar8Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar9Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar9Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar9Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar9CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar9RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar9Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar9.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "9";
        }

        private void AddTovar9Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar10Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar10Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar10Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar10CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar10RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar10Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar10.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "10";
        }

        private void AddTovar10Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar11Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar11Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar11Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar11CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar11RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar11Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar11.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "11";
        }

        private void AddTovar11Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar12Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar12Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar12Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar12CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar12RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar12Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar12.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "12";
        }

        private void AddTovar12Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar13Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar13Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar13Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar13CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar13RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar13Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar13.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "13";
        }

        private void AddTovar13Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar14Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar14Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar14Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar14CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar14RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar14Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar14.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "14";
        }

        private void AddTovar14Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar15Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar15Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar15Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar15CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar15RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar15Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar15.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "15";
        }

        private void AddTovar15Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar16Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar16Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar16Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar16CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar16RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar16Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar16.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "16";
        }

        private void AddTovar16Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar17Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar17Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar17Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar17CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar17RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar17Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar17.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "17";
        }

        private void AddTovar17Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar18Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar18Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar18Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar18CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar18RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar18Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar18.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "18";
        }

        private void AddTovar18Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar19Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar19Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar19Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar19CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar19RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar19Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar19.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "19";
        }

        private void AddTovar19Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar20Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar20Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar20Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar20CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar20RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar20Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar20.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "20";
        }

        private void AddTovar20Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar21Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar21Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar21Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar21CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar21RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar21Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar21.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "21";
        }

        private void AddTovar21Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar22Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar22Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar22Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar22CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar22RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar22Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar22.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "22";
        }

        private void AddTovar22Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar23Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar23Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar23Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar23CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar23RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar23Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar23.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "23";
        }

        private void AddTovar23Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar24Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar24Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar24Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar24CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar24RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar24Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar24.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "24";
        }

        private void AddTovar24Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar25Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar25Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar25Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar25CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar25RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar25Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar25.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "25";
        }

        private void AddTovar25Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar26Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar26Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar26Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar26CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar26RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar26Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar26.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "26";
        }

        private void AddTovar26Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar27Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar27Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar27Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar27CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar27RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar27Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar27.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "27";
        }

        private void AddTovar27Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar28Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar28Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar28Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar28CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar28RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar28Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar28.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "28";
        }

        private void AddTovar28Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar29Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar29Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar29Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar29CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar29RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar29Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar29.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "29";
        }

        private void AddTovar29Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar30Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar30Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar30Ed5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar30CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ButtonTovar30RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            TextBoxTovar30Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CheckBoxTovar30.Visibility = Windows.UI.Xaml.Visibility.Visible;
            //AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar30Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            TextBlockLoadNastrojkiMessage.Text = "30";
        }



        private void RemoveTovar2Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar2Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar2RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar2Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar1Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            //RemoveTovar1Next.Visibility = Windows.UI.Xaml.Visibility.Visible;


            TextBoxTovar2Naimenovanie5.Text = "";
            TextBoxTovar2Kolvo5.Text = "";
            TextBoxTovar2Ed5.Text = "";
            TextBoxTovar2CenaEd5.Text = "";
            TextBoxTovar2Stoimost5.Text = "";
            CheckBoxTovar2.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "1";

        }

        private void RemoveTovar3Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar3Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar3RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar3Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar2Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar3Naimenovanie5.Text = "";
            TextBoxTovar3Kolvo5.Text = "";
            TextBoxTovar3Ed5.Text = "";
            TextBoxTovar3CenaEd5.Text = "";
            TextBoxTovar3Stoimost5.Text = "";
            CheckBoxTovar3.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "2";
        }

        private void RemoveTovar4Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar4Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar4RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar4Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar3Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar4Naimenovanie5.Text = "";
            TextBoxTovar4Kolvo5.Text = "";
            TextBoxTovar4Ed5.Text = "";
            TextBoxTovar4CenaEd5.Text = "";
            TextBoxTovar4Stoimost5.Text = "";
            CheckBoxTovar4.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "3";
        }

        private void RemoveTovar5Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar5Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar5RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar5Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar4Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar5Naimenovanie5.Text = "";
            TextBoxTovar5Kolvo5.Text = "";
            TextBoxTovar5Ed5.Text = "";
            TextBoxTovar5CenaEd5.Text = "";
            TextBoxTovar5Stoimost5.Text = "";
            CheckBoxTovar5.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "4";
        }

        private void RemoveTovar6Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar6Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar6RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar6Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar5Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar6Naimenovanie5.Text = "";
            TextBoxTovar6Kolvo5.Text = "";
            TextBoxTovar6Ed5.Text = "";
            TextBoxTovar6CenaEd5.Text = "";
            TextBoxTovar6Stoimost5.Text = "";
            CheckBoxTovar6.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "5";
        }

        private void RemoveTovar7Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar7Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar7RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar7Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar7.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar6Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar7Naimenovanie5.Text = "";
            TextBoxTovar7Kolvo5.Text = "";
            TextBoxTovar7Ed5.Text = "";
            TextBoxTovar7CenaEd5.Text = "";
            TextBoxTovar7Stoimost5.Text = "";
            CheckBoxTovar7.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "6";
        }

        private void RemoveTovar8Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar8Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar8RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar8Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar8.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar7Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar8Naimenovanie5.Text = "";
            TextBoxTovar8Kolvo5.Text = "";
            TextBoxTovar8Ed5.Text = "";
            TextBoxTovar8CenaEd5.Text = "";
            TextBoxTovar8Stoimost5.Text = "";
            CheckBoxTovar8.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "7";
        }

        private void RemoveTovar9Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar9Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar9RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar9Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar9.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar8Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar9Naimenovanie5.Text = "";
            TextBoxTovar9Kolvo5.Text = "";
            TextBoxTovar9Ed5.Text = "";
            TextBoxTovar9CenaEd5.Text = "";
            TextBoxTovar9Stoimost5.Text = "";
            CheckBoxTovar9.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "8";
        }

        private void RemoveTovar10Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar10Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar10RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar10Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar10.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar9Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar10Naimenovanie5.Text = "";
            TextBoxTovar10Kolvo5.Text = "";
            TextBoxTovar10Ed5.Text = "";
            TextBoxTovar10CenaEd5.Text = "";
            TextBoxTovar10Stoimost5.Text = "";
            CheckBoxTovar10.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "9";
        }

        private void RemoveTovar11Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar11Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar11RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar11Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar11.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar10Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar11Naimenovanie5.Text = "";
            TextBoxTovar11Kolvo5.Text = "";
            TextBoxTovar11Ed5.Text = "";
            TextBoxTovar11CenaEd5.Text = "";
            TextBoxTovar11Stoimost5.Text = "";
            CheckBoxTovar11.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "10";
        }

        private void RemoveTovar12Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar12Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar12RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar12Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar12.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar11Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar12Naimenovanie5.Text = "";
            TextBoxTovar12Kolvo5.Text = "";
            TextBoxTovar12Ed5.Text = "";
            TextBoxTovar12CenaEd5.Text = "";
            TextBoxTovar12Stoimost5.Text = "";
            CheckBoxTovar12.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "11";
        }

        private void RemoveTovar13Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar13Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar13RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar13Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar13.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar12Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar13Naimenovanie5.Text = "";
            TextBoxTovar13Kolvo5.Text = "";
            TextBoxTovar13Ed5.Text = "";
            TextBoxTovar13CenaEd5.Text = "";
            TextBoxTovar13Stoimost5.Text = "";
            CheckBoxTovar13.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "12";
        }

        private void RemoveTovar14Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar14Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar14RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar14Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar14.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar13Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar14Naimenovanie5.Text = "";
            TextBoxTovar14Kolvo5.Text = "";
            TextBoxTovar14Ed5.Text = "";
            TextBoxTovar14CenaEd5.Text = "";
            TextBoxTovar14Stoimost5.Text = "";
            CheckBoxTovar14.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "13";
        }

        private void RemoveTovar15Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar15Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar15RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar15Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar15.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar14Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar15Naimenovanie5.Text = "";
            TextBoxTovar15Kolvo5.Text = "";
            TextBoxTovar15Ed5.Text = "";
            TextBoxTovar15CenaEd5.Text = "";
            TextBoxTovar15Stoimost5.Text = "";
            CheckBoxTovar15.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "14";
        }

        private void RemoveTovar16Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar16Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar16RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar16Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar16.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar15Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar16Naimenovanie5.Text = "";
            TextBoxTovar16Kolvo5.Text = "";
            TextBoxTovar16Ed5.Text = "";
            TextBoxTovar16CenaEd5.Text = "";
            TextBoxTovar16Stoimost5.Text = "";
            CheckBoxTovar16.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "15";
        }

        private void RemoveTovar17Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar17Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar17RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar17Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar17.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar16Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar17Naimenovanie5.Text = "";
            TextBoxTovar17Kolvo5.Text = "";
            TextBoxTovar17Ed5.Text = "";
            TextBoxTovar17CenaEd5.Text = "";
            TextBoxTovar17Stoimost5.Text = "";
            CheckBoxTovar17.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "16";
        }

        private void RemoveTovar18Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar18Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar18RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar18Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar18.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar17Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar18Naimenovanie5.Text = "";
            TextBoxTovar18Kolvo5.Text = "";
            TextBoxTovar18Ed5.Text = "";
            TextBoxTovar18CenaEd5.Text = "";
            TextBoxTovar18Stoimost5.Text = "";
            CheckBoxTovar18.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "17";
        }

        private void RemoveTovar19Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar19Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar19RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar19Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar19.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar18Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar19Naimenovanie5.Text = "";
            TextBoxTovar19Kolvo5.Text = "";
            TextBoxTovar19Ed5.Text = "";
            TextBoxTovar19CenaEd5.Text = "";
            TextBoxTovar19Stoimost5.Text = "";
            CheckBoxTovar19.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "18";
        }

        private void RemoveTovar20Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar20Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar20RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar20Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar20.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar19Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar20Naimenovanie5.Text = "";
            TextBoxTovar20Kolvo5.Text = "";
            TextBoxTovar20Ed5.Text = "";
            TextBoxTovar20CenaEd5.Text = "";
            TextBoxTovar20Stoimost5.Text = "";
            CheckBoxTovar20.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "19";
        }

        private void RemoveTovar21Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar21Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar21RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar21Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar21.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar20Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar21Naimenovanie5.Text = "";
            TextBoxTovar21Kolvo5.Text = "";
            TextBoxTovar21Ed5.Text = "";
            TextBoxTovar21CenaEd5.Text = "";
            TextBoxTovar21Stoimost5.Text = "";
            CheckBoxTovar21.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "20";
        }

        private void RemoveTovar22Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar22Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar22RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar22Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar22.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar21Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar22Naimenovanie5.Text = "";
            TextBoxTovar22Kolvo5.Text = "";
            TextBoxTovar22Ed5.Text = "";
            TextBoxTovar22CenaEd5.Text = "";
            TextBoxTovar22Stoimost5.Text = "";
            CheckBoxTovar22.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "21";
        }

        private void RemoveTovar23Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar23Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar23RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar23Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar23.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar22Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar23Naimenovanie5.Text = "";
            TextBoxTovar23Kolvo5.Text = "";
            TextBoxTovar23Ed5.Text = "";
            TextBoxTovar23CenaEd5.Text = "";
            TextBoxTovar23Stoimost5.Text = "";
            CheckBoxTovar23.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "22";
        }

        private void RemoveTovar24Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar24Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar24RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar24Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar24.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar23Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar24Naimenovanie5.Text = "";
            TextBoxTovar24Kolvo5.Text = "";
            TextBoxTovar24Ed5.Text = "";
            TextBoxTovar24CenaEd5.Text = "";
            TextBoxTovar24Stoimost5.Text = "";
            CheckBoxTovar24.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "23";
        }

        private void RemoveTovar25Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar25Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar25RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar25Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar25.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar24Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar25Naimenovanie5.Text = "";
            TextBoxTovar25Kolvo5.Text = "";
            TextBoxTovar25Ed5.Text = "";
            TextBoxTovar25CenaEd5.Text = "";
            TextBoxTovar25Stoimost5.Text = "";
            CheckBoxTovar25.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "24";
        }

        private void RemoveTovar26Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar26Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar26RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar26Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar26.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar25Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar26Naimenovanie5.Text = "";
            TextBoxTovar26Kolvo5.Text = "";
            TextBoxTovar26Ed5.Text = "";
            TextBoxTovar26CenaEd5.Text = "";
            TextBoxTovar26Stoimost5.Text = "";
            CheckBoxTovar26.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "25";
        }

        private void RemoveTovar27Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar27Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar27RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar27Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar27.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar26Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar27Naimenovanie5.Text = "";
            TextBoxTovar27Kolvo5.Text = "";
            TextBoxTovar27Ed5.Text = "";
            TextBoxTovar27CenaEd5.Text = "";
            TextBoxTovar27Stoimost5.Text = "";
            CheckBoxTovar27.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "26";
        }

        private void RemoveTovar28Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar28Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar28RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar28Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar28.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar27Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar28Naimenovanie5.Text = "";
            TextBoxTovar28Kolvo5.Text = "";
            TextBoxTovar28Ed5.Text = "";
            TextBoxTovar28CenaEd5.Text = "";
            TextBoxTovar28Stoimost5.Text = "";
            CheckBoxTovar28.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "27";
        }

        private void RemoveTovar29Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar29Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar29RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar29Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar29.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar28Next.Visibility = Windows.UI.Xaml.Visibility.Visible;

            TextBoxTovar29Naimenovanie5.Text = "";
            TextBoxTovar29Kolvo5.Text = "";
            TextBoxTovar29Ed5.Text = "";
            TextBoxTovar29CenaEd5.Text = "";
            TextBoxTovar29Stoimost5.Text = "";
            CheckBoxTovar29.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "28";
        }

        private void RemoveTovar30Next_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTovar30Naimenovanie5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Kolvo5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Ed5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30CenaEd5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ButtonTovar30RaschetStoimosti5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBoxTovar30Stoimost5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckBoxTovar30.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            //AddTovar30Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            RemoveTovar30Next.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            AddTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Visible;
            RemoveTovar29Next.Visibility = Windows.UI.Xaml.Visibility.Visible;


            TextBoxTovar30Naimenovanie5.Text = "";
            TextBoxTovar30Kolvo5.Text = "";
            TextBoxTovar30Ed5.Text = "";
            TextBoxTovar30CenaEd5.Text = "";
            TextBoxTovar30Stoimost5.Text = "";
            CheckBoxTovar30.IsChecked = false;

            TextBlockLoadNastrojkiMessage.Text = "29";
        }

        private void ButtonItogoSummaPoAktu5_Click(object sender, RoutedEventArgs e)
        {
            float Result = 0;
            int n = 0;

            if (String.IsNullOrEmpty(TextBoxTovar1Stoimost5.Text)) { TextBoxTovar1Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar2Stoimost5.Text)) { TextBoxTovar2Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar3Stoimost5.Text)) { TextBoxTovar3Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar4Stoimost5.Text)) { TextBoxTovar4Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar5Stoimost5.Text)) { TextBoxTovar5Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar6Stoimost5.Text)) { TextBoxTovar6Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar7Stoimost5.Text)) { TextBoxTovar7Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar8Stoimost5.Text)) { TextBoxTovar8Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar9Stoimost5.Text)) { TextBoxTovar9Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar10Stoimost5.Text)) { TextBoxTovar10Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar11Stoimost5.Text)) { TextBoxTovar11Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar12Stoimost5.Text)) { TextBoxTovar12Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar13Stoimost5.Text)) { TextBoxTovar13Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar14Stoimost5.Text)) { TextBoxTovar14Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar15Stoimost5.Text)) { TextBoxTovar15Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar16Stoimost5.Text)) { TextBoxTovar16Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar17Stoimost5.Text)) { TextBoxTovar17Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar18Stoimost5.Text)) { TextBoxTovar18Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar19Stoimost5.Text)) { TextBoxTovar19Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar20Stoimost5.Text)) { TextBoxTovar20Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar21Stoimost5.Text)) { TextBoxTovar21Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar22Stoimost5.Text)) { TextBoxTovar22Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar23Stoimost5.Text)) { TextBoxTovar23Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar24Stoimost5.Text)) { TextBoxTovar24Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar25Stoimost5.Text)) { TextBoxTovar25Stoimost5.Text = "0"; }

            if (String.IsNullOrEmpty(TextBoxTovar26Stoimost5.Text)) { TextBoxTovar26Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar27Stoimost5.Text)) { TextBoxTovar27Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar28Stoimost5.Text)) { TextBoxTovar28Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar29Stoimost5.Text)) { TextBoxTovar29Stoimost5.Text = "0"; }
            if (String.IsNullOrEmpty(TextBoxTovar30Stoimost5.Text)) { TextBoxTovar30Stoimost5.Text = "0"; }

            if (!float.TryParse(TextBoxTovar1Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar2Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar3Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar4Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar5Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar6Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar7Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar8Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar9Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar10Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar11Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar12Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar13Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar14Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar15Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar16Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar17Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar18Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar19Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar20Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar21Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar22Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar23Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar24Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar25Stoimost5.Text, out Result)
                || !float.TryParse(TextBoxTovar26Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar27Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar28Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar29Stoimost5.Text, out Result) || !float.TryParse(TextBoxTovar30Stoimost5.Text, out Result))
            {
                return;
            }
            Result = 0;
            if (CheckBoxTovar1.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar1Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar2.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar2Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar3.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar3Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar4.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar4Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar5.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar5Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar6.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar6Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar7.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar7Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar8.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar8Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar9.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar9Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar10.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar10Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar11.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar11Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar12.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar12Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar13.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar13Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar14.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar14Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar15.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar15Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar16.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar16Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar17.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar17Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar18.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar18Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar19.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar19Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar20.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar20Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar21.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar21Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar22.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar22Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar23.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar23Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar24.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar24Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar25.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar25Stoimost5.Text); n = n + 1; }

            if (CheckBoxTovar26.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar26Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar27.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar27Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar28.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar28Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar29.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar29Stoimost5.Text); n = n + 1; }
            if (CheckBoxTovar30.IsChecked == false) { Result = Result + float.Parse(TextBoxTovar30Stoimost5.Text); n = n + 1; }

            TextBoxItogoSummaPoAktu5.Text = Result.ToString();
        }
    }
}
