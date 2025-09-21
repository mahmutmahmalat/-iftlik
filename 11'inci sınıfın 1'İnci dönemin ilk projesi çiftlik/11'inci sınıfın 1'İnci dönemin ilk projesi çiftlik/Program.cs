using _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik.formlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3_hesap_oluştur());
        }
    }
}
