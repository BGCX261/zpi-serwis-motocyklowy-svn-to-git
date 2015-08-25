using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect(string userid, string userpassword)
        {
            uid = userid;
            password = userpassword;
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "baza";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool Autoryzacja()
        {
            if (this.OpenConnection() == true)
            {
                this.CloseConnection();
                return true;
            }
            else
                return false;
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Nie można połączyć się z bazą danych");
                        break;

                    case 1045:
                        MessageBox.Show("Nieprawidłowy login lub hasło");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert_Praca(int ID, string VIN, string marka, string model, int rocznik, string OC, DateTime data_zgloszenia, TimeSpan czas_zgloszenia, string opis, int IDklient, int IDserw)
        {
            string MyConString = "SERVER=localhost;" +
               "DATABASE=baza;" +
               "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            string query = "INSERT INTO naprawy (ID, VIN, marka, model, rocznik, termin_OC, data_zgloszenia, czas_zgloszenia, opis, ID_klienta, ID_serwisanta) VALUES(" + ID + ", '" + VIN + "', '" + marka + "', '" + model + "', " + rocznik + ", '" + OC + "', '" + data_zgloszenia + "', '" + czas_zgloszenia + "', '" + opis + "', " + IDklient + ", " + IDserw + ")";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement

        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Create_User(string login, string password)
        {
            //login.Replace(" ", "_");
            string query = "CREATE USER '" + login + "'@'localhost'; GRANT SELECT , INSERT ON * . * TO  '" + login + "'@'localhost';";
            string query2 = "SET PASSWORD FOR  '" + login + "'@'localhost' = PASSWORD(  '" + password + "' )";
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT VIN, opis, podpis FROM zdarzenie";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["VIN"] + "");
                    list[1].Add(dataReader["opis"] + "");
                    list[2].Add(dataReader["podpis"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }


    }
}
