using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalBaseConnections
{

    public class Connection
    {

        #region
        private string connectionString = "Server=localhost;Database=finnas_db;Trusted_Connection=True;";
        #endregion

        //Executa a query mas não tem respostas
        public void Excecute(string query)
        {

            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using(SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();

                }

            }
        }

        public DataTable ExcecuteQuery(string query)
        {

            DataTable outParam = new DataTable();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using(SqlCommand command = new SqlCommand(query, connection))
                using(SqlDataReader reader = command.ExecuteReader())
                {

                    outParam.Load(reader);                    

                }

            }

            return outParam;

        }

    }
}
