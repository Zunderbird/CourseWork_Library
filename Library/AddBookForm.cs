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
    public partial class add_book_fm : Form
    {
        private SqlCeConnection conn;
        private UserData data = UserData.getInstance;
        private TextBox[] fields = new TextBox[7];
        private DataTable dt = new DataTable();
        private int id;
        private int last_amount;
        private int last_available;
        public add_book_fm(SqlCeConnection _conn)
        {
            conn = _conn;

            InitializeComponent();
            fields[0] = add_name_book_tf;
            fields[1] = add_author_tf;
            fields[2] = add_isbn_tf;
            fields[3] = add_publisher_tf;
            fields[4] = add_year_tf;
            fields[5] = add_pages_tf;
            fields[6] = add_amount_tf;
        }

        public void show_book(int _id)
        {
            id = _id;
            string query = "SELECT name, author, publisher, year, pages, ISBN, amount, available FROM books WHERE id = ";
            query += id.ToString();
            dt = SQL.Select(query, conn);
            last_amount = Convert.ToInt16(dt.Rows[0]["amount"]);
            last_available = Convert.ToInt16(dt.Rows[0]["available"]);
            add_name_book_tf.Text = dt.Rows[0][0].ToString();
            add_author_tf.Text = dt.Rows[0][1].ToString();
            add_publisher_tf.Text = dt.Rows[0][2].ToString();
            add_year_tf.Text = dt.Rows[0][3].ToString();
            add_pages_tf.Text = dt.Rows[0][4].ToString();
            add_isbn_tf.Text = dt.Rows[0][5].ToString();
            add_amount_tf.Text = dt.Rows[0][6].ToString();
        }
        public void edit_book()
        {
            DataTable dt = new DataTable();
        }

        private void add_book_final_bt_Click(object sender, EventArgs e)
        {
            if (check_validity(fields))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            else if (add_year_tf.TextLength > 4) MessageBox.Show("Поле 'Год' не должно превышать 4 знака!");
            else if (this.Text == "Редактировать книгу")
            {


                var new_available = last_available - last_amount + Convert.ToInt16(add_amount_tf.Text);
                if (new_available >= 0)
                {
                    string query = "UPDATE books SET name = '" + add_name_book_tf.Text + "', author = '" + add_author_tf.Text + "', publisher = '" + add_publisher_tf.Text + "', year = " + add_year_tf.Text + ", pages = " + add_pages_tf.Text + ", ISBN = '" + add_isbn_tf.Text + "', amount = " + add_amount_tf.Text + ", available = " + new_available + " WHERE id = ";
                    query += id.ToString();
                    SQL.Exec(query, conn);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невозможно изменить количество \nНедостаточно книг на складе", "Ошибка");
                }
            }
            else
            {
                string query = "INSERT INTO books (name, author, publisher, year, pages, ISBN, amount, available) Values (@name, @author, @publisher, @year, @pages, @ISBN, @amount, @available)";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@name", add_name_book_tf.Text},
                    {"@author", add_author_tf.Text},
                    {"@publisher", add_publisher_tf.Text},
                    {"@year", add_year_tf.Text},
                    {"@pages", add_pages_tf.Text},
                    {"@ISBN", add_isbn_tf.Text},
                    {"@amount", add_amount_tf.Text},
                    {"@available", add_amount_tf.Text}
                };
                SQL.Exec(query, conn, parameters);
                this.Close();
            }
        }

        private void add_book_cancell_bt_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
