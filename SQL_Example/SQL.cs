using System.Data.Entity.Migrations.Model;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace program
{
    class sql
    {
        protected string _table, _filename, cs;
        protected SQLiteConnection con;
        public sql(string E_table, string E_filename)
        {
            _table = E_table;
            _filename = E_filename;
            cs = $"URI=file:{E_filename}";
            con = new SQLiteConnection(cs);
            con.Open();
        }
         public void insert(string value1, string value2, string value3)
        {
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO TABLE {_table} VALUES ('{value1}', '{value2}', '{value3}')";
            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
        }
         public void createTable()
        {
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {_table}(userID INTEGER PRIMARY KEY, value1 TEXT, value2 TEXT, value3 TEXT)";
            cmd.ExecuteNonQuery();
        }
        public void readValues(string value1)
        {

            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"SELECT userID from {_table} WHERE value1='{value1}'";
            var reader = cmd.ExecuteReader();

            // if the number of fields returned == 0
            // then no user was found and so the username is not in use
            // so return false
            List<string> items = new List<string>();

            while (reader.Read())
            {
                Trace.WriteLine(reader);
                for (int columnID = 0; columnID < reader.GetValues().Count; columnID++)
                {
                    Trace.WriteLine(reader.GetString(columnID));
                    items.Add(reader.GetString(columnID));
                }
            }

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}