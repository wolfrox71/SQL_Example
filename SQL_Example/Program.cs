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
            test.createTable();
            test.insert("Test", "Something", "Else");
            Console.WriteLine("Ended insert");
            var a = test.readValues();
            Console.WriteLine("Got values");
            foreach (var _A in a)
            {
                Console.WriteLine(_A);
            }
        }
    }
}