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
    public partial class add_users_fm : Form
    {
        private SqlCeConnection conn;
        private UserData data = UserData.getInstance;
        private TextBox[] fields = new TextBox[5];
        private int id;
        private DataTable dt = new DataTable();
        private string role;

        public add_users_fm(SqlCeConnection _conn, String _role)
        {
            conn = _conn;
            role = _role;
            InitializeComponent();
            fields[0] = add_surname_tf;
            fields[1] = add_f_name_tf;
            fields[2] = add_l_name_tf;
            fields[3] = add_login_tf;
            fields[4] = add_password_tf;

            string query1 = "SELECT * FROM doc_types WHERE id ";
            string query2 = "SELECT * FROM roles WHERE id ";
            switch (role)
            {
                case "READER":
                    query1 += "> 1";
                    query2 += "= 4";
                    break;
                case "PERSONAL":
                    query1 += "= 1";
                    query2 += "< 3";
                    break;
                default:
                    MessageBox.Show("Ошибка: Заполнение поля 'роли' произошло не верно!");
                    query1 += "= 2";
                    query2 += "= 5";
                    break;
            }
            combo_doctype.DataSource = SQL.Select(query1, conn);
            combo_doctype.DisplayMember = "description";

            combo_role.DataSource = SQL.Select(query2, conn);
            combo_role.DisplayMember = "role";
        }
        public void show_user(int _id)
        {
            id = _id;
            string query = "SELECT surname, f_name, l_name, doc_serial, login, password, role, doc_type FROM users WHERE id = " + id.ToString();
            dt = SQL.Select(query, conn);

            add_surname_tf.Text = dt.Rows[0][0].ToString();
            add_f_name_tf.Text = dt.Rows[0][1].ToString();
            add_l_name_tf.Text = dt.Rows[0][2].ToString();
            add_doc_serial_tf.Text = dt.Rows[0][3].ToString();
            add_login_tf.Text = dt.Rows[0][4].ToString();
            add_password_tf.Text = dt.Rows[0][5].ToString();

            if (Convert.ToInt16(dt.Rows[0][6]) < 3)
                combo_role.SelectedIndex = Convert.ToInt16(dt.Rows[0][6]) - 1;

            if (Convert.ToInt16(dt.Rows[0][7]) > 1)
                combo_doctype.SelectedIndex = Convert.ToInt16(dt.Rows[0][7]) - 2;
        }
        private bool check_validity(TextBox[] ar)
        {
            bool flag = false;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i].TextLength == 0) flag = true;
            }
            return flag;
        }

        private void add_book_cancell_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_user_final_bt_Click(object sender, EventArgs e)
        {
            string query = "";
            
            int selected_role = Convert.ToInt16((this.combo_role.DataSource as DataTable).Rows[this.combo_role.SelectedIndex]["id"]);

            int selected_doc=Convert.ToInt16((this.combo_doctype.DataSource as DataTable).Rows[this.combo_doctype.SelectedIndex]["id"]);
            if (check_validity(fields))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            else if (this.Text == "Редактировать данные")
            {
                query = "UPDATE users SET surname = '" + add_surname_tf.Text + "', f_name = '" + add_f_name_tf.Text + "', l_name = '" + add_l_name_tf.Text + "', doc_serial = '" + add_doc_serial_tf.Text + "', login = '" + add_login_tf.Text + "', password = '" + add_password_tf.Text + "', doc_type = " + selected_doc + ", role = " + selected_role + " WHERE id = ";
                query += id.ToString();
                SQL.Exec(query, conn);

                this.Close();
            }
            else
            {
                query = "INSERT INTO users (surname, f_name, l_name, doc_serial, login, password, role, doc_type) Values (@surname, @f_name, @l_name, @doc_serial, @login, @password, @role, @doc_type)";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@surname", add_surname_tf.Text},
                    {"@f_name", add_f_name_tf.Text},
                    {"@l_name", add_l_name_tf.Text},
                    {"@doc_serial", add_doc_serial_tf.Text},
                    {"@login", add_login_tf.Text},
                    {"@password", add_password_tf.Text},
                    {"@role", selected_role.ToString()},
                    {"@doc_type", selected_doc.ToString()}
                
                };
                SQL.Exec(query, conn, parameters);
                this.Close();
            }
        }
    }
}
