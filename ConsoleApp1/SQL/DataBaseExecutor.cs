using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL
{
    class DataBaseExecutor
    {
        public static DataTable ReadTestTable1DT()
        {
            string connectionstring =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NumberCol", "3");


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }


        }

        public static DataTable BuildDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns.Add("NumberCol", typeof(int));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2011, 1, 1);
            for(var i=0;i<50;i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] ="UserName"+ i;
                dr["Birthday"] = baseDate.AddDays(i);
                //dr["NumberCol"] = "NuberCol"+(i);
                dt.Rows.Add(dr);
            }

            return dt;

        }

    }
}
