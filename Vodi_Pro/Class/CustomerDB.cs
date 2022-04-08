using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vodi_Pro.Class
{
    public class CustomerDB
    {
        public int Id { get; set; }
        public string adi { get; set; }
        public string cihazMarka { get; set; }
        public string cihazModel { get; set; }
        public string cihazSifre { get; set; }
        public string telNo { get; set; }
        public string arizaBilgi { get; set; }
        public string aciklama { get; set; }
        public string imeiNo { get; set; }
        public DateTime kayitTarihi { get; set; }
        public string yapilanIslem { get; set; }
        public DateTime bitisTarihi { get; set; }
        public bool teslimEdildi { get; set; }
        public string arizaBedeli { get; set; }
        public bool ucretAlindi { get; set; }
        public bool desen { get; set; }
        public string mail { get; set; }
        public DateTime alarmTarihi { get; set; }
        public string alarmAciklama { get; set; }
        public Image[] cihazFotos { get; set; }
    }
}
