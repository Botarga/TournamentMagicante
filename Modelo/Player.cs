using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Player
    {
        public int      Age         { get; set; }
        public string   Name        { get; set; }
        public string   Location    { get; set; }
        public string   Username    { get; set; }
        public string   Password    { get; set; }
        public int      Cod { get; private set; }

        private Player() { }

        public Player(string name, int age, string location,
            string username, string password)
        {
            Name        = name;
            Age         = age;
            Location    = location;
            Username    = username;
            Password    = password;
        }

        public Player(Dictionary<string, string> data)
        {
            Name = data["name"];
            Age = Convert.ToInt32(data["age"]);
            Location = data["location"];
            Username = data["username"];
            Cod = Convert.ToInt32(data["cod"]);
        }

        public static bool Validate(string username, string pass)
        {
            bool result = false;

            DBConnect.Instance.OpenConnection();

            var reader = DBConnect.Instance.Select("select cod from player where username = '" + username +
                "' and password = md5('" + pass + "');");
            if (reader != null)
            {
                if (reader.Read())
                    result = true;
                reader.Close();
            }

            DBConnect.Instance.CloseConnection();
            return result;
        }

        public static Player GetPlayerData(int cod)
        {
            Player result = new Player();

            DBConnect.Instance.OpenConnection();
            string query = "select p.*, l.description from player p, location l where p.cod =" +
                cod + " and l.cod = p.id_location";
            var reader = DBConnect.Instance.Select(query);
            if(reader != null)
            {
                reader.Read();
                result.Cod = cod;
                result.Name = reader["name"] + "";
                result.Location = reader["description"] + "";
                result.Username = reader["username"] + "";

                int age = -1;
                if (Int32.TryParse(reader["age"] + "", out age))
                    result.Age = age;

                reader.Close();    
            }

            DBConnect.Instance.CloseConnection();

            return result;
        }

        public int UpdateData()
        {
            int rows = -1;

            DBConnect.Instance.OpenConnection();
            string query = "update player set name = '" + Name +"', username = '"+
                Username + "', age = "+ Age + ", id_location = (select cod from location where description = '" + Location + "') " +
                " where cod = " + Cod + ";";
            rows = DBConnect.Instance.Insert(query);

            DBConnect.Instance.CloseConnection();
            return rows;
        }

        public static int ObtainPlayerCode(string username)
        {
            int code = -1;

            DBConnect.Instance.OpenConnection();
            var reader = DBConnect.Instance.Select("select cod from player where username = '" + username + "';");
            if(reader != null)
            {
                reader.Read();
                code = Convert.ToInt32(reader.GetInt32(0));
                reader.Close();
            }

            DBConnect.Instance.CloseConnection();
            return code;
        }

        public static int UpdatePlayerPassword(int cod, string newPassword)
        {
            int rows = -1;

            DBConnect.Instance.OpenConnection();
            string query = "Update player set password = md5('" + newPassword + "') where cod = " + cod + ";";
            rows = DBConnect.Instance.Update(query);

            return rows;
        }

    }
}
