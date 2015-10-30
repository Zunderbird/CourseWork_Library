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
    public partial class Main_fm : Form
    {
        public SqlCeConnection conn;

        private DataTable dt = new DataTable();
        private UserData data = UserData.getInstance;

        public Main_fm(SqlCeConnection _conn)
        {
            data.LoggedChange += loggedHandler;
            conn = _conn;
            InitializeComponent();

            show_books();
            show_readers();
            show_personal();
            show_issues();

            data.logged = true;
            data.role = UserData.ADMIN;
            role_lb.Text = "[Вы зашли как Администратор]";
            loggedHandler(null, null);
           // grid_readers.Columns[0].Visible = false;
            grid_books.Columns[0].Visible = false;
            grid_personal.Columns[0].Visible = false;
            grid_issues.Columns[0].Visible = false;
            grid_books.DataSourceChanged += booksDataChange;
            booksDataChange(null, null);
            grid_readers.DataSourceChanged += readersDataChange;
            readersDataChange(null, null);
            grid_personal.DataSourceChanged += personalDataChange;
            personalDataChange(null, null);
            grid_issues.DataSourceChanged += issuesDataChange;
            issuesDataChange(null, null);
            
            grid_users_issues.DataSourceChanged += users_issuesDataChange;
           users_issuesDataChange(null, null);
        }

        private void booksDataChange(object sender, EventArgs e)
        {
            grid_books.Columns[0].HeaderText = "ID";
            grid_books.Columns[1].HeaderText = "Название";
            grid_books.Columns[1].Width = 200;
            grid_books.Columns[2].HeaderText = "Автор";
            grid_books.Columns[3].HeaderText = "Издатель";
            grid_books.Columns[4].HeaderText = "Год";
            grid_books.Columns[4].Width = 40;
            grid_books.Columns[5].HeaderText = "Страниц";
            grid_books.Columns[5].Width = 50;
            grid_books.Columns[6].HeaderText = "ISBN";
            grid_books.Columns[7].HeaderText = "Количество";
            grid_books.Columns[7].Width = 50;
            grid_books.Columns[8].HeaderText = "Доступно";
            grid_books.Columns[8].Width = 50;
        }

        private void readersDataChange(object sender, EventArgs e)
        {
            grid_readers.Columns[0].HeaderText = "ID";
            grid_readers.Columns[1].HeaderText = "Фамилия";
            grid_readers.Columns[2].HeaderText = "Имя";
            grid_readers.Columns[3].HeaderText = "Отчество";
            grid_readers.Columns[4].HeaderText = "Логин";
            grid_readers.Columns[5].HeaderText = "Номер документа";
            grid_readers.Columns[6].HeaderText = "Тип документа";
        }

        private void personalDataChange(object sender, EventArgs e)
        {
            grid_personal.Columns[0].HeaderText = "ID";
            grid_personal.Columns[1].HeaderText = "Фамилия";
            grid_personal.Columns[2].HeaderText = "Имя";
            grid_personal.Columns[3].HeaderText = "Отчество";
            grid_personal.Columns[4].HeaderText = "Логин";
            grid_personal.Columns[5].HeaderText = "Номер документа";
            grid_personal.Columns[6].HeaderText = "Тип документа";
        }
        private void issuesDataChange(object sender, EventArgs e)
        {
            grid_issues.Columns[0].HeaderText = "ID";
            grid_issues.Columns[1].HeaderText = "Книга";
            grid_issues.Columns[2].HeaderText = "Читатель";
            grid_issues.Columns[3].HeaderText = "Дата выдачи";
            grid_issues.Columns[4].HeaderText = "Дата возврата";
            grid_issues.Columns[5].HeaderText = "Возвращено";
        }
        private void users_issuesDataChange(object sender, EventArgs e)
        {
            if (grid_users_issues.ColumnCount>5)
            {
                grid_users_issues.Columns[0].HeaderText = "ID";
                grid_users_issues.Columns[1].HeaderText = "Книга";
                grid_users_issues.Columns[2].HeaderText = "Читатель";
                grid_users_issues.Columns[3].HeaderText = "Дата выдачи";
                grid_users_issues.Columns[4].HeaderText = "Дата возврата";
                grid_users_issues.Columns[5].HeaderText = "Возвращено";
            }
        }

        private void show_books()
        {
            grid_books.DataSource = SQL.Select("SELECT id, name, author, publisher, year, pages, ISBN, amount, available FROM books", conn);
        }
        private void show_readers()
        {
            grid_readers.DataSource = SQL.Select("SELECT users.id, users.surname, users.f_name, users.l_name, users.login, users.doc_serial, doc_types.description FROM users INNER JOIN doc_types ON users.doc_type = doc_types.id WHERE (users.role = 4)", conn);
        }
        private void show_personal()
        {
            grid_personal.DataSource = SQL.Select("SELECT users.id, users.surname, users.f_name, users.l_name, users.login, users.doc_serial, doc_types.description FROM users INNER JOIN doc_types ON users.doc_type = doc_types.id WHERE (users.role < 3)", conn);
        }
        private void show_issues()
        {
            grid_issues.DataSource = SQL.Select("SELECT rent.id, books.name, users.login, rent.issued, rent.back, rent.is_back FROM books INNER JOIN rent ON books.id = rent.book INNER JOIN users ON rent.reader = users.id", conn);
        }
        private void show_users_issues()
        {
           // MessageBox.Show(data.user_id.ToString());
            grid_users_issues.DataSource = SQL.Select("SELECT rent.id, books.name, users.login, rent.issued, rent.back, rent.is_back FROM books INNER JOIN rent ON books.id = rent.book INNER JOIN users ON rent.reader = users.id WHERE (rent.reader =" + data.user_id.ToString()+")", conn);
        }
        private int get_book_id()
        {
            return Convert.ToInt16(grid_books.CurrentRow.Cells["id"].Value);
        }

        private int get_user_id(string role)
        {
            if (role == UserData.READER)
            {
                return Convert.ToInt16(grid_readers.CurrentRow.Cells["id"].Value);
            }
            else
            {
                return Convert.ToInt16(grid_personal.CurrentRow.Cells["id"].Value);
            }
        }
        private int get_issue_id()
        {
            return Convert.ToInt16(grid_issues.CurrentRow.Cells["id"].Value);
        }

        private void loggedHandler(object sender, EventArgs e)
        {    

            logout_bt.Visible = data.logged;
            auth_bt.Visible = !data.logged;
            tab_main.TabPages.Remove(tab_users);
            tab_main.TabPages.Remove(tab_personal);
            tab_main.TabPages.Remove(tab_issues);
            tab_main.TabPages.Remove(tab_users_issues);
            add_issue_bt.Visible = false;

          // MessageBox.Show(data.role.ToString());
            switch (data.role.ToString())
            {
                case "ADMIN":
                    tab_books.Show();
                    tab_main.TabPages.Add(tab_users);
                    tab_main.TabPages.Add(tab_personal);
                    tab_main.TabPages.Add(tab_issues);
                    toolStrip1.Visible = true;
                    add_issue_bt.Visible = true;
                    role_lb.Text = "[Вы зашли как Администратор]";
                    break;
                case "EDITOR":
                    tab_main.TabPages.Add(tab_users);
                    tab_main.TabPages.Add(tab_issues);
                    toolStrip1.Visible = true;
                    add_issue_bt.Visible = true;
                    role_lb.Text = "[Вы зашли как Библиотекарь]";
                    break;
                case "SPY":
                    tab_main.TabPages.Add(tab_users);
                    tab_main.TabPages.Add(tab_personal);
                    tab_main.TabPages.Add(tab_issues);
                    toolStrip1.Visible = false;
                    role_lb.Text = "[Вы зашли как Шпион]";
                    break;
                case "READER":
                    tab_main.TabPages.Add(tab_users_issues);
                    toolStrip1.Visible = false;
                    role_lb.Text = "[Вы зашли как Читатель]";
                    show_users_issues();
                    break;
                case "UNLOGGED":
                    toolStrip1.Visible = false;
                    break;
                default:
                    MessageBox.Show("Ошибка: Ошибка авторизации");
                    break;
            }
            tab_books.Update();
            tab_personal.Update();
            tab_users.Update();
            tab_issues.Update();
            tab_users_issues.Update();
        }
        private void login_bt_Click(object sender, EventArgs e)
        {
            AuthorizationForm fr2 = new AuthorizationForm(conn);
            fr2.Show();
        }
        private void logout_bt_Click(object sender, EventArgs e)
        {
            data.role = UserData.UNLOGGED;
            role_lb.Text = "[Вход не выполнен]";
            data.logged = false;
        }

        private void books_changed(object sender, FormClosedEventArgs e)
        {
            show_books();
           // throw new NotImplementedException();
        }
        private void users_changed(object sender, FormClosedEventArgs e)
        {
            show_readers();
            show_personal();
        }

        private void issues_changed(object sender, FormClosedEventArgs e)
        {
            show_issues();
        }
        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void find_book_bt_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, name, author, publisher, year, pages, ISBN, amount, available FROM books WHERE id > 0 ";
            if (name_book_tf.TextLength > 0)
                query += "AND name LIKE '%" + name_book_tf.Text + "%'";
            if (author_tf.TextLength > 0)
                query += "AND  author LIKE '%" + author_tf.Text + "%'";
            if (publisher_tf.TextLength > 0)
                query += "AND  publisher LIKE '%" + publisher_tf.Text + "%'";
            if (isbn_tf.TextLength > 0)
                query += "AND  ISBN LIKE '%" + isbn_tf.Text + "%'";

            grid_books.DataSource = SQL.Select(query, conn);
        }
        private void find_reader_bt_Click(object sender, EventArgs e)
        {
            string query = "SELECT users.id, users.surname, users.f_name, users.l_name, users.login, users.doc_serial, doc_types.description FROM users INNER JOIN doc_types ON users.doc_type = doc_types.id WHERE (users.role = 4)";
       
            if (surname_tf.TextLength > 0)
                query += " AND  surname LIKE '%" + surname_tf.Text + "%'";
            if (f_name_tf.TextLength > 0)
                query += " AND  f_name LIKE '%" + f_name_tf.Text + "%'";
            if (l_name_tf.TextLength > 0)
                query += " AND  l_name LIKE '%" + l_name_tf.Text + "%'";
            if (login_tf.TextLength > 0)
                query += " AND  login LIKE '%" + login_tf.Text + "%'";        

            grid_readers.DataSource = SQL.Select(query, conn);
        }

        private void find_personal_bt_Click(object sender, EventArgs e)
        {
            string query = "SELECT users.id, users.surname, users.f_name, users.l_name, users.login, users.doc_serial, doc_types.description FROM users INNER JOIN doc_types ON users.doc_type = doc_types.id WHERE (users.role < 3)";

            if (p_surname_tf.TextLength > 0)
                query += " AND  surname LIKE '%" + p_surname_tf.Text + "%'";
            if (p_f_name_tf.TextLength > 0)
                query += " AND  f_name LIKE '%" + p_f_name_tf.Text + "%'";
            if (p_l_name_tf.TextLength > 0)
                query += " AND  l_name LIKE '%" + p_l_name_tf.Text + "%'";
            if (p_login_tf.TextLength > 0)
                query += " AND  login LIKE '%" + p_login_tf.Text + "%'";

            grid_personal.DataSource = SQL.Select(query, conn);
        }

        private void find_issues_bt_Click(object sender, EventArgs e)
        {
            string query = "SELECT rent.id, books.name, users.login, rent.issued, rent.back, rent.is_back FROM books INNER JOIN rent ON books.id = rent.book INNER JOIN users ON rent.reader = users.id WHERE role < 10";
            if (this.rent_search_book_name.TextLength > 0)
                query += " AND  books.name LIKE '%" + rent_search_book_name.Text + "%'";
            if (this.rent_search_user_login.TextLength > 0)
                query += " AND  users.login LIKE '%" + rent_search_user_login.Text + "%'";
            grid_issues.DataSource = SQL.Select(query, conn);

        }

        private void add_tsbt_Click(object sender, EventArgs e)
        {
            switch (tab_main.SelectedTab.Name)
            {
                case "tab_books":
                    add_book_fm add_book_fm = new add_book_fm(conn);
                    add_book_fm.Show();
                    add_book_fm.FormClosed += books_changed;
                    break;
                case "tab_users":
                    add_users_fm add_users_fm = new add_users_fm(conn, UserData.READER);
                    add_users_fm.Show();
                    add_users_fm.FormClosed += users_changed;
                    break;
                case "tab_personal":
                    add_users_fm add_users_fm2 = new add_users_fm(conn, UserData.PERSONAL);
                    add_users_fm2.Show();
                    add_users_fm2.FormClosed += users_changed;
                    break;
                case "tab_issues":
                    tab_main.SelectedIndex = 0;
                    break;
                default:
                    MessageBox.Show("Ошибка: кнопка добавления сработала неверно!");
                    break;
            }

        }
        private void edit_tsbt_Click(object sender, EventArgs e)
        {
            switch (tab_main.SelectedTab.Name)
            {
                case "tab_books": 
                    add_book_fm add_book_fm = new add_book_fm(conn);
                    add_book_fm.Text = "Редактировать книгу";
                    add_book_fm.show_book(get_book_id());
                    add_book_fm.Show();
                    add_book_fm.FormClosed += books_changed;
                    break;
                case "tab_users":
                    add_users_fm add_users_fm = new add_users_fm(conn, UserData.READER);
                    add_users_fm.Text = "Редактировать данные";
                    add_users_fm.show_user(get_user_id(UserData.READER));
                    add_users_fm.Show();
                    add_users_fm.FormClosed += users_changed;
                    break;
                case "tab_personal":
                    add_users_fm add_users_fm2 = new add_users_fm(conn, UserData.PERSONAL);
                    add_users_fm2.Text = "Редактировать данные";
                    add_users_fm2.show_user(get_user_id(UserData.EDITOR));
                    add_users_fm2.Show();
                    add_users_fm2.FormClosed += users_changed;
                    break;
                case "tab_issues":
                    //Form7 fm7 = new Form7(conn, grid_issues.CurrentRow.Cells["f_name"].Value.ToString(), grid_issues.CurrentRow.Cells["reader"].Value.ToString());
                    ChangeUserDataForm fm7 = new ChangeUserDataForm(conn,grid_issues.CurrentRow.Cells["id"].Value.ToString());
                    fm7.FormClosed += onForm7Closed;
                    fm7.Show();
                    
                    break;
                default:
                    MessageBox.Show("Ошибка: кнопка редактирования сработала неверно!");
                    break;
            }
        }

        private void onForm7Closed(object sender, FormClosedEventArgs e)
        {
            show_issues();
            show_books();
        }

        private void delete_tsbt_Click(object sender, EventArgs e)
        {
            string query;
            string str;
            switch (tab_main.SelectedTab.Name)
            {
                case "tab_books":
                 //   MessageBox.Show(grid_books.CurrentRow.Cells["available"].Value.ToString());
                  //  MessageBox.Show(grid_books.CurrentRow.Cells["amount"].Value.ToString());
                    if (Convert.ToInt16(grid_books.CurrentRow.Cells["available"].Value)!=Convert.ToInt16(grid_books.CurrentRow.Cells["amount"].Value))
                    {
                        MessageBox.Show("Не все экземпляры книги '" + grid_books.CurrentRow.Cells["name"].Value.ToString() + "' возвращены", "Невозможно удалить книгу ");
                        query = "";
                        str = "";
                    }
                    else
                    {
                        query = "DELETE FROM books WHERE id = " + get_book_id().ToString();
                        str = grid_books.CurrentRow.Cells["name"].Value.ToString();
                    }
                    
                    break;
                case "tab_users":
                    query = "DELETE FROM users WHERE id = " + get_user_id(UserData.READER);
                    str = grid_readers.CurrentRow.Cells["login"].Value.ToString();
                    break;
                case "tab_personal":
                    query = "DELETE FROM users WHERE id = " + get_user_id(UserData.EDITOR);
                    str = grid_personal.CurrentRow.Cells["login"].Value.ToString();
                    break;
                case "tab_issues":
                    query = "DELETE FROM rent WHERE id = " + get_issue_id();
                    str = grid_issues.CurrentRow.Cells["name"].Value.ToString();
                    break;
                default:
                    MessageBox.Show("Ошибка: кнопка удаления сработала неверно!");
                    query = null;
                    str = null;
                    break;
            }
            if (query.Length>0)
            if ((MessageBox.Show("Вы уверены, что хотите удалить запись '" + str + "'?", str, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes))             
            {
                //MessageBox.Show(query.Length.ToString());
                MessageBox.Show("Ок");
                SQL.Exec(query, conn);
                show_books();
                show_personal();
                show_readers();
                show_issues();
            }
        }

        private void add_issue_bt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(grid_books.CurrentRow.Cells["available"].Value) > 0)
            {
                add_issue_fm add_issue_fm = new add_issue_fm(conn, Convert.ToInt16(grid_books.CurrentRow.Cells["id"].Value), Convert.ToInt16(grid_books.CurrentRow.Cells["available"].Value));
                add_issue_fm.add_rent_book_author.Text = grid_books.CurrentRow.Cells["author"].Value.ToString();
                add_issue_fm.add_rent_book_name.Text = grid_books.CurrentRow.Cells["name"].Value.ToString();
                add_issue_fm.Show();
                add_issue_fm.FormClosed += add_form_closed;
            }
            else
            {
                MessageBox.Show("Количество книг равно нулю", "Невозможно выдать книгу");
            }
            
        }

        private void add_form_closed(object sender, FormClosedEventArgs e)
        {
            show_books();
            show_issues();
        }

        private void issued_bt_Click(object sender, EventArgs e)
        {
            string fio = grid_readers.CurrentRow.Cells["f_name"].Value.ToString()+" "+grid_readers.CurrentRow.Cells["l_name"].Value.ToString()+" "+grid_readers.CurrentRow.Cells["surname"].Value.ToString();
            issued_fm issued_fm = new issued_fm(conn, grid_readers.CurrentRow.Cells["login"].Value.ToString(),fio);
            issued_fm.Show();
        }

    }
}
