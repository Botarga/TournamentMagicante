using Modelo;
using System;
using System.Collections.Generic;


namespace Vista
{
    public class Utils
    {
        public static bool ValidateLogin(string user, string pass)
        {
            return Player.Validate(user, pass);
        }

        public static List<string> ObtainTournamentFormats()
        {
            List<string> result = new List<string>();

            var data = GameMode.GetAll();
            foreach(GameMode g in data)
                result.Add(g.Description);

            return result;
        }

        public static List<string> ObtainLocations()
        {
            List<string> result = new List<string>();

            var data = Location.GetAll();
            foreach (Location l in data)
                result.Add(l.Description);

            return result;
        }

        public static bool InsertNewLocation(string name)
        {
            bool result = false;

            Location newLoc = new Location(name);
            result = newLoc.InsertDB();


            return result;
        }

        public static Dictionary<string, string> ObtainPlayerdata(int cod)
        {
            var result = new Dictionary<string, string>();
            Player p = Player.GetPlayerData(cod);
            result.Add("username", p.Username);
            result.Add("name", p.Name);
            result.Add("age", "" + p.Age);
            result.Add("location", p.Location);

            return result;
        }

        public static bool UpdatePlayerData(Dictionary<string, string> playerData)
        {
            Player p = new Player(playerData);
            return p.UpdateData() > 0;
        }

        public static int ObtainPlayerCode(string username)
        {
            return Player.ObtainPlayerCode(username);
        }

        public static bool UpdatePlayerPassword(int cod, string newPassword)
        {
            return Player.UpdatePlayerPassword(cod, newPassword) > 0;
        }
    }
}
