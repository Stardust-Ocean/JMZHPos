using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JMZHPos
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //var login = new LoginForm();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new MainForm());
            //    //Application.Run(new MessageBoxForm());
            //    //Application.Run(new SmallForm());
            //}
        }
    }
}
