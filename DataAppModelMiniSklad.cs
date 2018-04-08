using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppModelsMiniSklad
{
    public class SkladData
    {
        public int Id { get; set; }
        public string TOVARNAME { get; set; }
        public string EDIZM { get; set; }
        public string MYEDPRICE { get; set; } //закупочная цена
        public string SALEEDPRICE { get; set; } //рыночная цена 
        public string KOLICHESTVO { get; set; }
        public string PRIMECHANIE { get; set; }
        public string NKOLICHESTVO { get; set; }

        public string ARTIKUL { get; set; } //ДОБАВИТЬ В БАЗУ

        public Windows.UI.Xaml.Visibility IsVisiblePRIMECHANIE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleARTIKUL { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleEDIZM { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleMYEDPRICE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleSALEEDPRICE { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleKOLICHESTVO { get; set; }
        public Windows.UI.Xaml.Visibility IsVisibleNKOLICHESTVO { get; set; }
    }
}
