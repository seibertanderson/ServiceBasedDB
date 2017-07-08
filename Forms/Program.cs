using Forms.Telas;
using System;
using System.Windows.Forms;

namespace Forms
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
            //Application.Run(new MenuPrincipal());
            //Application.Run(new Login());
            DialogResult result;
            var loginForm = new Login();
            result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // login was successful
                Application.Run(new MenuPrincipal());
            }
        }
    }
}
