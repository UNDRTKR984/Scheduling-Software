using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    static class Program
    {
        public static ApplicationContext MyAppCxt;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyAppCxt = new ApplicationContext(new LoginForm());
            Application.Run(MyAppCxt);
        }
    }
}
