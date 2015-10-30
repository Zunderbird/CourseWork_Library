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
    public partial class issued_fm : Form
    {
        private SqlCeConnection conn;
        private string login;
        private string fio;
        public issued_fm(SqlCeConnection _conn,string _login, string _fio)
        {
            login = _login;
            fio = _fio;
            conn = _conn;
            InitializeComponent();
            issued_login.Text = login;
            issued_fio.Text = fio;
            issued_grid.DataSource = SQL.Select("SELECT rent.id, books.name, users.login, rent.issued, rent.back, rent.is_back FROM books INNER JOIN rent ON books.id = rent.book INNER JOIN users ON rent.reader = users.id WHERE (users.login='"+login.ToString()+"')", conn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
