using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qweqwe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Class1 c = new Class1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string evet = "Evet";
            c.baglantikur("select * from tekrar", "bilgilendirme");
            c.kontrol("select * from tekrar where bilgilendirme='" + evet + "'");
            bool varmi = c.Varmi();
            if (varmi == true)
            {
                Application.Run(new bilgilendirme());
            }
            Application.Run(new acilisekran());
            Application.Run(new anasayfa());
           
        }
    }
}
