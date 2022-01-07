using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAUPPOTO
{
    /// <summary>
    /// База данных.
    /// </summary>
    class DataBase
    {
        /// <summary>
        /// Соединение.
        /// </summary>
        MySqlConnection connection = new MySqlConnection("server = localhost;port=3306;username=root;password=root;database=sauppotodatabase");

        /// <summary>
        /// Открытие соединения.
        /// </summary>
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        /// <summary>
        /// Закрытие соединения.
        /// </summary>
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        /// <summary>
        /// Получение соединения.
        /// </summary>
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}