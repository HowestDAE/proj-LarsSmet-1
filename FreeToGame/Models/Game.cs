using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FreeToGame.Models
{
    public class Game
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("short_description")]
        public string Description { get; set; }
        [JsonProperty("genre")]
        public string Genre { get; set; }
        [JsonProperty("platform")]
        public string Platform { get; set; }

        public string Thumbnail
        {
            get
            {
                return $"https://www.freetogame.com/g/{Id}/thumbnail.jpg";
            }
        }

        public string Game_Url
        {
            get
            {
                return $"https://www.freetogame.com/open/{Title}";
            }
        }

    }
}
