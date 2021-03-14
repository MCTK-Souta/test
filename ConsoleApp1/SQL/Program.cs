using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt =
                DataBaseExecutor.BuildDataTable();

            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine("\tID編號\t姓名\t\t生日\n"+
                    "\t{0}\t{1}\t{2}",
                    dr["ID"],
                    dr["Name"],
                    dr["Birthday"]
                    );
            }

            Console.ReadLine();



            //string connectionString =
            //   "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //string queryString =
            //    $@" SELECT * FROM TestTable1
            //        WHERE NumberCol = @NumberCol
            //        ORDER BY ID DESC;";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Parameters.AddWithValue("@NumberCol", "3");

            //    try
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(
            //                "\t{0}\t{1}\t{2}",
            //                reader["ID"],
            //                reader["Birthday"],
            //                reader["Name"]
            //            );
            //        }

            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    finally
            //    {
            //        connection.Close();
            //    }
            //    Console.Read();
            //}

            //string connectionstring = 
            //    "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //string queryString =
            //    $@"SELECT * FROM TestTable1
            //        (ID,Name,Birthday,NumberCol)
            //    VALUES
            //        (@ID,@Name,@Birthday,@NumberCol);";

            //using (SqlConnection connection=new SqlConnection(connectionstring))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Parameters.AddWithValue("@ID", 7);
            //    command.Parameters.AddWithValue("@Name", "豆花");
            //    command.Parameters.AddWithValue("@Birthday", new DateTime(1958, 03, 22));
            //    command.Parameters.AddWithValue("@NumberCol", "3");

            //try
            //{
            //    connection.Open();
            //    int totalChangeRows = command.ExecuteNonQuery();
            //    Console.WriteLine("Total change" + totalChangeRows + "Rows");

            //}

            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    DataTable dt = new DataTable();
            //    dt.Load(reader);

            //    foreach(DataRow dr in dt.Rows)
            //    {
            //        Console.WriteLine(
            //            "\t{0}\t{1}\t{2}",
            //            dr["ID"],
            //            dr["Birthday"],
            //            dr["Name"]
            //            );
            //    }
            //    reader.Close();

            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.Read();
        }



        }
    }
