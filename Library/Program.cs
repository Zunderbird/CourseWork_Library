using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace Proga_01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        private static SqlCeConnection conn;
         [STAThread]
        static void Main()
        {
            conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source='Database1.sdf'";
            conn.Open();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_fm mainForm = new Main_fm(conn);
            Application.EnableVisualStyles();
           
            Application.Run(mainForm);
            mainForm.FormClosing += form_closing;
        }

        private static void form_closing(object sender, FormClosingEventArgs e)
        {
            
            conn.Close();
        }
    }
}
