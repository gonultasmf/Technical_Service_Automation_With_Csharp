using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Vodi_Pro
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool kontrol;
            Mutex mutex = new Mutex(true, "E1", out kontrol); //Örnek Mutex nesnesi oluşturalım. 
            if (kontrol == false)
            {
                MessageBox.Show("Program zaten çalışıyor !!.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GC.KeepAlive(mutex); //Nesneyi kaldırıyoruz.
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(InputLanguage.DefaultInputLanguage.Culture.Name);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Languages);
            Application.Run(new FrmAnaSayfa());
        }
    }
}
