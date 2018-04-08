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
using DataAppModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SDELKIBASE : Page
    {
        List<string> kontragentNamebox;
        List<string> myNamebox;
        List<string> dogovorNomerbox;
        List<string> dogovorDatebox;
        List<string> nakladnajaDatebox;
        List<string> aktDatebox;
        List<string> yearDatebox;

        List<string> INNbox;
        List<string> KONTAKTNAMEbox;
        List<string> KONTAKTPHONEbox;

        public ObservableCollection<SdelkiData> Sdelki { get; set; }

        public Windows.UI.Xaml.Visibility INNVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility INAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility KONTRNAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility AKTDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility RASXODIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public Windows.UI.Xaml.Visibility PRIMECHANIEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        public double NChecked = 1;
        public int _ID = 0;
        

        public SDELKIBASE()
        {
            this.InitializeComponent();

            kontragentNamebox = new List<string> { };
            myNamebox = new List<string> { };
            dogovorDatebox = new List<string> { };
            nakladnajaDatebox = new List<string> { };
            aktDatebox = new List<string> { };
            dogovorNomerbox = new List<string> { };
            yearDatebox = new List<string> { };

            INNbox = new List<string> { };
            KONTAKTNAMEbox = new List<string> { };
            KONTAKTPHONEbox = new List<string> { };

            Sdelki = new ObservableCollection<SdelkiData> { };


            TextBlockINNTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockMyNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockDogovorDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockDogovorNumberTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockNakladnajaDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockAktDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockRasxodiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockSummaItogoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockStatusSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKontaktNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKontaktPhoneTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKvartalSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockYearSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string addSQL = @"CREATE TABLE IF NOT EXISTS SdelkiBase (IDSdelki Integer Primary Key Autoincrement NOT NULL, KontragentName Varchar(255), MyName Varchar(255), DataDogovora Varchar(200), NomerDogovora Varchar(200), DataNakladnoj Varchar(200), DataAkta Varchar(200), RasxodiSumma Varchar(200), ItogoSumma Varchar(200), StatusSdelki Varchar(200));";
            dbConnection.Prepare(addSQL).Step();

            try
            {
                string addSQLSettings1 = @"CREATE TABLE SDELKIVISIBILITYSETTINGS (ID Integer Primary Key NOT NULL, OBJECT Varchar(255), VISIBILITY Varchar(255));";
                dbConnection.Prepare(addSQLSettings1).Step();
                string writeSQL1 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','INAME','VISIBLE');";
                string writeSQL2 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','DOGOVORDATE','VISIBLE');";
                string writeSQL3 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','DOGOVORNUMBER','VISIBLE');";
                string writeSQL4 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','NAKLADNAJADATE','VISIBLE');";
                string writeSQL5 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','AKTDATE','VISIBLE');";
                string writeSQL6 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','RASXODI','VISIBLE');";
                string writeSQL7 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','SUMMAITOGO','VISIBLE');";
                string writeSQL8 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('8','STATUSSDELKI','VISIBLE');";
                string writeSQL9 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('9','YEARSDELKI','VISIBLE');";
                string writeSQL10 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('10','KVARTALSDELKI','VISIBLE');";
                string writeSQL11 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('11','KONTAKTNAME','VISIBLE');";
                string writeSQL12 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('12','KONTAKTPHONE','VISIBLE');";
                string writeSQL13 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('13','INN','VISIBLE');";
                string writeSQL14 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('14','PRIMECHANIE','VISIBLE');";
                dbConnection.Prepare(writeSQL1).Step();
                dbConnection.Prepare(writeSQL2).Step();
                dbConnection.Prepare(writeSQL3).Step();
                dbConnection.Prepare(writeSQL4).Step();
                dbConnection.Prepare(writeSQL5).Step();
                dbConnection.Prepare(writeSQL6).Step();
                dbConnection.Prepare(writeSQL7).Step();
                dbConnection.Prepare(writeSQL8).Step();
                dbConnection.Prepare(writeSQL9).Step();
                dbConnection.Prepare(writeSQL10).Step();
                dbConnection.Prepare(writeSQL11).Step();
                dbConnection.Prepare(writeSQL12).Step();
                dbConnection.Prepare(writeSQL13).Step();
                dbConnection.Prepare(writeSQL14).Step();
            }
            catch { }


            //ДОБАВЛЯЕМ СТОЛБЕЦ YEAR
            try
            {
                string addSQL2 = "ALTER TABLE SdelkiBase ADD COLUMN Year Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL2).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ YEAR

            //ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL
            try
            {
                string addSQL3 = "ALTER TABLE SdelkiBase ADD COLUMN Kvartal Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL3).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL

            //ДОБАВЛЯЕМ СТОЛБЕЦ INN
            try
            {
                string addSQL4 = "ALTER TABLE SdelkiBase ADD COLUMN INN Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL4).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ INN

            //ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTNAME
            try
            {
                string addSQL5 = "ALTER TABLE SdelkiBase ADD COLUMN KONTAKTNAME Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL5).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTNAME

            //ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTPHONE
            try
            {
                string addSQL5 = "ALTER TABLE SdelkiBase ADD COLUMN KONTAKTPHONE Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL5).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTPHONE

            //ДОБАВЛЯЕМ СТОЛБЕЦ PRIMECHANIE
            try
            {
                string addSQL5 = "ALTER TABLE SdelkiBase ADD COLUMN PRIMECHANIE TEXT DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL5).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ PRIMECHANIE

            try
            {
                string addSQL5 = "INSERT INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('14','PRIMECHANIE','VISIBLE');";
                dbConnection.Prepare(addSQL5).Step();
            }
            catch { }


            try
            {
                SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL1 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=1;";
                ISQLiteStatement dbState1 = dbConnection1.Prepare(readSQL1);
                while (dbState1.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState1["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxMyName.IsChecked = true; INAMEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockMyNameTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxMyName.IsChecked = false; INAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockMyNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }
                

                SQLitePCL.SQLiteConnection dbConnection2 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL2 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=2;";
                ISQLiteStatement dbState2 = dbConnection2.Prepare(readSQL2);
                while (dbState2.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState2["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxDogovorDate.IsChecked = true; DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockDogovorDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxDogovorDate.IsChecked = false; DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockDogovorDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection3 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL3 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=3;";
                ISQLiteStatement dbState3 = dbConnection3.Prepare(readSQL3);
                while (dbState3.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState3["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxDogovorNumber.IsChecked = true; DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockDogovorNumberTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxDogovorNumber.IsChecked = false; DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockDogovorNumberTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection4 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL4 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=4;";
                ISQLiteStatement dbState4 = dbConnection4.Prepare(readSQL4);
                while (dbState4.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState4["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxNakladnajaDate.IsChecked = true; NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockNakladnajaDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxNakladnajaDate.IsChecked = false; NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockNakladnajaDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection5 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL5 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=5;";
                ISQLiteStatement dbState5 = dbConnection5.Prepare(readSQL5);
                while (dbState5.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState5["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxAktDate.IsChecked = true; AKTDATEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockAktDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxAktDate.IsChecked = false; AKTDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockAktDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection6 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL6 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=6;";
                ISQLiteStatement dbState6 = dbConnection6.Prepare(readSQL6);
                while (dbState6.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState6["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxRasxodi.IsChecked = true; RASXODIVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockRasxodiTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxRasxodi.IsChecked = false; RASXODIVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockRasxodiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection7 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL7 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=7;";
                ISQLiteStatement dbState7 = dbConnection7.Prepare(readSQL7);
                while (dbState7.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState7["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxSummaItogo.IsChecked = true; SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockSummaItogoTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxSummaItogo.IsChecked = false; SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockSummaItogoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection8 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL8 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=8;";
                ISQLiteStatement dbState8 = dbConnection8.Prepare(readSQL8);
                while (dbState8.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState8["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxStatusSdelki.IsChecked = true; STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockStatusSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxStatusSdelki.IsChecked = false; STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockStatusSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection9 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL9 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=9;";
                ISQLiteStatement dbState9 = dbConnection9.Prepare(readSQL9);
                while (dbState9.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState9["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxYearSdelki.IsChecked = true; YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockYearSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxYearSdelki.IsChecked = false; YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockYearSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection10 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL10 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=10;";
                ISQLiteStatement dbState10 = dbConnection10.Prepare(readSQL10);
                while (dbState10.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState10["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxKvartalSdelki.IsChecked = true; KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockKvartalSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxKvartalSdelki.IsChecked = false; KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockKvartalSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection11 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL11 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=11;";
                ISQLiteStatement dbState11 = dbConnection11.Prepare(readSQL11);
                while (dbState11.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState11["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxKontaktName.IsChecked = true; KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockKontaktNameTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxKontaktName.IsChecked = false; KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockKontaktNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection12 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL12 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=12;";
                ISQLiteStatement dbState12 = dbConnection12.Prepare(readSQL12);
                while (dbState12.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState12["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxKontaktPhone.IsChecked = true; KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockKontaktPhoneTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxKontaktPhone.IsChecked = false; KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockKontaktPhoneTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                SQLitePCL.SQLiteConnection dbConnection13 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL13 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=13;";
                ISQLiteStatement dbState13 = dbConnection13.Prepare(readSQL13);
                while (dbState13.Step() == SQLiteResult.ROW)
                {
                    string Visibility0 = dbState13["VISIBILITY"] as string;
                    if (Visibility0 == "VISIBLE") { CheckBoxINN.IsChecked = true; INNVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockINNTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                    if (Visibility0 == "UNVISIBLE") { CheckBoxINN.IsChecked = false; INNVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockINNTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                }

                
                    SQLitePCL.SQLiteConnection dbConnection14 = new SQLiteConnection("sdelkidatabase.db");
                    string readSQL14 = "SELECT VISIBILITY FROM SDELKIVISIBILITYSETTINGS WHERE ID=14;";
                    ISQLiteStatement dbState14 = dbConnection14.Prepare(readSQL14);
                    while (dbState14.Step() == SQLiteResult.ROW)
                    {
                        string Visibility0 = dbState14["VISIBILITY"] as string;
                        if (Visibility0 == "VISIBLE") { CheckBoxPrimechanie.IsChecked = true; PRIMECHANIEVisibility = Windows.UI.Xaml.Visibility.Visible; NChecked = NChecked + 1; TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                        if (Visibility0 == "UNVISIBLE") { CheckBoxPrimechanie.IsChecked = false; PRIMECHANIEVisibility = Windows.UI.Xaml.Visibility.Collapsed; double S = 160; Razdelitel1.Width = Razdelitel1.Width - S; Razdelitel2.Width = Razdelitel2.Width - S; Razdelitel3.Width = Razdelitel3.Width - S; TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed; }
                    }
                
                Razdelitel1.Width = NChecked * 160;
                Razdelitel2.Width = NChecked * 160;
                Razdelitel3.Width = NChecked * 160;
            }

            catch
            {
                string writeSQL1 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','INAME','VISIBLE');";
                string writeSQL2 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','DOGOVORDATE','VISIBLE');";
                string writeSQL3 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','DOGOVORNUMBER','VISIBLE');";
                string writeSQL4 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','NAKLADNAJADATE','VISIBLE');";
                string writeSQL5 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','AKTDATE','VISIBLE');";
                string writeSQL6 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','RASXODI','VISIBLE');";
                string writeSQL7 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','SUMMAITOGO','VISIBLE');";
                string writeSQL8 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('8','STATUSSDELKI','VISIBLE');";
                string writeSQL9 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('9','YEARSDELKI','VISIBLE');";
                string writeSQL10 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('10','KVARTALSDELKI','VISIBLE');";
                string writeSQL11 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('11','KONTAKTNAME','VISIBLE');";
                string writeSQL12 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('12','KONTAKTPHONE','VISIBLE');";
                string writeSQL13 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('13','INN','VISIBLE');";
                string writeSQL14 = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('14','PRIMECHANIE','VISIBLE');";
                dbConnection.Prepare(writeSQL1).Step();
                dbConnection.Prepare(writeSQL2).Step();
                dbConnection.Prepare(writeSQL3).Step();
                dbConnection.Prepare(writeSQL4).Step();
                dbConnection.Prepare(writeSQL5).Step();
                dbConnection.Prepare(writeSQL6).Step();
                dbConnection.Prepare(writeSQL7).Step();
                dbConnection.Prepare(writeSQL8).Step();
                dbConnection.Prepare(writeSQL9).Step();
                dbConnection.Prepare(writeSQL10).Step();
                dbConnection.Prepare(writeSQL11).Step();
                dbConnection.Prepare(writeSQL12).Step();
                dbConnection.Prepare(writeSQL13).Step();
                dbConnection.Prepare(writeSQL14).Step();

                INNVisibility = Windows.UI.Xaml.Visibility.Visible;
                INAMEVisibility = Windows.UI.Xaml.Visibility.Visible;
                KONTRNAMEVisibility = Windows.UI.Xaml.Visibility.Visible;
                DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Visible;
                DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Visible;
                NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Visible;
                AKTDATEVisibility = Windows.UI.Xaml.Visibility.Visible;
                SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Visible;
                RASXODIVisibility = Windows.UI.Xaml.Visibility.Visible;
                STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
                YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
                KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
                KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Visible;
                KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Visible;
                PRIMECHANIEVisibility= Windows.UI.Xaml.Visibility.Visible;
            }

            this.Sdelki.Clear();
            ReadDataBase();

            AddListSuggestBoxes();

            // Sdelki.CollectionChanged += Sdelki_CollectionChanged; //подписываемся на изменение коллекции
            this.ComboBoxStatusSdelki2.SelectedItem = Combo2011;
            this.ComboBoxKvartalSdelkiSearch.SelectedItem = ComboKvartalSearch0;
        }

        public void ReadDataBase()
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM,   IsVisibleAKTDATE=AKTDATEVisibility,IsVisibleDOGOVORDATE=DOGOVORDATEVisibility,IsVisibleDOGOVORNUMBER=DOGOVORNUMBERVisibility,IsVisibleINAME=INAMEVisibility,IsVisibleINN=INNVisibility,IsVisibleKONTAKTNAME=KONTAKTNAMEVisibility,IsVisibleKONTAKTPHONE=KONTAKTPHONEVisibility,IsVisibleKVARTALSDELKI=KVARTALSDELKIVisibility,IsVisibleNAKLADNAJADATE=NAKLADNAJADATEVisibility,IsVisibleRASXODI=RASXODIVisibility,IsVisibleSTATUSSDELKI=STATUSSDELKIVisibility, IsVisibleSUMMAITOGO=SUMMAITOGOVisibility,IsVisibleYEARSDELKI=YEARSDELKIVisibility,INN=SO,KONTAKTNAME=SP,KONTAKTPHONE=SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                _ID = SNN;

                Buffer1.Text = "";
                foreach (string s in kontragentNamebox)
                {
                    if (SA == s) { Buffer1.Text = "not null"; }
                }
                if (Buffer1.Text == "") { kontragentNamebox.Add(SA); }


                Buffer2.Text = "";
                foreach (string s in myNamebox)
                {
                    if (SB == s) { Buffer2.Text = "not null"; }
                }
                if (Buffer2.Text == "") { myNamebox.Add(SB); }

                Buffer3.Text = "";
                foreach (string s in dogovorDatebox)
                {
                    if (SC == s) { Buffer3.Text = "not null"; }
                }
                if (Buffer3.Text == "") { dogovorDatebox.Add(SC); }

                Buffer4.Text = "";
                foreach (string s in dogovorNomerbox)
                {
                    if (SD == s) { Buffer4.Text = "not null"; }
                }
                if (Buffer4.Text == "") { dogovorNomerbox.Add(SD); }

                Buffer5.Text = "";
                foreach (string s in nakladnajaDatebox)
                {
                    if (SE == s) { Buffer5.Text = "not null"; }
                }
                if (Buffer5.Text == "") { nakladnajaDatebox.Add(SE); }

                Buffer6.Text = "";
                foreach (string s in aktDatebox)
                {
                    if (SF == s) { Buffer6.Text = "not null"; }
                }
                if (Buffer6.Text == "") { aktDatebox.Add(SF); }

                Buffer7.Text = "";
                foreach (string s in yearDatebox)
                {
                    if (SM == s) { Buffer7.Text = "not null"; }
                }
                if (Buffer7.Text == "") { yearDatebox.Add(SM); }

                Buffer8.Text = "";
                foreach (string s in INNbox)
                {
                    if (SO == s) { Buffer8.Text = "not null"; }
                }
                if (Buffer8.Text == "") { INNbox.Add(SO); }

                Buffer9.Text = "";
                foreach (string s in KONTAKTNAMEbox)
                {
                    if (SP == s) { Buffer9.Text = "not null"; }
                }
                if (Buffer9.Text == "") { KONTAKTNAMEbox.Add(SP); }

                Buffer10.Text = "";
                foreach (string s in KONTAKTPHONEbox)
                {
                    if (SQ == s) { Buffer10.Text = "not null"; }
                }
                if (Buffer10.Text == "") { KONTAKTPHONEbox.Add(SQ); }


                //КОНЕЦ ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ}
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

                //ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ

            }
        }

        public void AddListSuggestBoxes()
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR= dbState["PRIMECHANIE"] as string;

                _ID = SNN;
                //ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ
                Buffer1.Text = "";
                foreach (string s in kontragentNamebox)
                {
                    if (SA == s) { Buffer1.Text = "not null"; }
                }
                if (Buffer1.Text == "") { kontragentNamebox.Add(SA); }


                Buffer2.Text = "";
                foreach (string s in myNamebox)
                {
                    if (SB == s) { Buffer2.Text = "not null"; }
                }
                if (Buffer2.Text == "") { myNamebox.Add(SB); }

                Buffer3.Text = "";
                foreach (string s in dogovorDatebox)
                {
                    if (SC == s) { Buffer3.Text = "not null"; }
                }
                if (Buffer3.Text == "") { dogovorDatebox.Add(SC); }

                Buffer4.Text = "";
                foreach (string s in dogovorNomerbox)
                {
                    if (SD == s) { Buffer4.Text = "not null"; }
                }
                if (Buffer4.Text == "") { dogovorNomerbox.Add(SD); }

                Buffer5.Text = "";
                foreach (string s in nakladnajaDatebox)
                {
                    if (SE == s) { Buffer5.Text = "not null"; }
                }
                if (Buffer5.Text == "") { nakladnajaDatebox.Add(SE); }

                Buffer6.Text = "";
                foreach (string s in aktDatebox)
                {
                    if (SF == s) { Buffer6.Text = "not null"; }
                }
                if (Buffer6.Text == "") { aktDatebox.Add(SF); }

                Buffer7.Text = "";
                foreach (string s in yearDatebox)
                {
                    if (SM == s) { Buffer7.Text = "not null"; }
                }
                if (Buffer7.Text == "") { yearDatebox.Add(SM); }

                Buffer8.Text = "";
                foreach (string s in INNbox)
                {
                    if (SO == s) { Buffer8.Text = "not null"; }
                }
                if (Buffer8.Text == "") { INNbox.Add(SO); }

                Buffer9.Text = "";
                foreach (string s in KONTAKTNAMEbox)
                {
                    if (SP == s) { Buffer9.Text = "not null"; }
                }
                if (Buffer9.Text == "") { KONTAKTNAMEbox.Add(SP); }

                Buffer10.Text = "";
                foreach (string s in KONTAKTPHONEbox)
                {
                    if (SQ == s) { Buffer10.Text = "not null"; }
                }
                if (Buffer10.Text == "") { KONTAKTPHONEbox.Add(SQ); }


                //КОНЕЦ ДОБАВЛЕНИЕ В СПИСОК ТОЛЬКО НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ
            }
        } //добавление данных в AutoSuggestBox'ы

        private async void SdelkiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddComboBuffer1.Text = "";
            TextBoxMyName1.Text = "";
            TextBoxKontrName1.Text = "";
            TextBoxDogovorDate1.Text = "";
            TextBoxDogovorNumber1.Text = "";
            TextBoxAktData1.Text = "";
            TextBoxNakladnajaData1.Text = "";
            TextBoxRasxodi1.Text = "";
            TextBoxSummaItogo1.Text = "";
            ComboBoxKvartalSdelki11Buffer.Text = "";
            TextBoxSdelkaYear1.Text = "";
            ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal10;


            SdelkiData selectedSdelka = (SdelkiData)e.ClickedItem;

            int NumberID = selectedSdelka.Id;

            TextBoxMyName1.Text = selectedSdelka.INAME;
            TextBoxKontrName1.Text = selectedSdelka.KONTRNAME;
            TextBoxDogovorDate1.Text = selectedSdelka.DOGOVORDATE;
            TextBoxDogovorNumber1.Text = selectedSdelka.DOGOVORNUMBER;
            TextBoxAktData1.Text = selectedSdelka.AKTDATE;
            TextBoxNakladnajaData1.Text = selectedSdelka.NAKLADNAJADATE;
            TextBoxRasxodi1.Text = selectedSdelka.RASXODI;
            TextBoxSummaItogo1.Text = selectedSdelka.SUMMAITOGO;
            try
            {
            AddComboBuffer1.Text = selectedSdelka.STATUSSDELKI;
            ComboBoxKvartalSdelki11Buffer.Text = selectedSdelka.KVARTALSDELKI;
            TextBoxSdelkaYear1.Text = selectedSdelka.YEARSDELKI;
            }
            catch { }

            try
            {
                TextBoxINN1.Text = selectedSdelka.INN;
                TextBoxKONTAKTNAME1.Text = selectedSdelka.KONTAKTNAME;
                TextBoxKONTAKTPHONE1.Text = selectedSdelka.KONTAKTPHONE;
            }
            catch { }

            try { TextBoxPrimechanie1.Text = selectedSdelka.PRIMECHANIE; }
            catch { }
            //StatusFile.Text = AddComboBuffer1.Text;


            //ПОИСК ОШИБОК ПРИ ПОМОЩИ ФАЙЛА BUFFER.TXT
            //StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            //StorageFile bufferFile = await localFolder.CreateFileAsync("buffer.txt", CreationCollisionOption.ReplaceExisting);
            //await FileIO.WriteTextAsync(bufferFile, NumberID.ToString() + "|" + TextBoxMyName1.Text + "|" + TextBoxKontrName1.Text
            //    + "|" + TextBoxDogovorDate1.Text + "|" + TextBoxDogovorNumber1.Text + "|" + TextBoxAktData1.Text + "|" +
            //TextBoxNakladnajaData1.Text + "|" + TextBoxRasxodi1.Text + "|" + TextBoxSummaItogo1.Text + "|");

            if (AddComboBuffer1.Text == "Сделано предложение") { ComboBoxStatusSdelki2.SelectedItem = Combo211; }
            if (AddComboBuffer1.Text == "Заключен договор, выставлен счет") { ComboBoxStatusSdelki2.SelectedItem = Combo212; }
            if (AddComboBuffer1.Text == "В работе") { ComboBoxStatusSdelki2.SelectedItem = Combo213; }
            if (AddComboBuffer1.Text == "Исполнена, ожидает подписания актов/накладных") { ComboBoxStatusSdelki2.SelectedItem = Combo214; }
            if (AddComboBuffer1.Text == "Ожидание оплаты") { ComboBoxStatusSdelki2.SelectedItem = Combo215; }
            if (AddComboBuffer1.Text == "Завершена") { ComboBoxStatusSdelki2.SelectedItem = Combo216; }
            if (AddComboBuffer1.Text == "Договор расторгнут") { ComboBoxStatusSdelki2.SelectedItem = Combo217; }
            if (AddComboBuffer1.Text == "") { ComboBoxStatusSdelki2.SelectedItem = Combo2011; }

            if (ComboBoxKvartalSdelki11Buffer.Text == "Выберите квартал" || ComboBoxKvartalSdelki11Buffer.Text == "") { ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal10; }
            if (ComboBoxKvartalSdelki11Buffer.Text == "Первый квартал") { ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal11; }
            if (ComboBoxKvartalSdelki11Buffer.Text == "Второй квартал") { ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal12; }
            if (ComboBoxKvartalSdelki11Buffer.Text == "Третий квартал") { ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal13; }
            if (ComboBoxKvartalSdelki11Buffer.Text == "Четвертый квартал") { ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal14; }


            await ContentDialogChangeSdelka.ShowAsync();

            
        }

        private void SaveSdelki_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            foreach (SdelkiData Sdelka in Sdelki)
            {
                string SA = Sdelka.KONTRNAME;
                string SB = Sdelka.INAME;
                string SC = Sdelka.DOGOVORDATE;
                string SD = Sdelka.DOGOVORNUMBER;
                string SE = Sdelka.NAKLADNAJADATE;
                string SF = Sdelka.AKTDATE;
                string SJ = Sdelka.RASXODI;
                string SK = Sdelka.SUMMAITOGO;

                string ssSQL = @"INSERT INTO [SdelkiBase] ([KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma]) VALUES ('" + SA + "','" + SB + "','" +
                    SC + "','" + SD + "','" + SE + "','" + SF + "','" + SJ + "','" + SK + "');";
                dbConnection.Prepare(ssSQL).Step(); //подготовить SQL-строку и выполнить команду}
            }
        }

        private async void AddSdelkaFile_Click(object sender, RoutedEventArgs e)
        {
            var picker3 = new Windows.Storage.Pickers.FileOpenPicker();
            ///picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker3.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker3.FileTypeFilter.Add(".docdata");
            Windows.Storage.StorageFile file3 = await picker3.PickSingleFileAsync();
            if (file3 != null)
            {

                // Application now has read/write access to the picked file
                this.StatusFile.Text = "Загружены данные из файла: " + file3.Name;
                ///здесь далее код на чтение данных из файла построчно



                var readFile3 = await Windows.Storage.FileIO.ReadLinesAsync(file3);
                foreach (var line in readFile3) ///перебор всех элементов первой строки
                {
                    
                    SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                    try
                    {
                        string SokrNameKontr1 = line.Split(';')[1]; //сокр.имя контрагента - в базу
                        string INN1 = line.Split(';')[2]; //ИНН контрагента - в базу

                        //ДОБАВЛЕНИЕ ТЕЛЕФОНОВ В БАЗУ
                        string SPhone1 = line.Split(';')[11]; //Телефон
                        string MPhone1 = line.Split(';')[12]; //Моб
                        string Phone1 = ""; //ТЕЛЕФОН

                        if (SPhone1 != "" & MPhone1 != "") { Phone1 = SPhone1 + "," + MPhone1; }

                        if (SPhone1 == "")
                        {
                            string SPhone11 = line.Split(';')[11]; //Телефон
                            string MPhone11 = line.Split(';')[12]; //Моб
                            if (MPhone11 == "") { Phone1 = ""; }
                            else { Phone1 = MPhone11; }
                        }

                        if (MPhone1 == "")
                        {
                            string SPhone11 = line.Split(';')[11]; //Телефон
                            string MPhone11 = line.Split(';')[12]; //Моб
                            if (SPhone11 == "") { Phone1 = ""; }
                            else { Phone1 = SPhone11; }
                        }
                        //КОНЕЦ ДОБАВЛЕНИЕ ТЕЛЕФОНОВ В БАЗУ

                        string MoeNaimenovanieSokr1 = line.Split(';')[16]; //мое сокр.наименование - в базу
                        string DataDogovora1 = line.Split(';')[38]; //дата договора - в базу
                        string NomerDogovora1 = line.Split(';')[39]; //номер договора - в базу
                        string DataNakladnoj1 = line.Split(';')[40]; //дата накладной - в базу
                        string DataAkta1 = line.Split(';')[41]; //дата акта - в базу
                        string KontaktName1 = line.Split(';')[50]; // ФИО ответственного
                        string Itogo1 = line.Split(';')[201]; //итоговая сумма сделки - в базу
                                                              // string RasxodipoSdelke = line.Split(';')[xxx]; //расходы по сделке - после добавления соответствующего модуля в Документы Юр.лица

                        string Sstatussdelki = "";
                        string YyearSdelki = "";
                        string KkvartalSdelki = "";
                        string Primechanie = "";

                        try
                        {
                            Sstatussdelki = line.Split(';')[237];

                            YyearSdelki = line.Split(';')[239];
                            KkvartalSdelki = line.Split(';')[238];
                        }
                        catch { }

                        if (_ID == Sdelki.Count)
                        {
                            int IdSdelkiN = 0;

                            IdSdelkiN = Sdelki.Count + 1;

                            Sdelki.Add(new SdelkiData
                            {
                                INAME = MoeNaimenovanieSokr1,
                                KONTRNAME = SokrNameKontr1,
                                DOGOVORDATE = DataDogovora1,
                                DOGOVORNUMBER = NomerDogovora1,
                                AKTDATE = DataAkta1,
                                NAKLADNAJADATE = DataNakladnoj1,
                                SUMMAITOGO = Itogo1,
                                Id = IdSdelkiN,
                                STATUSSDELKI = Sstatussdelki,
                                YEARSDELKI = YyearSdelki,
                                KVARTALSDELKI = KkvartalSdelki,
                                KONTAKTPHONE = Phone1,
                                KONTAKTNAME = KontaktName1,
                                INN = INN1,
                                PRIMECHANIE=Primechanie,
                                IsVisibleAKTDATE = AKTDATEVisibility,
                                IsVisibleDOGOVORDATE = DOGOVORDATEVisibility,
                                IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility,
                                IsVisibleINAME = INAMEVisibility,
                                IsVisibleINN = INNVisibility,
                                IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility,
                                IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility,
                                IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility,
                                IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility,
                                IsVisibleRASXODI = RASXODIVisibility,
                                IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility,
                                IsVisibleSUMMAITOGO = SUMMAITOGOVisibility,
                                IsVisibleYEARSDELKI = YEARSDELKIVisibility,
                                IsVisiblePRIMECHANIE=PRIMECHANIEVisibility
                            });


                            string writeSQL = "INSERT INTO SdelkiBase ([IDSdelki],[KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma],[StatusSdelki],[Year],[Kvartal],[INN],[KONTAKTNAME],[KONTAKTPHONE],[PRIMECHANIE]) VALUES ('"
                                + IdSdelkiN + "','" + SokrNameKontr1 + "','" + MoeNaimenovanieSokr1 + "','" + DataDogovora1 + "','" + NomerDogovora1 + "','"
                                + DataNakladnoj1 + "','" + DataAkta1 + "','" + "0" + "','" + Itogo1 + "','" + Sstatussdelki + "','" + YyearSdelki + "','" + KkvartalSdelki + "','" + INN1 + "','" + KontaktName1 + "','" + Phone1 + "','" + Primechanie + "');";
                            dbConnection.Prepare(writeSQL).Step();
                        }
                        else
                        {
                            int IdSdelkiN = 0;

                            IdSdelkiN = _ID + 1;

                            Sdelki.Add(new SdelkiData
                            {
                                INAME = MoeNaimenovanieSokr1,
                                KONTRNAME = SokrNameKontr1,
                                DOGOVORDATE = DataDogovora1,
                                DOGOVORNUMBER = NomerDogovora1,
                                AKTDATE = DataAkta1,
                                NAKLADNAJADATE = DataNakladnoj1,
                                SUMMAITOGO = Itogo1,
                                Id = IdSdelkiN,
                                STATUSSDELKI = Sstatussdelki,
                                YEARSDELKI = YyearSdelki,
                                KVARTALSDELKI = KkvartalSdelki,
                                KONTAKTPHONE = Phone1,
                                KONTAKTNAME = KontaktName1,
                                INN = INN1,
                                PRIMECHANIE=Primechanie,
                                IsVisibleAKTDATE = AKTDATEVisibility,
                                IsVisibleDOGOVORDATE = DOGOVORDATEVisibility,
                                IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility,
                                IsVisibleINAME = INAMEVisibility,
                                IsVisibleINN = INNVisibility,
                                IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility,
                                IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility,
                                IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility,
                                IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility,
                                IsVisibleRASXODI = RASXODIVisibility,
                                IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility,
                                IsVisibleSUMMAITOGO = SUMMAITOGOVisibility,
                                IsVisibleYEARSDELKI = YEARSDELKIVisibility,
                                IsVisiblePRIMECHANIE=PRIMECHANIEVisibility
                            });


                            string writeSQL = "INSERT INTO SdelkiBase ([IDSdelki],[KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma],[StatusSdelki],[Year],[Kvartal],[INN],[KONTAKTNAME],[KONTAKTPHONE],[PRIMECHANIE]) VALUES ('"
                                + IdSdelkiN + "','" + SokrNameKontr1 + "','" + MoeNaimenovanieSokr1 + "','" + DataDogovora1 + "','" + NomerDogovora1 + "','"
                                + DataNakladnoj1 + "','" + DataAkta1 + "','" + "0" + "','" + Itogo1 + "','" + Sstatussdelki + "','" + YyearSdelki + "','" + KkvartalSdelki + "','" + INN1 + "','" + KontaktName1 + "','" + Phone1 + "','" +Primechanie + "');";
                            dbConnection.Prepare(writeSQL).Step();
                        }
                        StatusSearch.Text = "ALL";
                    }
                    catch
                    {
                        StatusFile.Text = "Не удалось добавить сделку из файла в базу данных сделок";
                        StatusSearch.Text = "ALL";
                    }

                    this.Sdelki.Clear();
                    //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                    string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
                    ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                    while (dbState.Step() == SQLiteResult.ROW)
                    {
                        //вот здесь вся проблема
                        int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                        //как получить IDSdelki

                        string SA = dbState["KontragentName"] as string;
                        string SB = dbState["MyName"] as string;
                        string SC = dbState["DataDogovora"] as string;
                        string SD = dbState["NomerDogovora"] as string;
                        string SE = dbState["DataNakladnoj"] as string;
                        string SF = dbState["DataAkta"] as string;
                        string SJ = dbState["RasxodiSumma"] as string;
                        string SK = dbState["ItogoSumma"] as string;
                        string SL = dbState["StatusSdelki"] as string;
                        string SM = dbState["Year"] as string;
                        string SN = dbState["Kvartal"] as string;

                        string SO = dbState["INN"] as string;
                        string SP = dbState["KONTAKTNAME"] as string;
                        string SQ = dbState["KONTAKTPHONE"] as string;

                        string SR = dbState["PRIMECHANIE"] as string;
                        //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                        Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                    }
                    //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                    AddListSuggestBoxes();
                    StatusSearch.Text = "ALL";
                }
            }
            else
            {
                this.StatusFile.Text = "Операция загрузки данных прервана.";
            }
        }

        private async void AddSdelka_Click(object sender, RoutedEventArgs e)
        {
            await ContentDialogAddNewSdelka.ShowAsync();
        }

        private void ContentDialogAddNewSdelka_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            AddComboBuffer.Text = "";
            ComboBoxKvartalSdelki1Buffer.Text = "";
            if (Combo11.IsSelected == true) { AddComboBuffer.Text = "Сделано предложение"; }
            if (Combo12.IsSelected == true) { AddComboBuffer.Text = "Заключен договор, выставлен счет"; }
            if (Combo13.IsSelected == true) { AddComboBuffer.Text = "В работе"; }
            if (Combo14.IsSelected == true) { AddComboBuffer.Text = "Исполнена, ожидает подписания актов/накладных"; }
            if (Combo15.IsSelected == true) { AddComboBuffer.Text = "Ожидание оплаты"; }
            if (Combo16.IsSelected == true) { AddComboBuffer.Text = "Завершена"; }
            if (Combo17.IsSelected == true) { AddComboBuffer.Text = "Договор расторгнут"; }

            if (TextBoxRasxodi.Text == "" || TextBoxRasxodi.Text == " ") { TextBoxRasxodi.Text = "0"; }
            if (TextBoxSummaItogo.Text == "" || TextBoxSummaItogo.Text == " ") { TextBoxSummaItogo.Text = "0"; }


            if (ComboKvartal1.IsSelected == true) { ComboBoxKvartalSdelki1Buffer.Text = "Первый квартал"; }
            if (ComboKvartal2.IsSelected == true) { ComboBoxKvartalSdelki1Buffer.Text = "Второй квартал"; }
            if (ComboKvartal3.IsSelected == true) { ComboBoxKvartalSdelki1Buffer.Text = "Третий квартал"; }
            if (ComboKvartal4.IsSelected == true) { ComboBoxKvartalSdelki1Buffer.Text = "Четвертый квартал"; }
            if (ComboKvartal0.IsSelected == true) { ComboBoxKvartalSdelki1Buffer.Text = "Выберите квартал"; }

            if (_ID == Sdelki.Count)
            {
                int SdelkiNN = Sdelki.Count + 1;
                Sdelki.Add(new SdelkiData { Id = SdelkiNN, INAME = TextBoxMyName.Text, KONTRNAME = TextBoxKontrName.Text, DOGOVORDATE = TextBoxDogovorDate.Text, DOGOVORNUMBER = TextBoxDogovorNumber.Text, AKTDATE = TextBoxAktData.Text, NAKLADNAJADATE = TextBoxNakladnajaData.Text, RASXODI = TextBoxRasxodi.Text, SUMMAITOGO = TextBoxSummaItogo.Text, STATUSSDELKI = AddComboBuffer.Text, YEARSDELKI = TextBoxSdelkaYear.Text, KVARTALSDELKI = ComboBoxKvartalSdelki1Buffer.Text, INN = TextBoxINN.Text, KONTAKTNAME = TextBoxKONTAKTNAME.Text, KONTAKTPHONE = TextBoxKONTAKTPHONE.Text, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility,PRIMECHANIE=TextBoxPrimechanie.Text,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                StatusFile.Text = "Добавлена новая сделка: " + TextBoxKontrName.Text + " (номер договора " + TextBoxDogovorNumber.Text + ")";
                //////////////////////////////////////////////////////////////////////////////////////
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                string writeSQL = "INSERT INTO SdelkiBase ([IDSdelki],[KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma],[StatusSdelki],[Year],[Kvartal],[INN],[KONTAKTNAME],[KONTAKTPHONE],[PRIMECHANIE]) VALUES ('" + SdelkiNN.ToString() + "','" + TextBoxKontrName.Text + "','" + TextBoxMyName.Text + "','" + TextBoxDogovorDate.Text + "','" + TextBoxDogovorNumber.Text + "','" + TextBoxNakladnajaData.Text + "','" + TextBoxAktData.Text + "','" + TextBoxRasxodi.Text + "','" + TextBoxSummaItogo.Text + "','" + AddComboBuffer.Text + "','" + TextBoxSdelkaYear.Text + "','" + ComboBoxKvartalSdelki1Buffer.Text + "','" + TextBoxINN.Text + "','" + TextBoxKONTAKTNAME.Text + "','" + TextBoxKONTAKTPHONE.Text + "','" + TextBoxPrimechanie.Text+ "');";
                dbConnection.Prepare(writeSQL).Step();
                /////////////////////////////////////////////////////////////////////////////////////

            }
            else
            {
                int SdelkiNN = _ID + 1;
                Sdelki.Add(new SdelkiData { Id = _ID+1, INAME = TextBoxMyName.Text, KONTRNAME = TextBoxKontrName.Text, DOGOVORDATE = TextBoxDogovorDate.Text, DOGOVORNUMBER = TextBoxDogovorNumber.Text, AKTDATE = TextBoxAktData.Text, NAKLADNAJADATE = TextBoxNakladnajaData.Text, RASXODI = TextBoxRasxodi.Text, SUMMAITOGO = TextBoxSummaItogo.Text, STATUSSDELKI = AddComboBuffer.Text, YEARSDELKI = TextBoxSdelkaYear.Text, KVARTALSDELKI = ComboBoxKvartalSdelki1Buffer.Text, INN = TextBoxINN.Text, KONTAKTNAME = TextBoxKONTAKTNAME.Text, KONTAKTPHONE = TextBoxKONTAKTPHONE.Text, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, PRIMECHANIE = TextBoxPrimechanie.Text, IsVisiblePRIMECHANIE = PRIMECHANIEVisibility });
                StatusFile.Text = "Добавлена новая сделка: " + TextBoxKontrName.Text + " (номер договора " + TextBoxDogovorNumber.Text + ")";
                //////////////////////////////////////////////////////////////////////////////////////
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                string writeSQL = "INSERT INTO SdelkiBase ([IDSdelki],[KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma],[StatusSdelki],[Year],[Kvartal],[INN],[KONTAKTNAME],[KONTAKTPHONE],[PRIMECHANIE]) VALUES ('" + SdelkiNN.ToString() + "','" + TextBoxKontrName.Text + "','" + TextBoxMyName.Text + "','" + TextBoxDogovorDate.Text + "','" + TextBoxDogovorNumber.Text + "','" + TextBoxNakladnajaData.Text + "','" + TextBoxAktData.Text + "','" + TextBoxRasxodi.Text + "','" + TextBoxSummaItogo.Text + "','" + AddComboBuffer.Text + "','" + TextBoxSdelkaYear.Text + "','" + ComboBoxKvartalSdelki1Buffer.Text + "','" + TextBoxINN.Text + "','" + TextBoxKONTAKTNAME.Text + "','" + TextBoxKONTAKTPHONE.Text + "','" + TextBoxPrimechanie.Text + "');";
                dbConnection.Prepare(writeSQL).Step();
                /////////////////////////////////////////////////////////////////////////////////////

            }

            this.Sdelki.Clear();


            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
            ISQLiteStatement dbState = dbConnection1.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            AddListSuggestBoxes();


            //ОБНУЛЯЕМ СОДЕРЖИМОЕ
            TextBoxMyName.Text = "";
            TextBoxKontrName.Text = "";
            TextBoxDogovorDate.Text = "";
            TextBoxDogovorNumber.Text = "";
            TextBoxAktData.Text = "";
            TextBoxNakladnajaData.Text = "";
            TextBoxRasxodi.Text = "";
            TextBoxSummaItogo.Text = "";
            Combo011.IsSelected = true;
            ComboKvartal0.IsSelected = true;
            TextBoxSdelkaYear.Text = "";
            TextBoxINN.Text = "";
            TextBoxKONTAKTNAME.Text = "";
            TextBoxKONTAKTPHONE.Text = "";
            TextBoxPrimechanie.Text = "";

            StatusSearch.Text = "ALL";
        }//KVARTAL+YEAR ГОТОВО

        private async void ContentDialogChangeSdelka_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            ContentDialogChangeSdelka.Hide();
            await ContentDialogDelete.ShowAsync();
        }

        private void Sdelki_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) //что происходит при изменении коллекции
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
                                                            //string writeSQL2 = @"SELECT [KontragentName],[MyName],[DataDogovora],[NomerDogovora],[DataNakladnoj],[DataAkta],[RasxodiSumma],[ItogoSumma],[StatusSdelki] FROM SdelkiBase";
                                                            //dbConnection2.Prepare(writeSQL2).Step();
                                                            /////////////////////////////////////////////////////////////////////////////////////
                    break;

            }
        }

        private void ContentDialogChangeSdelka_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            AddComboBuffer1.Text = "";
            ComboBoxKvartalSdelki11Buffer.Text = "";

            if (Combo211.IsSelected == true) { AddComboBuffer1.Text = "Сделано предложение"; }
            if (Combo212.IsSelected == true) { AddComboBuffer1.Text = "Заключен договор, выставлен счет"; }
            if (Combo213.IsSelected == true) { AddComboBuffer1.Text = "В работе"; }
            if (Combo214.IsSelected == true) { AddComboBuffer1.Text = "Исполнена, ожидает подписания актов/накладных"; }
            if (Combo215.IsSelected == true) { AddComboBuffer1.Text = "Ожидание оплаты"; }
            if (Combo216.IsSelected == true) { AddComboBuffer1.Text = "Завершена"; }
            if (Combo217.IsSelected == true) { AddComboBuffer1.Text = "Договор расторгнут"; }

            if (ComboKvartal11.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Первый квартал"; }
            if (ComboKvartal12.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Второй квартал"; }
            if (ComboKvartal13.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Третий квартал"; }
            if (ComboKvartal14.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Четвертый квартал"; }
            if (ComboKvartal10.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Выберите квартал"; }


            SdelkiData SdelkaActive = (SdelkiData)SdelkiList.SelectedItem; //Sdelki+List -- выбор активного элемента коллекции

            if (TextBoxRasxodi1.Text == "" || TextBoxRasxodi1.Text == " ") { TextBoxRasxodi1.Text = "0"; }
            if (TextBoxSummaItogo1.Text == "" || TextBoxSummaItogo1.Text == " ") { TextBoxSummaItogo1.Text = "0"; }

            SdelkaActive.INAME = TextBoxMyName1.Text;
            SdelkaActive.KONTRNAME = TextBoxKontrName1.Text;
            SdelkaActive.DOGOVORDATE = TextBoxDogovorDate1.Text;
            SdelkaActive.DOGOVORNUMBER = TextBoxDogovorNumber1.Text;
            SdelkaActive.NAKLADNAJADATE = TextBoxNakladnajaData1.Text;
            SdelkaActive.AKTDATE = TextBoxAktData1.Text;
            SdelkaActive.RASXODI = TextBoxRasxodi1.Text;
            SdelkaActive.SUMMAITOGO = TextBoxSummaItogo1.Text;
            SdelkaActive.STATUSSDELKI = AddComboBuffer1.Text;
            SdelkaActive.KVARTALSDELKI = ComboBoxKvartalSdelki11Buffer.Text;
            SdelkaActive.YEARSDELKI = TextBoxSdelkaYear1.Text;
            SdelkaActive.INN = TextBoxINN1.Text;
            SdelkaActive.KONTAKTNAME = TextBoxKONTAKTNAME1.Text;
            SdelkaActive.KONTAKTPHONE = TextBoxKONTAKTPHONE1.Text;
            SdelkaActive.PRIMECHANIE = TextBoxPrimechanie1.Text;
            int IDD = SdelkaActive.Id;


            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "UPDATE SdelkiBase SET KontragentName='" + TextBoxKontrName1.Text + "',MyName='" + TextBoxMyName1.Text + "',DataDogovora= '" + TextBoxDogovorDate1.Text + "',NomerDogovora='" + TextBoxDogovorNumber1.Text + "',DataNakladnoj= '" + TextBoxNakladnajaData1.Text + "',DataAkta= '" + TextBoxAktData1.Text + "',RasxodiSumma='" + TextBoxRasxodi1.Text + "',ItogoSumma='" + TextBoxSummaItogo1.Text + "',StatusSdelki='" + AddComboBuffer1.Text + "',Year='" + TextBoxSdelkaYear1.Text+ "',Kvartal='" + ComboBoxKvartalSdelki11Buffer.Text + "',INN='" + TextBoxINN1.Text + "',KONTAKTNAME='" + TextBoxKONTAKTNAME1.Text + "',KONTAKTPHONE='" +TextBoxKONTAKTPHONE1.Text + "',PRIMECHANIE='" + TextBoxPrimechanie1.Text + "' WHERE IDSdelki='" + IDD + "';";
            dbConnection.Prepare(writeSQL).Step();

            this.Sdelki.Clear();
            AddListSuggestBoxes();

            if (StatusSearch.Text == "ALL")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            if (StatusSearch.Text == "Kontragent")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KontragentName='" + TextBoxSearchKontragent.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            if (StatusSearch.Text == "MyName")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE MyName='" + TextBoxSearchMyName.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            if (StatusSearch.Text == "DogovorNumber")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE NomerDogovora='" + TextBoxSearchDovorNumber.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "DogovorDate")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataDogovora='" + TextBoxSearchDogovorDate.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            }

            if (StatusSearch.Text == "NakladnajaDate")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataNakladnoj='" + TextBoxSearchNakladnajaDate.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "AktDate")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataAkta='" + TextBoxSearchAktDate.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "111")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Сделано предложение';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;


                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "112")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Заключен договор, выставлен счет';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "113")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='В работе';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;


                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ


            }

            if (StatusSearch.Text == "114")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Исполнена, ожидает подписания актов/накладных';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "115")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Ожидание оплаты';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "116")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Завершена';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "117")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Договор расторгнут';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text=="Year")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE Year='" + TextBoxSearchNalogYear.Text + "' AND StatusSdelki='Завершена';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                
            }

            if (StatusSearch.Text == "NalogKvartal")
            {
                TextBlockComboSearchNalogKvartalBuffer.Text = "";

                if (ComboKvartalSearch1.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Первый квартал"; }
                if (ComboKvartalSearch2.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Второй квартал"; }
                if (ComboKvartalSearch3.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Третий квартал"; }
                if (ComboKvartalSearch4.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Четвертый квартал"; }
                if (ComboKvartalSearch0.IsSelected == true) { ComboBoxKvartalSdelki11Buffer.Text = "Выберите квартал"; }

                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE Year='" + TextBoxSearchNalogKvartalYear.Text + "' AND Kvartal='" + TextBlockComboSearchNalogKvartalBuffer.Text + "' AND StatusSdelki='Завершена';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                TextBlockComboSearchNalogKvartalBuffer.Text = "";
            }

            if (StatusSearch.Text == "INN")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE INN='" + TextBoxSearchINN.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }

                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "KONTAKTNAME")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KONTAKTNAME='" + TextBoxSearchKontaktName.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }

                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }

            if (StatusSearch.Text == "KONTAKTPHONE")
            {
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KONTAKTPHONE='" + TextBoxSearchKontaktPhone.Text + "';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM = dbState["Year"] as string;
                    string SN = dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });
                }

                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            }


            //ОБНУЛЯЕМ СОДЕРЖИМОЕ
            TextBoxMyName1.Text = "";
            TextBoxKontrName1.Text = "";
            TextBoxDogovorDate1.Text = "";
            TextBoxDogovorNumber1.Text = "";
            TextBoxNakladnajaData1.Text = "";
            TextBoxAktData1.Text = "";
            TextBoxRasxodi1.Text = "";
            TextBoxSummaItogo1.Text = "";
            AddComboBuffer1.Text = "";
            ComboBoxKvartalSdelki11Buffer.Text = "";
            TextBoxSdelkaYear1.Text = "";
            TextBoxINN1.Text = "";
            TextBoxKONTAKTNAME1.Text = "";
            TextBoxKONTAKTPHONE1.Text = "";
            TextBoxPrimechanie1.Text = "";

            ComboBoxStatusSdelki2.SelectedItem = Combo2011;
            ComboBoxKvartalSdelki11.SelectedItem = ComboKvartal10;
        } //НЕОБХОДИМО БУДЕТ ДОБАВИТЬ ПОИСКОВЫЕ ДАННЫЕ,  KVARTAL+YEAR ГОТОВО

        private void DELETETABLE_Click(object sender, RoutedEventArgs e)
        {
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "DELETE FROM SdelkiBase;";
            dbConnection.Prepare(writeSQL).Step();
            this.Sdelki.Clear();
            AddListSuggestBoxes();
        }

        private void ButtonSearchOpen_Click(object sender, RoutedEventArgs e)
        {
            string ButtonStatus = ButtonSearchOpen.Content.ToString();


            if (ButtonStatus == "+")
            {
                TextBlockSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchStatusSdelki.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchINN.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Visible;

                TextBoxSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchINN.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Visible;


                ButtonSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchINN.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Visible;


                ButtonShowWholeBase.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonSearchStatusSdelki.Visibility = Windows.UI.Xaml.Visibility.Visible;

                SearchComboBoxStatusSdelki1.Visibility = Windows.UI.Xaml.Visibility.Visible;

                TextBlockSearchNalogKvartal.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ComboBoxKvartalSdelkiSearch.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBlockSearchNalogKvartalYear.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchNalogKvartalYear.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchNalogKvartal.Visibility = Windows.UI.Xaml.Visibility.Visible;

                TextBlockSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Visible;
                TextBoxSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Visible;

                RazdelitelSearch.Visibility = Windows.UI.Xaml.Visibility.Visible;

                ButtonSearchOpen.Content = "-";
            }

            if (ButtonStatus == "-")
            {
                TextBlockSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchStatusSdelki.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchINN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBoxSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchINN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonSearchKontragent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchMyName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchDovorNumber.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchDogovorDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchNakladnajaDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchAktDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonShowWholeBase.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchINN.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchKontaktName.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchKontaktPhone.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonSearchStatusSdelki.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SearchComboBoxStatusSdelki1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBlockSearchNalogKvartal.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ComboBoxKvartalSdelkiSearch.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBlockSearchNalogKvartalYear.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchNalogKvartalYear.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchNalogKvartal.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                TextBlockSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                TextBoxSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ButtonSearchNalogYear.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                RazdelitelSearch.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ButtonSearchOpen.Content = "+";
            }
        }

        private void ButtonSearchKontragent_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KontragentName='" + TextBoxSearchKontragent.Text+"';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "Kontragent";
        }

        private void ButtonSearchMyName_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE MyName='" + TextBoxSearchMyName.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "MyName";
        }

        private void ButtonSearchDovorNumber_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE NomerDogovora='" + TextBoxSearchDovorNumber.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "DogovorNumber";
        }

        private void ButtonSearchDogovorDate_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataDogovora='" + TextBoxSearchDogovorDate.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "DogovorDate";
        }

        private void ButtonSearchNakladnajaDate_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataNakladnoj='" + TextBoxSearchNakladnajaDate.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "NakladnajaDate";
        }

        private void ButtonSearchAktDate_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE DataAkta='" + TextBoxSearchAktDate.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "AktDate";
        }

        private void ButtonShowWholeBase_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM=dbState["Year"] as string;
                string SN=dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ

            StatusSearch.Text = "ALL";

        }

        private void ButtonSummaItogoKlient_Click(object sender, RoutedEventArgs e)
        {
            double ItogoCena = 0;
            foreach (SdelkiData Sdelka in Sdelki)
            {
                try {
                    
                    double Cena = Convert.ToDouble(Sdelka.SUMMAITOGO);
                    ItogoCena = ItogoCena + Cena;
                    TextBlockSummaItogoKlientBuffer.Text = ItogoCena.ToString();
                }
                catch { StatusFile.Text = "Не удалось посчитать общие доходы для всех договоров. Приведите все суммы в числовой вид."; }
                
            }
            StatusFile.Text = "Общая стоимость доходов: "+TextBlockSummaItogoKlientBuffer.Text + " рублей";
        }

        private void ButtonSummaItogoRasxodi_Click(object sender, RoutedEventArgs e)
        {
            double ItogoCena = 0;
            foreach (SdelkiData Sdelka in Sdelki)
            {
                try
                {

                    double Cena = Convert.ToDouble(Sdelka.RASXODI);
                    ItogoCena = ItogoCena + Cena;
                    TextBlockSummaItogoRasxodiBuffer.Text = ItogoCena.ToString();
                }
                catch { StatusFile.Text = "Не удалось посчитать общие расходы для всех договоров. Приведите все суммы в числовой вид."; }

            }
            StatusFile.Text = "Общая стоимость расходов: " + TextBlockSummaItogoRasxodiBuffer.Text+ " рублей";
        }

        private void ButtonPribil_Click(object sender, RoutedEventArgs e)
        {
            double Pribil = 0;
            double Dohodi = Convert.ToDouble(TextBlockSummaItogoKlientBuffer.Text);
            double Rasxodi= Convert.ToDouble(TextBlockSummaItogoRasxodiBuffer.Text);
            Pribil = Dohodi - Rasxodi;
            StatusFile.Text = "Общая прибыль: " + Pribil.ToString() + " рублей";
        }

        private void ButonRasschitat_Click(object sender, RoutedEventArgs e)
        {
            int ItogoCena = 0;
            int ItogoPribil = 0;
            int ItogoRashodi = 0;

            foreach (SdelkiData Sdelka in Sdelki)
            {
                try
                {

                    int Cena = Convert.ToInt32(Sdelka.SUMMAITOGO);
                    ItogoCena = ItogoCena + Cena;
                    TextBlockSummaItogoKlientBuffer.Text = ItogoCena.ToString();

                    int Rashodi = Convert.ToInt32(Sdelka.RASXODI);
                    ItogoRashodi = ItogoRashodi + Rashodi;
                    TextBlockSummaItogoRasxodiBuffer.Text = ItogoRashodi.ToString();

                }
                catch { }

            }

            
            int Dohodi = Convert.ToInt32(TextBlockSummaItogoKlientBuffer.Text);
            int Rasxodi = Convert.ToInt32(TextBlockSummaItogoRasxodiBuffer.Text);
            ItogoPribil = Dohodi - Rasxodi;

            TextBlockPanelDoxodi.Text = TextBlockSummaItogoKlientBuffer.Text;
            TextBlockPanelRasxodi.Text = TextBlockSummaItogoRasxodiBuffer.Text;
            TextBlockPanelPribil.Text = ItogoPribil.ToString();



        }

        private async void ButtonRasschetPokazatelej_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ItogoCena = 0;
                double ItogoPribil = 0;
                double ItogoRashodi = 0;

                foreach (SdelkiData Sdelka in Sdelki)
                {
                    try
                    {

                        double Cena = Convert.ToDouble(Sdelka.SUMMAITOGO);
                        ItogoCena = ItogoCena + Cena;
                        TextBlockSummaItogoKlientBuffer.Text = ItogoCena.ToString();

                        double Rashodi = Convert.ToDouble(Sdelka.RASXODI);
                        ItogoRashodi = ItogoRashodi + Rashodi;
                        TextBlockSummaItogoRasxodiBuffer.Text = ItogoRashodi.ToString();

                    }
                    catch { }

                }


                double Dohodi = Convert.ToDouble(TextBlockSummaItogoKlientBuffer.Text);
                double Rasxodi = Convert.ToDouble(TextBlockSummaItogoRasxodiBuffer.Text);
                ItogoPribil = Dohodi - Rasxodi;

                TextBlockPanelDoxodi.Text = TextBlockSummaItogoKlientBuffer.Text;
                TextBlockPanelRasxodi.Text = TextBlockSummaItogoRasxodiBuffer.Text;
                TextBlockPanelPribil.Text = ItogoPribil.ToString();

                //ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ РАСЧЕТА НАЛОГА
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                string readSQL = "SELECT Nalog FROM NALOGSETTINGS WHERE ID=1;";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    string NalogStatusString = dbState["Nalog"] as string;
                    if (NalogStatusString == "6") { double NalogSumma = Dohodi * 0.06; double PribilChistaja = ItogoPribil - NalogSumma; TextBlockPanelNalog.Text = NalogSumma.ToString() + " ₽ (УСН 6%)"; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }

                    if (NalogStatusString == "15")
                    {
                        double NalogSumma = ItogoPribil * 0.15;
                        double NalogSummaOne = Dohodi * 0.01;
                        if (NalogSumma > NalogSummaOne) { double PribilChistaja = ItogoPribil - NalogSumma; TextBlockPanelNalog.Text = NalogSumma.ToString() + " ₽ (УСН 15%)"; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }
                        if (NalogSumma < NalogSummaOne) { double PribilChistaja = ItogoPribil - NalogSummaOne; TextBlockPanelNalog.Text = NalogSummaOne.ToString() + " ₽ (УСН 15%) - минимальный налог 1%"; StackPanelNalogWarning.Visibility = Windows.UI.Xaml.Visibility.Visible; TextBlockPanelNalogWarning.Text = "Рекомендуем тщательно перепроверить и обосновать расходы для налоговой инспекции в связи с минимальным налогом в 1% при УСН 15%."; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }

                    }
                }   
                //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ РАСЧЕТА НАЛОГА

                await ContentDialogPokazateli.ShowAsync();

            } //КОНЕЦ TRY
            catch { StatusFile.Text = "Не удалось рассчитать ключевые показатели. Заполните для всех сделок поля \"Расходы\", \"Доходы\" и выберите систему налогообложения в разделе\"Настройки\"."; }
        }

        private void ButtonSearchStatusSdelki_Click(object sender, RoutedEventArgs e)
        {
            if (Combo1011.IsSelected == true)
            {
            }


            if (Combo111.IsSelected == true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Сделано предложение';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "111";
            }

            if (Combo112.IsSelected == true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Заключен договор, выставлен счет';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "112";
            }

            if (Combo113.IsSelected==true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='В работе';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "113";
            }

            if (Combo114.IsSelected==true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Исполнена, ожидает подписания актов/накладных';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "114";
            }

            if (Combo115.IsSelected==true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Ожидание оплаты';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "115";
            }

            if (Combo116.IsSelected==true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Завершена';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "116";
            }

            if (Combo117.IsSelected==true)
            {
                this.Sdelki.Clear();
                SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
                
                //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Договор расторгнут';";
                ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
                while (dbState.Step() == SQLiteResult.ROW)
                {
                    //вот здесь вся проблема
                    int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                    //как получить IDSdelki

                    string SA = dbState["KontragentName"] as string;
                    string SB = dbState["MyName"] as string;
                    string SC = dbState["DataDogovora"] as string;
                    string SD = dbState["NomerDogovora"] as string;
                    string SE = dbState["DataNakladnoj"] as string;
                    string SF = dbState["DataAkta"] as string;
                    string SJ = dbState["RasxodiSumma"] as string;
                    string SK = dbState["ItogoSumma"] as string;
                    string SL = dbState["StatusSdelki"] as string;
                    string SM=dbState["Year"] as string;
                    string SN=dbState["Kvartal"] as string;

                    string SO = dbState["INN"] as string;
                    string SP = dbState["KONTAKTNAME"] as string;
                    string SQ = dbState["KONTAKTPHONE"] as string;

                    string SR = dbState["PRIMECHANIE"] as string;
                    //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                    Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

                }
                //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
                StatusSearch.Text = "117";
            }

            

        }

        private void ContentDialogPokazateli_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            StackPanelNalogWarning.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockPanelNalog.Text = "";
            TextBlockPanelNalogWarning.Text = "";
            TextBlockPanelDoxodi.Text = "0";
            TextBlockPanelNalog.Text = "0";
            TextBlockPanelPribil.Text = "0";
            TextBlockPanelRasxodi.Text = "0";
            ContentDialogPokazateli.Hide();
        }

        private void ContentDialogDelete_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            SdelkiData DeleteItem = (SdelkiData)SdelkiList.SelectedItem; //Sdelki+List -- выбор активного элемента коллекции


            //////////////////////////////////////////////////////////////////////////////////////
            SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL1 = "DELETE FROM SdelkiBase WHERE IdSdelki=" + DeleteItem.Id + ";";
            dbConnection1.Prepare(writeSQL1).Step();
            /////////////////////////////////////////////////////////////////////////////////////
            StatusFile.Text = "Удален объект: " + DeleteItem.KONTRNAME + " (номер договора " + DeleteItem.DOGOVORNUMBER + ")";
            Sdelki.Remove(DeleteItem);
            AddListSuggestBoxes();
        }

        private void ButtonSearchNalogYear_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE Year='" + TextBoxSearchNalogYear.Text + "' AND StatusSdelki='Завершена';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            StatusSearch.Text = "Year";
        }

        private void ButtonSearchNalogKvartal_Click(object sender, RoutedEventArgs e)
        {
            TextBlockComboSearchNalogKvartalBuffer.Text = "";

            if (ComboBoxKvartalSdelkiSearch.SelectedItem==ComboKvartalSearch1) { TextBlockComboSearchNalogKvartalBuffer.Text = "Первый квартал"; }
            if (ComboBoxKvartalSdelkiSearch.SelectedItem == ComboKvartalSearch2) { TextBlockComboSearchNalogKvartalBuffer.Text = "Второй квартал"; }
            if (ComboBoxKvartalSdelkiSearch.SelectedItem == ComboKvartalSearch3) { TextBlockComboSearchNalogKvartalBuffer.Text = "Третий квартал"; }
            if (ComboBoxKvartalSdelkiSearch.SelectedItem == ComboKvartalSearch4) { TextBlockComboSearchNalogKvartalBuffer.Text = "Четвертый квартал"; }
            if (ComboBoxKvartalSdelkiSearch.SelectedItem == ComboKvartalSearch0) { TextBlockComboSearchNalogKvartalBuffer.Text = "Выберите квартал"; }

            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE Year='" + TextBoxSearchNalogKvartalYear.Text + "' AND Kvartal='"+ TextBlockComboSearchNalogKvartalBuffer.Text + "' AND StatusSdelki='Завершена';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE=SR, IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            StatusSearch.Text = "NalogKvartal";
            TextBlockComboSearchNalogKvartalBuffer.Text = "";
        }

        private void TextBoxSearchKontragent_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchKontragent.Text.ToLower();
                var results = kontragentNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchKontragent.ItemsSource = results;
            }
        }

        private void TextBoxSearchMyName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchMyName.Text.ToLower();
                var results = myNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchMyName.ItemsSource = results;
            }
        }

        private void TextBoxSearchDovorNumber_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchDovorNumber.Text.ToLower();
                var results = dogovorNomerbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchDovorNumber.ItemsSource = results;
            }
        }

        private void TextBoxSearchDogovorDate_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchDogovorDate.Text.ToLower();
                var results = dogovorDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchDogovorDate.ItemsSource = results;
            }
        }

        private void TextBoxSearchNakladnajaDate_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchNakladnajaDate.Text.ToLower();
                var results = nakladnajaDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchNakladnajaDate.ItemsSource = results;
            }
        }

        private void TextBoxSearchAktDate_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchAktDate.Text.ToLower();
                var results = aktDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchAktDate.ItemsSource = results;
            }
        }

        private void TextBoxSearchNalogYear_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchNalogYear.Text.ToLower();
                var results = yearDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchNalogYear.ItemsSource = results;
            }
        }

        private void TextBoxSearchNalogKvartalYear_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchNalogKvartalYear.Text.ToLower();
                var results = yearDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchNalogKvartalYear.ItemsSource = results;
            }
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

        private void CheckBoxINN_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            INNVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockINNTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('13','INN','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxINN_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            INNVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockINNTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('13','INN','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxMyName_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            INAMEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockMyNameTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','INAME','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxMyName_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            INAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockMyNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('1','INAME','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxDogovorDate_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockDogovorDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','DOGOVORDATE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxDogovorDate_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            DOGOVORDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockDogovorDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('2','DOGOVORDATE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxDogovorNumber_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockDogovorNumberTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','DOGOVORNUMBER','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxDogovorNumber_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            DOGOVORNUMBERVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockDogovorNumberTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('3','DOGOVORNUMBER','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxNakladnajaDate_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockNakladnajaDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','NAKLADNAJADATE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxNakladnajaDate_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            NAKLADNAJADATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockNakladnajaDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('4','NAKLADNAJADATE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxAktDate_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            AKTDATEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockAktDateTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','AKTDATE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxAktDate_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            AKTDATEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockAktDateTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('5','AKTDATE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxStatusSdelki_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockStatusSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('8','STATUSSDELKI','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxStatusSdelki_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            STATUSSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockStatusSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('8','STATUSSDELKI','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxRasxodi_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            RASXODIVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockRasxodiTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','RASXODI','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxRasxodi_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            RASXODIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockRasxodiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('6','RASXODI','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxSummaItogo_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockSummaItogoTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','SUMMAITOGO','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxSummaItogo_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SUMMAITOGOVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockSummaItogoTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('7','SUMMAITOGO','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKontaktName_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockKontaktNameTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('11','KONTAKTNAME','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKontaktName_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KONTAKTNAMEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKontaktNameTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('11','KONTAKTNAME','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKontaktPhone_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockKontaktPhoneTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('12','KONTAKTPHONE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKontaktPhone_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KONTAKTPHONEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKontaktPhoneTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('12','KONTAKTPHONE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKvartalSdelki_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockKvartalSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('10','KVARTALSDELKI','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxKvartalSdelki_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            KVARTALSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockKvartalSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('10','KVARTALSDELKI','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxYearSdelki_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockYearSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('9','YEARSDELKI','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxYearSdelki_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            YEARSDELKIVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockYearSdelkiTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('9','YEARSDELKI','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void ButtonSearchINN_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE INN='" + TextBoxSearchINN.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["KONTAKTPHONE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            StatusSearch.Text = "INN";
        }

        private void ButtonSearchKontaktName_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KONTAKTNAME='" + TextBoxSearchKontaktName.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["KONTAKTPHONE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            StatusSearch.Text = "KONTAKTNAME";
        }

        private void ButtonSearchKontaktPhone_Click(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ
            string readSQL = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE KONTAKTPHONE='" + TextBoxSearchKontaktPhone.Text + "';";
            ISQLiteStatement dbState = dbConnection.Prepare(readSQL);
            while (dbState.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState["KontragentName"] as string;
                string SB = dbState["MyName"] as string;
                string SC = dbState["DataDogovora"] as string;
                string SD = dbState["NomerDogovora"] as string;
                string SE = dbState["DataNakladnoj"] as string;
                string SF = dbState["DataAkta"] as string;
                string SJ = dbState["RasxodiSumma"] as string;
                string SK = dbState["ItogoSumma"] as string;
                string SL = dbState["StatusSdelki"] as string;
                string SM = dbState["Year"] as string;
                string SN = dbState["Kvartal"] as string;

                string SO = dbState["INN"] as string;
                string SP = dbState["KONTAKTNAME"] as string;
                string SQ = dbState["KONTAKTPHONE"] as string;

                string SR = dbState["KONTAKTPHONE"] as string;

                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, IsVisibleAKTDATE = AKTDATEVisibility, IsVisibleDOGOVORDATE = DOGOVORDATEVisibility, IsVisibleDOGOVORNUMBER = DOGOVORNUMBERVisibility, IsVisibleINAME = INAMEVisibility, IsVisibleINN = INNVisibility, IsVisibleKONTAKTNAME = KONTAKTNAMEVisibility, IsVisibleKONTAKTPHONE = KONTAKTPHONEVisibility, IsVisibleKVARTALSDELKI = KVARTALSDELKIVisibility, IsVisibleNAKLADNAJADATE = NAKLADNAJADATEVisibility, IsVisibleRASXODI = RASXODIVisibility, IsVisibleSTATUSSDELKI = STATUSSDELKIVisibility, IsVisibleSUMMAITOGO = SUMMAITOGOVisibility, IsVisibleYEARSDELKI = YEARSDELKIVisibility, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ,PRIMECHANIE=SR,IsVisiblePRIMECHANIE=PRIMECHANIEVisibility });

            }
            StatusSearch.Text = "KONTAKTPHONE";
        }

        private void TextBoxSearchKontaktPhone_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchKontaktPhone.Text.ToLower();
                var results = KONTAKTPHONEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchKontaktPhone.ItemsSource = results;
            }
        }

        private void TextBoxSearchKontakName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchKontaktName.Text.ToLower();
                var results = KONTAKTNAMEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchKontaktName.ItemsSource = results;
            }
        }

        private void TextBoxSearchINN_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSearchINN.Text.ToLower();
                var results = INNbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSearchINN.ItemsSource = results;
            }
        }



        private void TextBoxKontrName1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKontrName1.Text.ToLower();
                var results = kontragentNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKontrName1.ItemsSource = results;
            }
        }

        private void TextBoxINN1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxINN1.Text.ToLower();
                var results = INNbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxINN1.ItemsSource = results;
            }
        }

        private void TextBoxMyName1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxMyName1.Text.ToLower();
                var results = myNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxMyName1.ItemsSource = results;
            }
        }

        private void TextBoxDogovorDate1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxDogovorDate1.Text.ToLower();
                var results = dogovorDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxDogovorDate1.ItemsSource = results;
            }
        }

        private void TextBoxDogovorNumber1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxDogovorNumber1.Text.ToLower();
                var results = dogovorNomerbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxDogovorNumber1.ItemsSource = results;
            }
        }

        private void TextBoxKONTAKTNAME1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKONTAKTNAME1.Text.ToLower();
                var results = KONTAKTNAMEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKONTAKTNAME1.ItemsSource = results;
            }
        }

        private void TextBoxKONTAKTPHONE1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKONTAKTPHONE1.Text.ToLower();
                var results = KONTAKTPHONEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKONTAKTPHONE1.ItemsSource = results;
            }
        }

        private void TextBoxSdelkaYear1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSdelkaYear1.Text.ToLower();
                var results = yearDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSdelkaYear1.ItemsSource = results;
            }
        }

        private void TextBoxKontrName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKontrName.Text.ToLower();
                var results = kontragentNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKontrName.ItemsSource = results;
            }
        }

        private void TextBoxINN_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxINN.Text.ToLower();
                var results = INNbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxINN.ItemsSource = results;
            }
        }

        private void TextBoxMyName_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxMyName.Text.ToLower();
                var results = myNamebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxMyName.ItemsSource = results;
            }
        }

        private void TextBoxDogovorDate_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxDogovorDate.Text.ToLower();
                var results = dogovorDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxDogovorDate.ItemsSource = results;
            }
        }

        private void TextBoxDogovorNumber_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxDogovorNumber.Text.ToLower();
                var results = dogovorNomerbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxDogovorNumber.ItemsSource = results;
            }
        }

        private void TextBoxKONTAKTNAME_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKONTAKTNAME.Text.ToLower();
                var results = KONTAKTNAMEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKONTAKTNAME.ItemsSource = results;
            }
        }

        private void TextBoxKONTAKTPHONE_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxKONTAKTPHONE.Text.ToLower();
                var results = KONTAKTPHONEbox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxKONTAKTPHONE.ItemsSource = results;
            }
        }

        private void TextBoxSdelkaYear_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.CheckCurrent())
            {
                var term = TextBoxSdelkaYear.Text.ToLower();
                var results = yearDatebox.Where(i => i.ToLower().Contains(term)).ToList();
                TextBoxSdelkaYear.ItemsSource = results;
            }
        }

        private void CheckBoxPrimechanie_Checked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            PRIMECHANIEVisibility = Windows.UI.Xaml.Visibility.Visible;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Visible;
            if (Razdelitel1.Width < 2400)
            {
                double S = 160;
                Razdelitel1.Width = Razdelitel1.Width + S;
                Razdelitel2.Width = Razdelitel2.Width + S;
                Razdelitel3.Width = Razdelitel3.Width + S;
            }

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('14','PRIMECHANIE','VISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }

        private void CheckBoxPrimechanie_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Sdelki.Clear();
            PRIMECHANIEVisibility = Windows.UI.Xaml.Visibility.Collapsed;
            TextBlockPrimechanieTable.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            double S = 160;
            Razdelitel1.Width = Razdelitel1.Width - S;
            Razdelitel2.Width = Razdelitel2.Width - S;
            Razdelitel3.Width = Razdelitel3.Width - S;

            ReadDataBase();

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string writeSQL = "INSERT OR REPLACE INTO SDELKIVISIBILITYSETTINGS ([ID],[OBJECT],[VISIBILITY]) VALUES ('14','PRIMECHANIE','UNVISIBLE');";
            dbConnection.Prepare(writeSQL).Step();
        }
    }
}
