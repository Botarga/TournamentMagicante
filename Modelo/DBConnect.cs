using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo

{
    public class DBConnect
    {
        private static readonly DBConnect instance = new DBConnect();
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        static DBConnect() { }
        private DBConnect() { Initialize(); }

        public static DBConnect Instance { get { return instance; } }


        //Initialize values
        private void Initialize()
        {
            server = "codedojo.es";
            database = "magicante";
            uid = "mycodedojo";
            password = "bordargadb2";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        //Insert statement
        public int Insert(string query)
        {
            int rows = 0;

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            try
            {
                rows = cmd.ExecuteNonQuery();
            }catch(MySqlException)
            {
            }

            return rows;
        }

        //Update statement
        public int Update(string query)
        {
            int rows = -1;
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            rows = cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();

            return rows;
        }

        //Delete statement
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public MySqlDataReader Select(string query)
        {
            MySqlDataReader result = null;
            

            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            result = cmd.ExecuteReader();
            

            return result;
        }

  
    }
}
