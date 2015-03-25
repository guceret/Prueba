using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class dataB
    {
        
        SqlConnection connection; //= new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\bin\Debug\Database2.mdf;Integrated Security=True");
        //SqlConnection connection;
        public void connect() { 
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        //    //string ConnectionString = "Data Source=|DataDirectory|\\Database.mdf";
        //    connection = new SqlConnection { ConnectionString = "Data Source=|DataDirectory|\\Database1.mdf" };
            connection = new SqlConnection (@"Data Source=(LocalDB)\v11.0;" +"AttachDbFilename=|DataDirectory|\\Database2.mdf;"+"Integrated Security=True;");

            connection.Open();
        //    //return ConnectionString;
        }


        public void updateData(int dayID, float comida) {
            string sql = "UPDATE Budget SET comida=@comida WHERE day=@day";
            //connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@day", dayID);
            command.Parameters.AddWithValue("@comida", comida);
            command.ExecuteNonQuery();
            connection.Close();       
        }

        public SqlDataReader readLastDay(int dayID) {
            
            string query = "SELECT * FROM Budget WHERE day=@day";
            //connection.Open();
            SqlCommand coms = new SqlCommand(query, connection);
            coms.Parameters.AddWithValue("@day", dayID - 1);
            SqlDataReader reader = coms.ExecuteReader();
            return reader;
        }

        public void closeD() {
           connection.Close();
        }

        public int maxID() {
            string query = "SELECT MAX(Id) FROM Gastos";
            //connection.Open();
            SqlCommand comSelect = new SqlCommand(query, connection);
            int  ID1 = Convert.ToInt32(comSelect.ExecuteScalar());
            connection.Close();
            return ID1;
        }

    }
}
