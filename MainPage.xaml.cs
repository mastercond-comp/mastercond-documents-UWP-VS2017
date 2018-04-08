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

using Windows.Security.Cryptography;
using System.Security.Cryptography; //SHA512 ХЭШ
using Windows.Security.Credentials; //Место хранения PIN
using System.Text; //ENCODING

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Мастерконд.Документы
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string resourceName = "Mastercond.Documents";
        private string defaultUserName = "Owner";

        public MainPage()
        {
            this.InitializeComponent();

            MenuListBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            HamburgerButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            try
            {
                #region ПОПЫТАТЬСЯ ПОЛУЧИТЬ ПИН ИЗ ХРАНИЛИЩА
                var vault = new Windows.Security.Credentials.PasswordVault();
                var SavedPIN = vault.Retrieve(resourceName, defaultUserName);
                #endregion
            }

            catch
            {
                StackPanelEnterPIN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonEnterPin.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                StackPanelSETUPPIN.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }

        private void ButtonEnterPin_Click(object sender, RoutedEventArgs e)
        {
            string PinCrypt = MakeCryptSHA512(PinCodePasswordBox.Password);

            #region  ПОЛУЧИТЬ ПИН ИЗ ХРАНИЛИЩА
            var vault = new Windows.Security.Credentials.PasswordVault();
            var SavedPIN = vault.Retrieve(resourceName, defaultUserName);
            #endregion

            if (PinCrypt == SavedPIN.Password)
            {
                MainScrollViewer.Background = new SolidColorBrush(Windows.UI.Colors.White);
                ContentFrame.Background = new SolidColorBrush(Windows.UI.Colors.White);
                ContentFrame.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MenuListBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                HamburgerButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                StackPanelEnterPIN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonEnterPin.Visibility= Windows.UI.Xaml.Visibility.Collapsed;
                StatusPIN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ContentFrame.Navigate(typeof(QuickPage));
            }
            else
            {
                StatusPIN.Text = "Неверный ПИН-код. Попробуйте ещё раз.";
            }

        }

        private void ButtonSetupPIN_Click(object sender, RoutedEventArgs e)
        {
            StatusSetupPIN.Text = "";
            if (PasswordBoxNEWPIN1.Password !="" || PasswordBoxNEWPIN2.Password != "")
            { 
            string PinCrypt1 = MakeCryptSHA512(PasswordBoxNEWPIN1.Password);
            string PinCrypt2 = MakeCryptSHA512(PasswordBoxNEWPIN2.Password);
            if (PinCrypt1 == PinCrypt2)
            {
                #region  ЗАПИСАТЬ ПИН В ХРАНИЛИЩЕ
                var vault = new Windows.Security.Credentials.PasswordVault();
                var credential = new Windows.Security.Credentials.PasswordCredential(resourceName, defaultUserName, PinCrypt2);
                vault.Add(credential);
                #endregion

                StackPanelEnterPIN.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonEnterPin.Visibility = Windows.UI.Xaml.Visibility.Visible;
                StackPanelSETUPPIN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else { StatusSetupPIN.Text = "Введенные ПИН-коды не совпадают. Попробуйте ещё раз."; }
            }
            else { StatusSetupPIN.Text = "ПИН-код не должен быть пустым. Введите ПИН-код повторно."; }
        }



        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen = !(this.MySplitView.IsPaneOpen);
        }

        private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AddKontragent.IsSelected) { ContentFrame.Navigate(typeof(AddRekviziti)); }
            else

            if (AddMyRekviziti.IsSelected) { ContentFrame.Navigate(typeof(AddMoiRekviziti)); }
            else

            if (Documents.IsSelected) { ContentFrame.Navigate(typeof(CreateDocuments30)); }
            else
                if (TZakl.IsSelected) { ContentFrame.Navigate(typeof(Tehzakl)); }
            else
            if (MiniSkladPage.IsSelected) { ContentFrame.Navigate(typeof(MINISKLAD)); }
            else
            if (SettingsPage.IsSelected) { ContentFrame.Navigate(typeof(SETTINGS)); }
            else
                if (About.IsSelected) { ContentFrame.Navigate(typeof(About)); }
            else
                if (Help.IsSelected) { ContentFrame.Navigate(typeof(SPRAVKA)); }
            else
            if (Root.IsSelected) { ContentFrame.Navigate(typeof(QuickPage)); }
            else
                if (SpisokSdelok.IsSelected) { ContentFrame.Navigate(typeof(SDELKIBASE)); }
        }

        public static string MakeCryptSHA512(string text)
        {
            string hash = "";
            SHA512 alg = SHA512.Create();
            byte[] result = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
            hash = Encoding.UTF8.GetString(result);
            return hash;
        }
    }
}
