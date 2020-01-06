using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Academic
{
    class Connect {
        private MySqlConnection connection;

        public Connect() {
            Initialize();
        }

        public MySqlConnection connectionResult() {
            return connection;
        }

        public static string connString()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=academics;User ID=root;Password=";
            //string connectionString = @"server=166.62.27.179;port=3306; UID=karmagurung2008; password=123456; database=academics; charset=utf8;Allow User Variables=True";
            return connectionString;
        }

        private void Initialize() {
            string connectionString = @"Data Source=localhost;Initial Catalog=academics;User ID=root;Password=";
            //string connectionString = @"server=166.62.27.179;port=3306; UID=karmagurung2008; password=123456; database=academics; charset=utf8;Allow User Variables=True";
            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.ToString());
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
