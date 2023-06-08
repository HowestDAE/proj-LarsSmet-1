using CommunityToolkit.Mvvm.ComponentModel;
using FreeToGame.Models;
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

        private Game _currentGame = new Game()
        {
            Id = 540,
            Title = "Overwatch",
            Short_Description = "A hero-focused first-person team shooter from Blizzard Entertainment.",
            Genre = "Shooter",
            Platform = "PC (Windows)"

        };

        public Game CurrentGame
        {
            get => _currentGame;
            set
            {
                _currentGame = value;
                OnPropertyChanged(nameof(CurrentGame));
            }
        }


    }
}
