using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppModels
{
    public class SdelkiData
    {
        public int Id { get; set; }
        public string INAME { get; set; }
        public string KONTRNAME { get; set; }
        public string DOGOVORDATE { get; set; }
        public string DOGOVORNUMBER { get; set; }
        public string NAKLADNAJADATE { get; set; }
        public string AKTDATE { get; set; }
        public string SUMMAITOGO { get; set; }
        public string RASXODI { get; set; }
        public string STATUSSDELKI { get; set; }
        public string YEARSDELKI { get; set; }
        public string KVARTALSDELKI { get; set; }


        public string KONTAKTNAME { get; set; } //ДОБАВИТЬ В БАЗУ
        public string KONTAKTPHONE { get; set; } //ДОБАВИТЬ В БАЗУ
        public string INN { get; set; } //ДОБАВИТЬ В БАЗУ

        public string PRIMECHANIE { get; set; } //ДОБАВИТЬ В БАЗУ

        public Windows.UI.Xaml.Visibility IsVisibleINAME { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleDOGOVORDATE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleDOGOVORNUMBER { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleNAKLADNAJADATE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleAKTDATE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleSUMMAITOGO { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleRASXODI { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleSTATUSSDELKI { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleYEARSDELKI { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleKVARTALSDELKI { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleKONTAKTNAME { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleKONTAKTPHONE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleINN { get; set; }

        public Windows.UI.Xaml.Visibility IsVisiblePRIMECHANIE { get; set; }


    }

    public class PRIXOD // ПРИХОДЫ
    {
        public int Id { get; set; }
        public int IDD { get; set; }
        public string NAME { get; set; }
        public string DATA { get; set; }
        public string SUMMA { get; set; }
        public string PRIMECHANIE { get; set; }
    }

    public class RASXOD //РАСХОДЫ
    {
        public int Id { get; set; }
        public int IDD { get; set; }
        public string NAME { get; set; }
        public string DATA { get; set; }
        public string SUMMA { get; set; }
        public string PRIMECHANIE { get; set; }
    }

}
