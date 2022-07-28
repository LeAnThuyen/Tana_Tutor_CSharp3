using System;
using System.Windows.Forms;

namespace EF_DatabaseFirst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Data Source=TANA\SQLEXPRESS;Initial Catalog=FastFoodForThuyen;Persist Security Info=True;User ID=thuyen;Password=***********
            //Data Source=TANA\SQLEXPRESS;Initial Catalog=FastFood;Persist Security Info=True;User ID=thuyen;Password=***********
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
