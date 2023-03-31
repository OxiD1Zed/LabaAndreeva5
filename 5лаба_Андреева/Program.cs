using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5лаба_Андреева
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static string ReplaceStartEnd(string str)
        {
            return str[str.Length - 1] + str.Remove(0, 1).Remove(str.Length - 2, 1) + str[0];
        }
    }
}
