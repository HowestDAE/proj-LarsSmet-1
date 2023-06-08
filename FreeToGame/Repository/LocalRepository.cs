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

        public static async Task<List<Game>> GetGamesAsync()
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
                    json = await reader.ReadToEndAsync();
                    _games = JsonConvert.DeserializeObject<List<Game>>(json);
                }
            }

            return _games;
        }

        public static async Task<List<string>> GetGameGenresAsync()
        {
            List<Game> games = await GetGamesAsync();

            List<string> uniqueGenres = games.Select(game => game.Genre).Distinct().ToList();

            return uniqueGenres;
        }

        public static async Task<List<Game>> GetGamesAsync(string gameGenre)
        {
            List<Game> games = await GetGamesAsync();

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
