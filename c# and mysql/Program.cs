using System;
using MySql.Data.MySqlClient;
using MySql.Data;

class Program{
    public static void Main(string[] a){
        string strcon = @"server=localhost;userid=root;password='';database=mo_db";

        using var con = new MySqlConnection(strcon);
        con.Open();

        using var cmd = new MySqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "insert into mo_db.mo_tab values(6657, 'S.Mohit')";
        cmd.ExecuteNonQuery();

        Console.WriteLine("Record Inserted!");
    }
}
