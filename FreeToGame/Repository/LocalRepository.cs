using FreeToGame.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FreeToGame.Repository
{
    public class LocalRepository
    {
        private static List<Game> _games;

        public static List<Game> GetGames()
        {
            if (_games != null)
            {
                return _games;
            }

            var assembly = Assembly.GetExecutingAssembly();


            var resource = "FreeToGame.Resources.Data.FreeGames.json";

            string json;

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (var reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                    _games = JsonConvert.DeserializeObject<List<Game>>(json);
                }
            }

            return _games;
        }

        public static List<string> GetGameGenres()
        {
            List<Game> games = GetGames();

            List<string> uniqueGenres = games.Select(game => game.Genre).Distinct().ToList();

            return uniqueGenres;
        }

        public static List<Game> GetGames(string gameGenre)
        {
            List<Game> games = GetGames();

            List<Game> gamesOfGenre = new List<Game>();
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Genre.Equals(gameGenre))
                {
                    gamesOfGenre.Add(games[i]);
                }
            }

            return gamesOfGenre;
        }

    }
}
