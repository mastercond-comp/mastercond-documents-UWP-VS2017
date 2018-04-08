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
using DataAppModelQuickPage;
using SQLitePCL;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace Мастерконд.Документы
{

    public sealed partial class QuickPage : Page
    {

        public ObservableCollection<ZSkladData> ZTovari { get; set; }
        public ObservableCollection<SkladData> Tovari { get; set; }
        public ObservableCollection<SdelkiData> Sdelki { get; set; }
        public ObservableCollection<ZSdelkiData> ZSdelki { get; set; }
        public ObservableCollection<NZSdelkiData> NZSdelki { get; set; }

        public QuickPage()
        {
            this.InitializeComponent();

            Tovari = new ObservableCollection<SkladData>
            {
            };

            ZTovari = new ObservableCollection<ZSkladData>
            {
            };

            Sdelki = new ObservableCollection<SdelkiData>
            {
            };

            ZSdelki = new ObservableCollection<ZSdelkiData>
            {
            };

            NZSdelki = new ObservableCollection<NZSdelkiData>
            {
            };

            #region ОБЕСПЕЧИВАЕМ СОВМЕСТИМОСТЬ С ПРЕДЫДУЩИМИ ВЕРСИЯМИ ПРИЛОЖЕНИЯ

            SQLitePCL.SQLiteConnection dbConnection = new SQLiteConnection("sdelkidatabase.db");
            string addSQL1 = @"CREATE TABLE IF NOT EXISTS SkladBase (IDTovara Integer Primary Key Autoincrement NOT NULL, TovarName Varchar(255), Kolichestvo Varchar(255), EdIzmTovara Varchar(200), MyCenaEd Varchar(200), SaleCenaEd Varchar(200), Primechanie Varchar(200), NKolichestvo Varchar(255));";
            dbConnection.Prepare(addSQL1).Step();

            string addSQL = @"CREATE TABLE IF NOT EXISTS SdelkiBase (IDSdelki Integer Primary Key Autoincrement NOT NULL, KontragentName Varchar(255), MyName Varchar(255), DataDogovora Varchar(200), NomerDogovora Varchar(200), DataNakladnoj Varchar(200), DataAkta Varchar(200), RasxodiSumma Varchar(200), ItogoSumma Varchar(200), StatusSdelki Varchar(200));";
            dbConnection.Prepare(addSQL).Step();

            string addSQL0 = @"CREATE TABLE IF NOT EXISTS NALOGSETTINGS (ID Integer Primary Key NOT NULL, Nalog Varchar(255));";
            dbConnection.Prepare(addSQL0).Step();

            try {
                string addSQL5 = "INSERT INTO NALOGSETTINGS([ID],[Nalog]) VALUES('1','6');";
                dbConnection.Prepare(addSQL5).Step();
            }
            catch { }

            string addSQL4 = @"CREATE TABLE IF NOT EXISTS PRINTINGSETTINGS (ID Integer Primary Key NOT NULL, Printing Varchar(255));";
            dbConnection.Prepare(addSQL4).Step();

            try {
                string addSQL6 = "INSERT INTO PRINTINGSETTINGS([ID],[Printing]) VALUES('1','HTML');";
                dbConnection.Prepare(addSQL6).Step();
            }
            catch { }

            //ДОБАВЛЯЕМ СТОЛБЕЦ YEAR
            try
            {
                string addSQL2 = "ALTER TABLE SdelkiBase ADD COLUMN Year Varchar(255);";
                dbConnection.Prepare(addSQL2).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ YEAR

            //ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL
            try
            {
                string addSQL3 = "ALTER TABLE SdelkiBase ADD COLUMN Kvartal Varchar(255);";
                dbConnection.Prepare(addSQL3).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL

            //ДОБАВЛЯЕМ СТОЛБЕЦ ARTIKUL
            try
            {
                string addSQL7 = "ALTER TABLE SkladBase ADD COLUMN Artikul Varchar(255) DEFAULT '' NOT NULL;"; //ВАЖНО ДЛЯ ПОИСКА ПО AUTOSUGGESTBOXa, ЧТОБЫ НЕ NULL !!!
                dbConnection.Prepare(addSQL7).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ ARTIKUL

            //ДОБАВЛЯЕМ СТОЛБЕЦ YEAR
            try
            {
                string addSQL8 = "ALTER TABLE SdelkiBase ADD COLUMN Year Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL8).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ YEAR

            //ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL
            try
            {
                string addSQL9 = "ALTER TABLE SdelkiBase ADD COLUMN Kvartal Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL9).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KVARTAL

            //ДОБАВЛЯЕМ СТОЛБЕЦ INN
            try
            {
                string addSQL10 = "ALTER TABLE SdelkiBase ADD COLUMN INN Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL10).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ INN

            //ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTNAME
            try
            {
                string addSQL11 = "ALTER TABLE SdelkiBase ADD COLUMN KONTAKTNAME Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL11).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTNAME

            //ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTPHONE
            try
            {
                string addSQL12 = "ALTER TABLE SdelkiBase ADD COLUMN KONTAKTPHONE Varchar(255) DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL12).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ KONTAKTPHONE

            //ДОБАВЛЯЕМ СТОЛБЕЦ PRIMECHANIE
            try
            {
                string addSQL13 = "ALTER TABLE SdelkiBase ADD COLUMN PRIMECHANIE TEXT DEFAULT '' NOT NULL;";
                dbConnection.Prepare(addSQL13).Step();
            }
            catch { }
            //КОНЕЦ ДОБАВЛЯЕМ СТОЛБЕЦ PRIMECHANIE
            #endregion

            //ЗАПОЛНЯЕМ РАЗДЕЛ ЗАКАНЧИВАЮЩИЕСЯ ТОВАРЫ
            this.Tovari.Clear();
            TextBlockSkladTovariSumma.Text = "0";
            SQLitePCL.SQLiteConnection dbConnection1 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL1 = "SELECT IDTovara,TovarName,Kolichestvo,NKolichestvo,EdIzmTovara,MyCenaEd,SaleCenaEd,Primechanie,Artikul FROM SkladBase;";
            ISQLiteStatement dbState1 = dbConnection1.Prepare(readSQL1);
            while (dbState1.Step() == SQLiteResult.ROW)
            {
                int SNN = Convert.ToInt32(dbState1["IDTovara"]);
                string SA = dbState1["TovarName"] as string;
                string SB = dbState1["Kolichestvo"] as string;
                string SN = dbState1["NKolichestvo"] as string;
                string SK = dbState1["MyCenaEd"] as string;
                string SE = dbState1["EdIzmTovara"] as string;
                string SS = dbState1["SaleCenaEd"] as string;

                string SF = dbState1["Primechanie"] as string;
                string SM = dbState1["Artikul"] as string;
                try
                {
                    double M = Convert.ToDouble(dbState1["Kolichestvo"]);
                    double MN = Convert.ToDouble(dbState1["NKolichestvo"]);
                    if (MN > M)
                    {
                        Tovari.Add(new SkladData { TOVARNAME = SA, KOLICHESTVO = SB, EDIZM=SE,NKOLICHESTVO=SN,MYEDPRICE=SK,PRIMECHANIE=SF,SALEEDPRICE=SS,Id=SNN,ARTIKUL=SM });
                        double S = Convert.ToDouble(TextBlockSkladTovariSumma.Text);
                        double S1 = Convert.ToDouble(dbState1["MyCenaEd"]);
                        double S2 = Convert.ToDouble(dbState1["Kolichestvo"]);
                        double S3 = Convert.ToDouble(dbState1["NKolichestvo"]);
                        TextBlockSkladTovariSumma.Text = (S + S1*(S3-S2)).ToString();
                    }
                }
                catch { }

            }
            //КОНЕЦ ЗАПОЛНЯЕМ РАЗДЕЛ ЗАКАНЧИВАЮЩИЕСЯ ТОВАРЫ


            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О ВСЕХ СДЕЛКАХ
            string readSQL4 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase;";
            ISQLiteStatement dbState4 = dbConnection.Prepare(readSQL4);
            while (dbState4.Step() == SQLiteResult.ROW)
            {
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState4["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState4["KontragentName"] as string;
                string SB = dbState4["MyName"] as string;
                string SC = dbState4["DataDogovora"] as string;
                string SD = dbState4["NomerDogovora"] as string;
                string SE = dbState4["DataNakladnoj"] as string;
                string SF = dbState4["DataAkta"] as string;
                string SJ = dbState4["RasxodiSumma"] as string;
                string SK = dbState4["ItogoSumma"] as string;
                string SL = dbState4["StatusSdelki"] as string;
                string SM = dbState4["Year"] as string;
                string SN = dbState4["Kvartal"] as string;

                string SO = dbState4["INN"] as string;
                string SP = dbState4["KONTAKTNAME"] as string;
                string SQ = dbState4["KONTAKTPHONE"] as string;

                string SR = dbState4["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                Sdelki.Add(new SdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE = SR, VALUTA= "₽" });
            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О ВСЕХ СДЕЛКАХ

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

               
                SQLitePCL.SQLiteConnection dbConnection3 = new SQLiteConnection("sdelkidatabase.db");
                string readSQL3 = "SELECT Nalog FROM NALOGSETTINGS WHERE ID=1;";
                ISQLiteStatement dbState3 = dbConnection3.Prepare(readSQL3);
                while (dbState3.Step() == SQLiteResult.ROW)
                {
                    string NalogStatusString = dbState3["Nalog"] as string;
                    if (NalogStatusString == "6") { double NalogSumma = Dohodi * 0.06; double PribilChistaja = ItogoPribil - NalogSumma; TextBlockPanelNalog.Text = NalogSumma.ToString() + " ₽ (УСН 6%)"; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }

                    if (NalogStatusString == "15")
                    {
                        double NalogSumma = ItogoPribil * 0.15;
                        double NalogSummaOne = Dohodi * 0.01;
                        if (NalogSumma > NalogSummaOne) { double PribilChistaja = ItogoPribil - NalogSumma; TextBlockPanelNalog.Text = NalogSumma.ToString() + " ₽ (УСН 15%)"; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }
                        if (NalogSumma < NalogSummaOne) { double PribilChistaja = ItogoPribil - NalogSummaOne; TextBlockPanelNalog.Text = NalogSummaOne.ToString() + " ₽ (УСН 15%) - минимальный налог 1%"; StackPanelNalogWarning.Visibility = Windows.UI.Xaml.Visibility.Visible; TextBlockPanelNalogWarning.Text = "Рекомендуем тщательно перепроверить и обосновать расходы для налоговой инспекции в связи с минимальным налогом в 1% при УСН 15%."; TextBlockPanelPribilAfterNalogi.Text = PribilChistaja.ToString(); }

                    }
                }
            }

            //КОНЕЦ ПОЛУЧЕНИЕ ДАННЫХ ИЗ БД ДЛЯ РАСЧЕТА НАЛОГА
            catch { }

            this.ZSdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection5 = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О ЗАВЕРШЕННЫХ СДЕЛКАХ
            TextBlockZSdelkiSumma.Text = "0";
            TextBlockZSdelkiSummaPribil.Text = "0";
            string readSQL5 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki='Завершена';";
            ISQLiteStatement dbState5 = dbConnection5.Prepare(readSQL5);
            while (dbState5.Step() == SQLiteResult.ROW)
            {
                double S = Convert.ToDouble(TextBlockZSdelkiSumma.Text);
                double Spr = Convert.ToDouble(TextBlockZSdelkiSummaPribil.Text);
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState5["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState5["KontragentName"] as string;
                string SB = dbState5["MyName"] as string;
                string SC = dbState5["DataDogovora"] as string;
                string SD = dbState5["NomerDogovora"] as string;
                string SE = dbState5["DataNakladnoj"] as string;
                string SF = dbState5["DataAkta"] as string;
                string SJ = dbState5["RasxodiSumma"] as string;
                string SK = dbState5["ItogoSumma"] as string;
                string SL = dbState5["StatusSdelki"] as string;
                string SM = dbState5["Year"] as string;
                string SN = dbState5["Kvartal"] as string;

                string SO = dbState5["INN"] as string;
                string SP = dbState5["KONTAKTNAME"] as string;
                string SQ = dbState5["KONTAKTPHONE"] as string;

                string SR = dbState5["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                ZSdelki.Add(new ZSdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE = SR, VALUTA = "₽" });
                double S1 = Convert.ToDouble(dbState5["ItogoSumma"]);
                double Spr1 = Convert.ToDouble(dbState5["RasxodiSumma"]);
                TextBlockZSdelkiSumma.Text = (S + S1).ToString();
                TextBlockZSdelkiSummaPribil.Text = (Spr + S1 - Spr1).ToString();
            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О ЗАВЕРШЕННЫХ СДЕЛКАХ

            this.NZSdelki.Clear();
            SQLitePCL.SQLiteConnection dbConnection6 = new SQLiteConnection("sdelkidatabase.db");

            //ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О НЕЗАВЕРШЕННЫХ СДЕЛКАХ
            TextBlockNZSdelkiSumma.Text = "0";
            TextBlockNZSdelkiSummaPribil.Text = "0";
            string readSQL6 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal,INN,KONTAKTNAME,KONTAKTPHONE,PRIMECHANIE FROM SdelkiBase WHERE StatusSdelki<>'Завершена';";
            ISQLiteStatement dbState6 = dbConnection6.Prepare(readSQL6);
            while (dbState6.Step() == SQLiteResult.ROW)
            {
                double S = Convert.ToDouble(TextBlockNZSdelkiSumma.Text);
                double Spr = Convert.ToDouble(TextBlockNZSdelkiSummaPribil.Text);
                //вот здесь вся проблема
                int SNN = Convert.ToInt32(dbState6["IDSdelki"]);
                //как получить IDSdelki

                string SA = dbState6["KontragentName"] as string;
                string SB = dbState6["MyName"] as string;
                string SC = dbState6["DataDogovora"] as string;
                string SD = dbState6["NomerDogovora"] as string;
                string SE = dbState6["DataNakladnoj"] as string;
                string SF = dbState6["DataAkta"] as string;
                string SJ = dbState6["RasxodiSumma"] as string;
                string SK = dbState6["ItogoSumma"] as string;
                string SL = dbState6["StatusSdelki"] as string;
                string SM = dbState6["Year"] as string;
                string SN = dbState6["Kvartal"] as string;

                string SO = dbState6["INN"] as string;
                string SP = dbState6["KONTAKTNAME"] as string;
                string SQ = dbState6["KONTAKTPHONE"] as string;

                string SR = dbState6["PRIMECHANIE"] as string;
                //Phones.Add(new Phone { Title = title, Company = company, Id = Phones.Count + 1 });
                NZSdelki.Add(new NZSdelkiData { Id = SNN, STATUSSDELKI = SL, INAME = SB, KONTRNAME = SA, DOGOVORDATE = SC, DOGOVORNUMBER = SD, AKTDATE = SF, NAKLADNAJADATE = SE, RASXODI = SJ, SUMMAITOGO = SK, KVARTALSDELKI = SN, YEARSDELKI = SM, INN = SO, KONTAKTNAME = SP, KONTAKTPHONE = SQ, PRIMECHANIE = SR, VALUTA = "₽" });
                double Spr1 = Convert.ToDouble(dbState6["RasxodiSumma"]);
                double S1 = Convert.ToDouble(dbState6["ItogoSumma"]);
                TextBlockNZSdelkiSumma.Text = (S + S1).ToString();
                TextBlockNZSdelkiSummaPribil.Text = (Spr + S1-Spr1).ToString();
            }
            //КОНЕЦ ПРОЧИТАТЬ ИЗ БАЗЫ ВСЕ ДАННЫЕ О НЕЗАВЕРШЕННЫХ СДЕЛКАХ






            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (без статуса)
            SQLitePCL.SQLiteConnection dbConnection7 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL7 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Выберите статус';";
            ISQLiteStatement dbState7 = dbConnection7.Prepare(readSQL7);
            BufferStatus1.Text = "0";
            while (dbState7.Step() == SQLiteResult.ROW)
            {
               int N= Convert.ToInt32(BufferStatus1.Text);
                N = N + 1;
                BufferStatus1.Text = N.ToString();
            }

            string readSQL71 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='';";
            ISQLiteStatement dbState71 = dbConnection7.Prepare(readSQL71);
            while (dbState71.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus1.Text);
                N = N + 1;
                BufferStatus1.Text = N.ToString();
            }
            TextBlockSdelkaStatus1.Text = BufferStatus1.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК(без статуса)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Сделано предложение)
            SQLitePCL.SQLiteConnection dbConnection8 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL8 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Сделано предложение';";
            ISQLiteStatement dbState8 = dbConnection8.Prepare(readSQL8);
            BufferStatus2.Text = "0";
            while (dbState8.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus2.Text);
                N = N + 1;
                BufferStatus2.Text = N.ToString();
            }
            TextBlockSdelkaStatus2.Text = BufferStatus2.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Сделано предложение)

            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Заключен договор, выставлен счет)
            SQLitePCL.SQLiteConnection dbConnection9 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL9 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Заключен договор, выставлен счет';";
            ISQLiteStatement dbState9 = dbConnection9.Prepare(readSQL9);
            BufferStatus3.Text = "0";
            while (dbState9.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus3.Text);
                N = N + 1;
                BufferStatus3.Text = N.ToString();
            }
            TextBlockSdelkaStatus3.Text = BufferStatus3.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Заключен договор, выставлен счет)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (В работе)
            SQLitePCL.SQLiteConnection dbConnection10 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL10 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='В работе';";
            ISQLiteStatement dbState10 = dbConnection10.Prepare(readSQL10);
            BufferStatus4.Text = "0";
            while (dbState10.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus4.Text);
                N = N + 1;
                BufferStatus4.Text = N.ToString();
            }
            TextBlockSdelkaStatus4.Text = BufferStatus4.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (В работе)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Исполнена, ожидает подписания актов/накладных)
            SQLitePCL.SQLiteConnection dbConnection11 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL11 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Исполнена, ожидает подписания актов/накладных';";
            ISQLiteStatement dbState11 = dbConnection11.Prepare(readSQL11);
            BufferStatus5.Text = "0";
            while (dbState11.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus5.Text);
                N = N + 1;
                BufferStatus5.Text = N.ToString();
            }
            TextBlockSdelkaStatus5.Text = BufferStatus5.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Исполнена, ожидает подписания актов/накладных)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Ожидание оплаты)
            SQLitePCL.SQLiteConnection dbConnection12 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL12 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Ожидание оплаты';";
            ISQLiteStatement dbState12 = dbConnection12.Prepare(readSQL12);
            BufferStatus6.Text = "0";
            while (dbState12.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus6.Text);
                N = N + 1;
                BufferStatus6.Text = N.ToString();
            }
            TextBlockSdelkaStatus6.Text = BufferStatus6.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Ожидание оплаты)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Завершена)
            SQLitePCL.SQLiteConnection dbConnection13 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL13 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Завершена';";
            ISQLiteStatement dbState13 = dbConnection13.Prepare(readSQL13);
            BufferStatus7.Text = "0";
            while (dbState13.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus7.Text);
                N = N + 1;
                BufferStatus7.Text = N.ToString();
            }
            TextBlockSdelkaStatus7.Text = BufferStatus7.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Завершена)


            //ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Договор расторгнут)
            SQLitePCL.SQLiteConnection dbConnection14 = new SQLiteConnection("sdelkidatabase.db");
            string readSQL14 = "SELECT IDSdelki,KontragentName,MyName,DataDogovora,NomerDogovora,DataNakladnoj,DataAkta,RasxodiSumma,ItogoSumma,StatusSdelki,Year,Kvartal FROM SdelkiBase WHERE StatusSdelki='Договор расторгнут';";
            ISQLiteStatement dbState14 = dbConnection14.Prepare(readSQL14);
            BufferStatus8.Text = "0";
            while (dbState14.Step() == SQLiteResult.ROW)
            {
                int N = Convert.ToInt32(BufferStatus8.Text);
                N = N + 1;
                BufferStatus8.Text = N.ToString();
            }
            TextBlockSdelkaStatus8.Text = BufferStatus8.Text;
            //КОНЕЦ ЗАПОЛНЕНИЕ ПАНЕЛИ СТАТУСОВ СДЕЛОК (Договор расторгнут)

            
            
            //ЧАРТ (САМ ВСЁ ВЫСЧИТЫВАЕТ - ЕМУ ТОЛЬКО ЦИФРЫ ПОДАВАЙ)
            int f1 = Convert.ToInt32(BufferStatus1.Text);
            int f2 = Convert.ToInt32(BufferStatus2.Text);
            int f3 = Convert.ToInt32(BufferStatus3.Text);
            int f4 = Convert.ToInt32(BufferStatus4.Text);
            int f5 = Convert.ToInt32(BufferStatus5.Text);
            int f6 = Convert.ToInt32(BufferStatus6.Text);
            int f7 = Convert.ToInt32(BufferStatus7.Text);
            int f8 = Convert.ToInt32(BufferStatus8.Text);

            List<ChartData> ChartInfo = new List<ChartData>();
            ChartInfo.Add(new ChartData() { DataName = "Без статуса", DataValue = f1 });
            ChartInfo.Add(new ChartData() { DataName = "Сделано предложение", DataValue = f2 });
            ChartInfo.Add(new ChartData() { DataName = "Заключен договор", DataValue = f3 });
            ChartInfo.Add(new ChartData() { DataName = "В работе", DataValue = f4 });
            ChartInfo.Add(new ChartData() { DataName = "Исполнена,ожидает", DataValue = f5 });
            ChartInfo.Add(new ChartData() { DataName = "Ожидание оплаты", DataValue = f6 });
            ChartInfo.Add(new ChartData() { DataName = "Завершена", DataValue = f7 });
            ChartInfo.Add(new ChartData() { DataName = "Договор расторгнут", DataValue = f8 });
            (PieChart.Series[0] as PieSeries).ItemsSource = ChartInfo;
            //КОНЕЦ ЧАРТ
           

        }

        public class ChartData
        {
            public string DataName { get; set; }
            public int DataValue { get; set; }
        }


        private void HelpBoxTovariButton_Click(object sender, RoutedEventArgs e)
        {
            HelpBoxTovari.Hide();
        }

        private async void ZSdelkiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextBlockCDKontrName.Text = "";
            TextBlockCDINN.Text = "";
            TextBlockCDDataAkta.Text = "";
            TextBlockCDDataDogovora.Text = "";
            TextBlockCDDataNakladnoj.Text = "";
            TextBlockCDGodSdelki.Text = "";
            TextBlockCDItogo.Text = "";
            TextBlockCDKontakt.Text = "";
            TextBlockCDKontaktPhone.Text = "";
            TextBlockCDKvartalSdelki.Text = "";
            TextBlockCDMyName.Text = "";
            TextBlockCDNomerDogovora.Text = "";
            TextBlockCDPrimechanie.Text = "";
            TextBlockCDRasxodi.Text = "";
            TextBlockCDStatusSdelki.Text = "";


            ZSdelkiData selectedZSdelka = (ZSdelkiData)e.ClickedItem;

            int NumberID = selectedZSdelka.Id;


            try
            {

                TextBlockCDKontrName.Text = selectedZSdelka.KONTRNAME;
                TextBlockCDINN.Text = selectedZSdelka.INN;
                TextBlockCDDataAkta.Text = selectedZSdelka.AKTDATE;
                TextBlockCDDataDogovora.Text = selectedZSdelka.DOGOVORDATE;
                TextBlockCDDataNakladnoj.Text = selectedZSdelka.NAKLADNAJADATE;
                TextBlockCDGodSdelki.Text = selectedZSdelka.YEARSDELKI;
                TextBlockCDItogo.Text = selectedZSdelka.SUMMAITOGO+ " ₽";
                TextBlockCDKontakt.Text = selectedZSdelka.KONTAKTNAME;
                TextBlockCDKontaktPhone.Text = selectedZSdelka.KONTAKTPHONE;
                TextBlockCDKvartalSdelki.Text = selectedZSdelka.KVARTALSDELKI;
                TextBlockCDMyName.Text = selectedZSdelka.INAME;
                TextBlockCDNomerDogovora.Text = selectedZSdelka.DOGOVORNUMBER;
                TextBlockCDPrimechanie.Text = selectedZSdelka.PRIMECHANIE;
                TextBlockCDRasxodi.Text = selectedZSdelka.RASXODI+ " ₽";
                TextBlockCDStatusSdelki.Text = selectedZSdelka.STATUSSDELKI;

            }
            catch { }

            await ContentDialogZavershennieSdelki.ShowAsync();
        }

        private async void TovariList_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextBlockCDTovarName.Text = "";
            TextBlockCDTovarArtikul.Text = "";
            TextBlockCDTovarEdIzm.Text = "";
            TextBlockCDTovarKlientCena.Text = "";
            TextBlockCDTovarKolvo.Text = "";
            TextBlockCDTovarNKolvo.Text = "";
            TextBlockCDTovarPrimechanie.Text = "";
            TextBlockCDTovarZCena.Text = "";


            SkladData selectedTovar = (SkladData)e.ClickedItem;

            int NumberID = selectedTovar.Id;


            try
            {

                TextBlockCDTovarName.Text = selectedTovar.TOVARNAME;
                TextBlockCDTovarArtikul.Text = selectedTovar.ARTIKUL;
                TextBlockCDTovarEdIzm.Text = selectedTovar.EDIZM;
                TextBlockCDTovarKlientCena.Text = selectedTovar.SALEEDPRICE + " ₽";
                TextBlockCDTovarKolvo.Text = selectedTovar.KOLICHESTVO;
                TextBlockCDTovarNKolvo.Text = selectedTovar.NKOLICHESTVO;
                TextBlockCDTovarPrimechanie.Text = selectedTovar.PRIMECHANIE;
                TextBlockCDTovarZCena.Text = selectedTovar.MYEDPRICE + " ₽";
            }
            catch { }


            await ContentDialogZTovari.ShowAsync();
        }

        private async void NZSdelkiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            TextBlockCDKontrName1.Text = "";
            TextBlockCDINN1.Text = "";
            TextBlockCDDataAkta1.Text = "";
            TextBlockCDDataDogovora1.Text = "";
            TextBlockCDDataNakladnoj1.Text = "";
            TextBlockCDGodSdelki1.Text = "";
            TextBlockCDItogo1.Text = "";
            TextBlockCDKontakt1.Text = "";
            TextBlockCDKontaktPhone1.Text = "";
            TextBlockCDKvartalSdelki1.Text = "";
            TextBlockCDMyName1.Text = "";
            TextBlockCDNomerDogovora1.Text = "";
            TextBlockCDPrimechanie1.Text = "";
            TextBlockCDRasxodi1.Text = "";
            TextBlockCDStatusSdelki1.Text = "";


            NZSdelkiData selectedNZSdelka = (NZSdelkiData)e.ClickedItem;

            int NumberID = selectedNZSdelka.Id;


            try
            {

                TextBlockCDKontrName1.Text = selectedNZSdelka.KONTRNAME;
                TextBlockCDINN1.Text = selectedNZSdelka.INN;
                TextBlockCDDataAkta1.Text = selectedNZSdelka.AKTDATE;
                TextBlockCDDataDogovora1.Text = selectedNZSdelka.DOGOVORDATE;
                TextBlockCDDataNakladnoj1.Text = selectedNZSdelka.NAKLADNAJADATE;
                TextBlockCDGodSdelki1.Text = selectedNZSdelka.YEARSDELKI;
                TextBlockCDItogo1.Text = selectedNZSdelka.SUMMAITOGO + " ₽";
                TextBlockCDKontakt1.Text = selectedNZSdelka.KONTAKTNAME;
                TextBlockCDKontaktPhone1.Text = selectedNZSdelka.KONTAKTPHONE;
                TextBlockCDKvartalSdelki1.Text = selectedNZSdelka.KVARTALSDELKI;
                TextBlockCDMyName1.Text = selectedNZSdelka.INAME;
                TextBlockCDNomerDogovora1.Text = selectedNZSdelka.DOGOVORNUMBER;
                TextBlockCDPrimechanie1.Text = selectedNZSdelka.PRIMECHANIE;
                TextBlockCDRasxodi1.Text = selectedNZSdelka.RASXODI + " ₽";
                TextBlockCDStatusSdelki1.Text = selectedNZSdelka.STATUSSDELKI;

            }
            catch { }

            await ContentDialogNZavershennieSdelki.ShowAsync();
        }
    }
}
