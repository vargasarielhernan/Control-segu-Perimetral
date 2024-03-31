using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB
{
    public class AccesoDB
    {
        private SqlConnection connection;
        private SqlCommand comando;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public AccesoDB()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS;database=SECUREC;integrated security=true");
            comando = new SqlCommand();
        }
        public void setquery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }
        public void runread()
        {
            comando.Connection = connection;
            try
            {
                connection.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void exeaction()
        {
            comando.Connection = connection;
            try
            {
                connection.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setparametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void closeconnection()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }
    }
}
