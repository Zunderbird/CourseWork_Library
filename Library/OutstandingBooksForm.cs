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
    public partial class add_issue_fm : Form
    {
        private SqlCeConnection conn;
        private int book_id;
        private int available;

        public add_issue_fm(SqlCeConnection _conn, int _book_id, int _available)
        {
            conn = _conn;
            available = _available;
            book_id = _book_id;
            InitializeComponent();
            
            //comboBox1.DataSource = SQL.Select("SELECT description FROM doc_types", conn);
            //comboBox1.DisplayMember = "description";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_rent_ok_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO rent (book, reader,issued) Values (@book, @reader,@issued)";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@book", book_id},
                    {"@reader", Convert.ToInt16(this.add_rent_userid.Text)},
                    {"@issued", Convert.ToDateTime(this.add_rent_date_picker.Value)}
                    
                };
            SQL.Exec(query, conn,parameters);
            
            query = "UPDATE books SET available = '"+ (available-1) + "' WHERE id = ";
            query += book_id.ToString();
            SQL.Exec(query, conn);

            this.Close();
        }
    }
}
