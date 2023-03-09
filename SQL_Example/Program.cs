using System.Data.Entity.Migrations.Model;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            sql test = new sql("Users", "main.db");
            test.insert("Test", "Something", "Else");
            test.readValues("Test");
        }
    }
}