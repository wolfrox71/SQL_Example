using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Configuration;
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
            //test.clearTable();
            //test.insert("Test2", "Something2", "Else2");
            Console.WriteLine("Ended insert");
            string[][] a = test.readValues();
            Console.WriteLine($"Got {a.Length} values");
            
            foreach (var row in a)
            {
                foreach (var column in row)
                {
                    Console.WriteLine(column);
                }
                Console.WriteLine("\n-------------\n");
            }
        }
    }
}