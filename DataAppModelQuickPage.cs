using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppModelQuickPage
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
        public string VALUTA { get; set; }

        public string KONTAKTNAME { get; set; } //ДОБАВИТЬ В БАЗУ
        public string KONTAKTPHONE { get; set; } //ДОБАВИТЬ В БАЗУ
        public string INN { get; set; } //ДОБАВИТЬ В БАЗУ

        public string PRIMECHANIE { get; set; } //ДОБАВИТЬ В БАЗУ
    }

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
        public string ARTIKUL { get; set; }
    }

    public class ZSdelkiData
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
        public string VALUTA { get; set; }

        public string KONTAKTNAME { get; set; } //ДОБАВИТЬ В БАЗУ
        public string KONTAKTPHONE { get; set; } //ДОБАВИТЬ В БАЗУ
        public string INN { get; set; } //ДОБАВИТЬ В БАЗУ

        public string PRIMECHANIE { get; set; } //ДОБАВИТЬ В БАЗУ
    }

    public class NZSdelkiData
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
        public string VALUTA { get; set; }

        public string KONTAKTNAME { get; set; } //ДОБАВИТЬ В БАЗУ
        public string KONTAKTPHONE { get; set; } //ДОБАВИТЬ В БАЗУ
        public string INN { get; set; } //ДОБАВИТЬ В БАЗУ

        public string PRIMECHANIE { get; set; } //ДОБАВИТЬ В БАЗУ
    }

    public class ZSkladData
    {
        public int Id { get; set; }
        public string TOVARNAME { get; set; }
        public string EDIZM { get; set; }
        public string MYEDPRICE { get; set; } //закупочная цена
        public string SALEEDPRICE { get; set; } //рыночная цена 
        public string KOLICHESTVO { get; set; }
        public string PRIMECHANIE { get; set; }
        public string NKOLICHESTVO { get; set; }
        public string ARTIKUL { get; set; }
    }
}