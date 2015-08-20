using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Connect_Example
{
    class Program
    {
        static SqlConnection ConnectDB()
        {
            return new SqlConnection(
                "server=ROTTENAPPLE\\SQLEXPRESS;" +
                "database=9807459;" +
                "Integrated Security=sspi"
            );
        }
        static void Main(string[] args)
        {
            var conn = ConnectDB();
            try
            {
                conn.Open();
                Console.WriteLine("DB connection opened.");
                
                var cmd = conn.CreateCommand();
                Console.WriteLine("SqlCommand object created.");
                
                cmd.CommandText = "select * from CUSTOMER";
                var dr = cmd.ExecuteReader();
                Console.WriteLine("Synchronous command executed; SqlDataReader created.");

                while (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];
                    var result = dr.GetSqlValues(values);
                    Console.WriteLine("Values read; result = " + result.ToString());
                    var row = String.Join(",", values);
                    Console.WriteLine(row);
                }
                dr.Close();

                cmd.CommandText = "insert into CUSTOMER values (8, 'New value')";
                dr = cmd.ExecuteReader();
                Console.WriteLine("Synchronous command executed; SqlDataReader created.");

                while (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];
                    var result = dr.GetSqlValues(values);
                    Console.WriteLine("Values read; result = " + result.ToString());
                    var row = String.Join(",", values);
                    Console.WriteLine(row);
                }
                dr.Close();

                cmd.CommandText = "insert into CUSTOMER values (9, 'Data')";
                var rows = cmd.ExecuteNonQuery();
                Console.WriteLine("Synchronous command executed; " + rows.ToString() + " rows affected.");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }

    }
}
