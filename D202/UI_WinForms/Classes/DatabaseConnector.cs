using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class DatabaseConnector
    {
        public SqlCommand SQLConnect(string sqlCommand)
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
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                //// Add the parameters.
                //command.Parameters.Add(new SqlParameter("0", 1));

                return command;

            }
        }

        public void LoginConnect(string sqlCommand, string id, string password)
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
                SqlCommand command = new SqlCommand(sqlCommand, conn);

                // set procedure
                command.CommandType = CommandType.StoredProcedure;

                //// Add the parameters.
                command.Parameters.Add(new SqlParameter(id, password));

                // Exec command
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(command);
                        Console.WriteLine(reader);
                    }
                }
                //return command;

            }

            //// 1.  create a command object identifying the stored procedure
            //SqlCommand cmd = new SqlCommand("CustOrderHist", conn);

            //// 2. set the command object so it knows to execute a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;

            //// 3. add parameter to command, which will be passed to the stored procedure
            //cmd.Parameters.Add(new SqlParameter("@CustomerID", custId));

            //// execute the command
            //using (SqlDataReader rdr = cmd.ExecuteReader())
            //{
            //    // iterate through results, printing each to console
            //    while (rdr.Read())
            //    {
            //        Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["ProductName"], rdr["Total"]);
            //    }
            //}
        }

        public Course[] GetCourses ()
        {
            List<Course> holder = new List<Course>();

            Console.Write(holder.GetType());

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
                    foreach (IDataRecord record in reader)
                    {
                        string[] dataRow = ReadSingleRow((IDataRecord)reader);

                        //Course courseHolder = new Course(dataRow);

                        //holder.Add(courseHolder);              
                    }
                }
            }

            Course[] returnCourseArray = holder.ToArray();

            return returnCourseArray;
        }

        public Category[] GetCategories()
        {
            List<Category> holder = new List<Category>();
            
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Data Source=tfs;Initial Catalog=study3;Integrated Security=True";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM db_owner.category", conn);
                //// Add the parameters.
                //command.Parameters.Add(new SqlParameter("0", 1));


                // Use a SqlDataReader to read the results from the SqlCommand
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    foreach (IDataRecord record in reader)
                    {
                        string[] dataRow = ReadSingleRow((IDataRecord)reader);

                        //Category courseHolder = new Category(dataRow);

                        //holder.Add(courseHolder);
                    }
                }
            }

            Category[] returnCourseArray = holder.ToArray();

            return returnCourseArray;
        }

        private string[] ReadSingleRow(IDataRecord record)
        {
         //   Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]));\
            List<string> templist = new List<string>();

            for(int i = 0; i < record.FieldCount; i++)
            {
                    string returnString = record[i].ToString();
                    templist.Add(returnString);         
            }

            string[] returnStrArray = templist.ToArray();
            return returnStrArray;


            // ----- Below is how to call the function where reader is an SqlDataReader object
            //ReadSingleRow((IDataRecord)reader);
        }
    }
}
