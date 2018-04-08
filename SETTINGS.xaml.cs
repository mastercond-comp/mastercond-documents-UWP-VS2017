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

using Windows.Security.Cryptography;
using System.Security.Cryptography; //SHA512 ХЭШ
using Windows.Security.Credentials; //Место хранения PIN
using System.Text;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SETTINGS : Page
    {
        public SETTINGS()
        {
            this.InitializeComponent();

           

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string addSQLSettings = @"CREATE TABLE IF NOT EXISTS NALOGSETTINGS (ID Integer Primary Key NOT NULL, Nalog Varchar(255));";
            dbConnection.Prepare(addSQLSettings).Step();

            string addSQLSettings0 = @"CREATE TABLE IF NOT EXISTS PRINTINGSETTINGS (ID Integer Primary Key NOT NULL, Printing Varchar(255));";
            dbConnection.Prepare(addSQLSettings0).Step();

            string addSQLSettings1 = @"CREATE TABLE IF NOT EXISTS SDELKIVISIBILITYSETTINGS (ID Integer Primary Key NOT NULL, OBJECT Varchar(255), VISIBILITY Varchar(255));";
            dbConnection.Prepare(addSQLSettings1).Step();

            string addSQLSettings2 = @"CREATE TABLE IF NOT EXISTS SKLADVISIBILITYSETTINGS (ID Integer Primary Key NOT NULL, OBJECT Varchar(255), VISIBILITY Varchar(255));";
            dbConnection.Prepare(addSQLSettings2).Step();


            //ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON NALOG
            string readSQL = "SELECT Nalog FROM NALOGSETTINGS WHERE ID=1;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                string NalogStatusString = dbState["Nalog"] as string;
                if (NalogStatusString == "6") { RadioButtonSixPercent.IsChecked = true; }

                if (NalogStatusString == "15") { RadioButtonFifteenPercent.IsChecked = true; }
            }
            //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON NALOG

            //ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON PRINTING
            string readSQL1 = "SELECT Printing FROM PRINTINGSETTINGS WHERE ID=1;";
            ISQLiteStatement dbState1 = dbConnection.Prepare(readSQL1);
            while (dbState1.Step() == SQLiteResult.ROW)
            {
                string PrintingStatusString = dbState1["Printing"] as string;
                if (PrintingStatusString == "HTML") { RadioButtonHTMLPrinting.IsChecked = true; }

                if (PrintingStatusString == "PDF") { RadioButtonPDFPrinting.IsChecked = true; }
            }
            //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ RADIOBUTTON PRINTING

        }

        private async void ExportDatabase_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            StorageFile exportFile = await localFolder.GetFileAsync("sdelkidatabase.db");

            var savePicker1 = new Windows.Storage.Pickers.FolderPicker();
            savePicker1.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;

            savePicker1.FileTypeFilter.Add(".db");
            // Default file name if the user does not type one in or select a file to replace
            

            Windows.Storage.StorageFolder destinationFolder = await savePicker1.PickSingleFolderAsync();
            if (destinationFolder != null)
            {
                try
                {
                    string dbfile = "sdelkidatabase.db";
                    await exportFile.CopyAsync(destinationFolder, dbfile, NameCollisionOption.ReplaceExisting);
                    StatusFile.Text = "Файл sdelkidatabase.db успешно сохранен в выбранной папке";
                }
                catch { StatusFile.Text = " Не удалось экспортировать файл sdelkidatabase.db в выбранную папку."; }
            }

        }

        private async void ImportDatabase_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder localFolder1 = ApplicationData.Current.LocalFolder;

            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.FileTypeFilter.Add(".db");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                try
                {
                    string dbfile = "sdelkidatabase.db";
                    await file.CopyAsync(localFolder1,dbfile,NameCollisionOption.ReplaceExisting);
                    StatusFile.Text = "Файл sdelkidatabase.db успешно скопирован (импортирован) в рабочую папку приложения.";
                }
                catch
                {
                    StatusFile.Text = "Не удалось скопировать (импортировать) файл sdelkidatabase.db в рабочую папку приложения.";
                }
            }
        }

        private async void ButtonDeleteDB_Click(object sender, RoutedEventArgs e)
        {
            await ContentDialogDeleteDB.ShowAsync();
        }

        private void ContentDialogDeleteDB_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL1 = "DELETE FROM SdelkiBase;";
            string writeSQL2 = "DELETE FROM SkladBase;";
            string writeSQL3 = "DELETE FROM NALOGSETTINGS;";
            dbConnection.Prepare(writeSQL1).Step();
            dbConnection.Prepare(writeSQL2).Step();
            dbConnection.Prepare(writeSQL3).Step();
            StatusFile.Text = "БАЗА ДАННЫХ УДАЛЕНА.";
        }

        private void RadioButtonSixPercent_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO NALOGSETTINGS ([ID],[Nalog]) VALUES ('1','6');";
            dbConnection.Prepare(writeSQL).Step();
            StatusFile.Text = "Система налогообложения установлена: УСН 6% (ДОХОД)";
        }

        private void RadioButtonFifteenPercent_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO NALOGSETTINGS ([ID],[Nalog]) VALUES ('1','15');";
            dbConnection.Prepare(writeSQL).Step();
            StatusFile.Text = "Система налогообложения установлена: УСН 15% (ДОХОД МИНУС РАСХОД)";
        }

        public static string MakeCryptSHA512(string text)
        {
            string hash = "";
            SHA512 alg = SHA512.Create();
            byte[] result = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
            hash = Encoding.UTF8.GetString(result);
            return hash;
        }

        private void ButtonDeletePIN_Click(object sender, RoutedEventArgs e)
        {
            var vault = new Windows.Security.Credentials.PasswordVault();
            string resourceName = "Mastercond.Documents";
            string defaultUserName = "Owner";
            string password = MakeCryptSHA512(EnterPINPasswordBox.Password.ToString());
            try
            {
                vault.Remove(new Windows.Security.Credentials.PasswordCredential(resourceName, defaultUserName, password));
                StatusFile.Text = "ПИН-код успешно удален. При следующем входе в приложение Вы сможете установить новый ПИН.";
            }
            catch { StatusFile.Text = "Не удалось выполнить сброс ПИН-кода. Проверьте правильность введенного Вами ПИН-кода."; }
            }

        private void RadioButtonHTMLPrinting_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO PRINTINGSETTINGS ([ID],[Printing]) VALUES ('1','HTML');";
            dbConnection.Prepare(writeSQL).Step();
            StatusFile.Text = "Настройка вывода документов установлена: HTML (старый вариант)";
        }

        private void RadioButtonPDFPrinting_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO PRINTINGSETTINGS ([ID],[Printing]) VALUES ('1','PDF');";
            dbConnection.Prepare(writeSQL).Step();
            StatusFile.Text = "Настройка вывода документов установлена: PDF (новый вариант)";
        }


        private void ComboShZArial_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShZ8_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShZ9_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShZ10_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShZ11_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShZ12_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShT8_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShT9_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShT10_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShT11_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboRShT12_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboShTArial_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboShZSegoe_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboShTSegoe_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
