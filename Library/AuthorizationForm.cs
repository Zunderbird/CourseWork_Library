using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Proga_01
{
  
    public partial class AuthorizationForm : Form
    {
        private SqlCeConnection conn;
        private UserData data = UserData.getInstance;

        public AuthorizationForm(SqlCeConnection _conn)
        {
            conn = _conn;
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE (login = '" + login_tf.Text+ "')";
            string tRole = "";
            DataTable dt = SQL.Select(query, conn);
            if (dt.Rows.Count > 0 && dt.Rows[0]["password"].ToString()==pass_tf.Text)
            {
                switch (Convert.ToInt16(dt.Rows[0]["role"].ToString()))
                {
                    case 1:
                        tRole = UserData.ADMIN;
                        break;
                    case 2:
                        tRole = UserData.EDITOR;
                        break;
                    case 3:
                        tRole = UserData.SPY;
                        break;
                    case 4:
                        tRole = UserData.READER;
                        break;
                    default:
                        tRole = UserData.UNLOGGED;
                        break;
                }
               
                data.user_id = Convert.ToInt16(dt.Rows[0]["id"]);
                data.role = tRole;
                data.logged = true;
                //MessageBox.Show(data.role,"1");
                button2_Click(null, null);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }               
        }
    }
}
