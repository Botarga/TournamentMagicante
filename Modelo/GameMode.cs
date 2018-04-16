using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class GameMode
    {
        public string Description { get; }

        public GameMode(string description)
        {
            Description = description;
        }

        public static List<GameMode> GetAll()
        {
            List<GameMode> result = new List<GameMode>();

            DBConnect.Instance.OpenConnection();
            var reader = DBConnect.Instance.Select("select description from game_mode");
            if (reader != null)
            {
                while (reader.Read())
                    result.Add(new GameMode(reader.GetString(0)));
                reader.Close();
            }

            DBConnect.Instance.CloseConnection();

            return result;
        }
    }
}
