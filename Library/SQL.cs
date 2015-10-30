using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace Proga_01
{
    class SQL
    {

        public static DataTable Select(string query, SqlCeConnection conn)
        {
            DataTable dt = new DataTable();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn);
            adapter.Fill(dt);   
            return dt;
        }
        public static void Exec(string query, SqlCeConnection conn, Dictionary<string, object> parameters = null)
        {
            SqlCeTransaction trans = conn.BeginTransaction();
            using (SqlCeCommand com = new SqlCeCommand(query, conn))
            {
                com.Transaction = trans;
                if (parameters != null)
                {
                    foreach (var element in parameters)
                    {
                        com.Parameters.AddWithValue(element.Key, element.Value);
                    }
                }
                com.ExecuteNonQuery();
                trans.Commit(CommitMode.Immediate);
                com.Dispose();
            }
        }

    }
}
