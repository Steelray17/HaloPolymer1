using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloPolymer
{
    static class Program
    {
        public static HaloPolymerEntities HaloPolymer = new HaloPolymerEntities();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
            //Application.Run(new Menu());
        }
    }
}
