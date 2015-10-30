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
    public partial class ChangeUserDataForm : Form
    {
        private SqlCeConnection conn;
        private string rent_id;
        private bool checked_on_load;
        private int books_available;
        private int book_id;

        public ChangeUserDataForm(SqlCeConnection _conn, string _rent_id)
        {
            rent_id = _rent_id;
            conn = _conn;
            InitializeComponent();
            DataTable dt = SQL.Select("SELECT books.name, books.author, users.login, users.f_name, users.l_name, users.surname, rent.issued, rent.back, rent.is_back, users.id AS user_id, books.id AS book_id, books.available FROM users INNER JOIN rent ON users.id = rent.reader INNER JOIN books ON rent.book = books.id WHERE (rent.id = '" + rent_id + "')", conn);
            edit_rent_is_returned.CheckedChanged += checked_change;
            edit_rent_book_name.Text = dt.Rows[0]["name"].ToString();
            edit_rent_book_author.Text = dt.Rows[0]["author"].ToString();
            edit_rent_user_id.Text = dt.Rows[0]["user_id"].ToString();
            edit_rent_user_fio.Text = dt.Rows[0]["f_name"].ToString() + " " + dt.Rows[0]["l_name"].ToString() + " " + dt.Rows[0]["surname"].ToString();
            edit_rent_issued_date.Value = Convert.ToDateTime(dt.Rows[0]["issued"]);

            if (dt.Rows[0]["is_back"].ToString().Length != 0)
            {
                edit_rent_is_returned.Checked = Convert.ToBoolean(dt.Rows[0]["is_back"]);
            }
            else
            {
                edit_rent_is_returned.Checked = false;
            }
            checked_on_load = edit_rent_is_returned.Checked;
            book_id = Convert.ToInt16(dt.Rows[0]["book_id"]);
            books_available = Convert.ToInt16(dt.Rows[0]["available"]);
            //grid_issues.CurrentRow.Cells["id"].Value.ToString();
        }

        private void checked_change(object sender, EventArgs e)
        {
            edit_rent_return_date.Enabled = edit_rent_is_returned.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_rent_ok_Click(object sender, EventArgs e)
        {
            if (checked_on_load == edit_rent_is_returned.Checked)
            {
                this.Close();
            }
            else
            {

                string query = "UPDATE rent SET  is_back = '" + edit_rent_is_returned.Checked.ToString() + "', back = '";
                if (edit_rent_is_returned.Checked)
                {
                    query += get_time_string(edit_rent_return_date.Value);
                }
                else
                {
                }

                query += "' WHERE (id = ";
                query += rent_id.ToString() + ")";
                // MessageBox.Show(query);
                SQL.Exec(query, conn);
                var inc = 0;
                if (checked_on_load == true) inc = -1;
                else inc = 1;

                query = "UPDATE books SET available = '" + (books_available + inc) + "' WHERE id = ";
                query += book_id.ToString();
                SQL.Exec(query, conn);
                this.Close();
            }
        }
        private string get_time_string(DateTime date)
        {
            string str = "";
            str = date.Month.ToString() + "." + date.Day.ToString() + "." + date.Year.ToString() + " " + date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();
            return str;


        }
    }
}
