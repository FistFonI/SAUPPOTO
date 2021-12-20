using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUPPOTO
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server = localhost;port=3306;username=root;password=root;database=sauppotodatabase");

        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch
            {
                Console.WriteLine("Произошла ошибка, обратитесь в поддержку");
            }
        }

        public void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Open();
            }
            catch
            {
                Console.WriteLine("Произошла ошибка, обратитесь в поддержку");
            }
        }
        
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
