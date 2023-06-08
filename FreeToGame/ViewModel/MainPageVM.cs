using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeToGame.View;
using FreeToGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FreeToGame.ViewModel
{
    public class MainPageVM : ObservableObject
    {


        public string CommandText
        {
            get
            {
                if (CurrentPage is OverviewPage)
                {
                    return "SHOW DETAILS";
                }
                else
                {
                    return "GO BACK";
                }
            }
        }
        public OverviewPage MainPage { get; } = new OverviewPage();
        public DetailPage GamePage { get; } = new DetailPage();
        public Page CurrentPage { get; set; }
        public RelayCommand SwitchPageCommand { get; private set; }

        public void SwitchPage()
        {
            if (CurrentPage is OverviewPage)
            {
                Game selectedGame = (MainPage.DataContext as OverViewPageVM).SelectedGame;
                if (selectedGame == null)
                {
                    return;
                }

                (GamePage.DataContext as DetailPageVM).CurrentGame = selectedGame; //detailpage gets filled up with selected game

                CurrentPage = GamePage;
            }
            else
            {
                CurrentPage = MainPage;
            }

            OnPropertyChanged(nameof(CurrentPage));
            OnPropertyChanged(nameof(CommandText));
        }

        public MainPageVM()
        {
            CurrentPage = MainPage;
            SwitchPageCommand = new RelayCommand(SwitchPage);
        }

    }
}
