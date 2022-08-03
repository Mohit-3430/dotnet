using System;
using MySql.Data.MySqlClient;
using MySql.Data;

class Program
{
    public static void Main(string[] a)
    {
        string strcon = @"server=localhost;userid=root;password='MohitSQL';database=mo_db";

        var con = new MySqlConnection(strcon);
        con.Open();

        var cmd = new MySqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "insert into mo_db.mo_tab values(6657, 'S.Mohit')";
        // Executes a Transact-SQL statement against the connection and returns the number of rows affected.
        cmd.ExecuteNonQuery();

        Console.WriteLine("Record Inserted!");
    }
}
