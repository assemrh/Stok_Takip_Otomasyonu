using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSatis());

            //Console.WriteLine("Data Source=EC2AMAZ-8DHV6MA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
            //Console.ReadLine();
            //string sss = Console.ReadLine();



            //DateTime dat = DateTime.Now;

            //Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            //Console.Write("\nPress any key to continue... ");
            //Console.ReadLine();

        }
    }
}
