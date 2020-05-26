using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan tietokannan käsittely.");

            string connStr = @"Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connStr);
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                Console.WriteLine("Tietokantayhteys avauttu.");

                /*
                SqlTransaction tran = connection.BeginTransaction();
                tran.Commit();
                tran.Rollback();
                */

                // luetaan asiakkaat tietokannasta
                string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
                cmd = new SqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
                Console.WriteLine("Kysely suoritettu.");

                // tulostetaan asiakastiedot ruudule
                Console.WriteLine();
                while (reader.Read())
                {
                    string company = reader["CompanyName"].ToString();
                    Console.WriteLine("Löytyi asiakas: " + company);
                }
                Console.WriteLine();
            }
            finally
            {
                /*
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                */
                reader?.Close();
                cmd?.Dispose();

                Console.WriteLine("Suljetaan tietokantayhteys.");
                connection.Close();
            }

            Console.WriteLine("Sovelluksen suoritus päättyy.");
            Console.ReadLine();
        }
    }
}
