using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vodi_Pro.Class
{
    public class SystemDB
    {
        public int Id { get; set; }
        public int indexTema { get; set; }
        public int indexPara { get; set; }
        public string text { get; set; }
        public string mesaj1 { get; set; }
        public string mesaj2 { get; set; }
        public int sms { get; set; }
        public string smsKAdi { get; set; }
        public string smsSifre { get; set; }
        public int yazici { get; set; }
        public int pos { get; set; }
        public int etiket { get; set; }
        public int aErtele { get; set; }
        public bool zilSes { get; set; }
        public int zilSesim { get; set; }
        public int zilSesTekrar { get; set; }
        public bool yedekle { get; set; }
        public string mailHost { get; set; }
        public int mailPort { get; set; }
        public bool mailSSL { get; set; }
        public string mail { get; set; }
        public string mailSifre { get; set; }
        public string path { get; set; }

    }
}
