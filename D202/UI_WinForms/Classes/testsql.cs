using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class testsql
    {
        public void sqlConnect()
        {
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Data Source=tfs;Initial Catalog=study3;Integrated Security=True";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM db_owner.course", conn);
                //// Add the parameters.
                //command.Parameters.Add(new SqlParameter("0", 1));

                // Use a SqlDataReader to read the results from the SqlCommand
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // While loop to iterate through each row in the reader object
                    while (reader.Read())
                    {
                        // ReadSingleRow Method is called to write all columns from the row into one line
                        ReadSingleRow((IDataRecord)reader);
                    }
                }

            }
        }

        private static void ReadSingleRow(IDataRecord record)
        {
         //   Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]));
            for(int i = 0; i < record.FieldCount; i++)
            {
                Console.Write(record[i] + ", ");
            }
            Console.Write("\n");
        }
    }
}
