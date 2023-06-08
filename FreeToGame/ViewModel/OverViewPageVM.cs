using CommunityToolkit.Mvvm.ComponentModel;
using FreeToGame.Models;
using FreeToGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FreeToGame.ViewModel
{
    public class OverViewPageVM : ObservableObject
    {
        private List<string> _gameGenres { get; set; }
        public List<string> GameGenres
        {
            get {return _gameGenres;}

            set
            {
                _gameGenres = value;
                OnPropertyChanged(nameof(_gameGenres));
            }
            
        }

        private List<Game> _games = new List<Game>();

        public List<Game> Games
        {
            get {return _games;}
            set
            {
                _games = value;
                OnPropertyChanged(nameof(Games));
            }
        }

        private string _selectedGenre;

        public string SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                Games = LocalRepository.GetGames(value);
                OnPropertyChanged(nameof(Games));
                _selectedGenre = value;
            }
        }

        private Game _selectedGame;

        public Game SelectedGame
        {
            get { return _selectedGame; }
            set { _selectedGame = value; }
        }


        public OverViewPageVM()
        {
            GameGenres = LocalRepository.GetGameGenres();
            Games = LocalRepository.GetGames();
        }


    }
}
