using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HubArioSinglePlayer.Modules.Game;


namespace HubArioSinglePlayer
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game Game;
        public MainWindow()
        {
            InitializeComponent();
            Game = new Game(Hero, Mapa, Label_Player_Cord, Label_Player_Scores);
            Game.Start();
            
        }

        private void Hero_Move(object sender, KeyEventArgs e)
        {
            Game.Update(e);
        }

        /*
        private void FoodTimer()
        {
            System.Timers.Timer food = new System.Timers.Timer();
            food.Elapsed += new System.Timers.ElapsedEventHandler(GeneratedFood);
            food.Interval = 2000;
            food.Enabled = true;
        }

        private void GeneratedFood(object source, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.Invoke((Action)delegate {
                food.CreateFood();
            });
        }
        */
    }
}
