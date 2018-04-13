using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Location
    {
        public string Description { get; }

        public Location(string description)
        {
            Description = description;
        }

        public static List<Location> GetAll()
        {
            var result = new List<Location>();

            DBConnect.Instance.OpenConnection();
            var reader = DBConnect.Instance.Select("select description from location");
            if(reader != null)
            {
                while (reader.Read())
                    result.Add(new Location(reader.GetString(0)));
                reader.Close();
            }
            DBConnect.Instance.CloseConnection();

            return result;
        }

        public bool InsertDB()
        {
            bool result = false;

            DBConnect.Instance.OpenConnection();
            result = DBConnect.Instance.Insert("insert into location (description) values('" + Description + "');") > 0;

            DBConnect.Instance.CloseConnection();

            return result;
        }
    }
}
