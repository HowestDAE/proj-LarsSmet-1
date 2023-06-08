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
        public int Id { get; set; }
        public string Title { get; set; }

        public string Short_Description { get; set; }

        public string Genre { get; set; }
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
