using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HubArioSinglePlayer.Modules.Game
{
    class Game
    {
        private int Game_Window_Width;
        private int Game_Window_Height;

        private Ellipse Hero;
        private Grid Mapa;
        private Label Score, Cord;

        private Food food;
        private Player player;
        private Collision collision;
        private Scores scores;

        public Game(Ellipse hero, Grid mapa, Label cord, Label score)
        {
            Mapa = mapa;
            Hero = hero;
            Score = score;
            Cord = cord;
            Game_Window_Width = 960;
            Game_Window_Height = 720;
            
        }

        public void Start()
        {
            collision = new Collision(Game_Window_Width, Game_Window_Height);
            player = new Player(collision, Hero, 40);
            food = new Food(player.GetPlayerHeroSpeed(),Mapa, Hero);
            scores = new Scores(Score,Cord);
            scores.Update(Hero);
            FoodTimer();
        }

        public void Update(KeyEventArgs e)
        {
            player.Move(e);
            scores.Update(Hero);
            scores.SetHeroScore(food.EatFood());
        }
        
        public void FoodTimer()
        {
            System.Timers.Timer food = new System.Timers.Timer();
            food.Elapsed += new System.Timers.ElapsedEventHandler(GeneratedFood);          
            food.Interval = 2000;
            food.Enabled = true;
        }
        
        private void GeneratedFood(object source, System.Timers.ElapsedEventArgs e)
        {
            var dispatcher = Dispatcher.CurrentDispatcher;
            if (Application.Current != null)
            {
                dispatcher = Application.Current.Dispatcher;
            }

            if (dispatcher != null)
            {
                dispatcher.Invoke(
                    delegate
                    {
                        food.CreateFood();
                    });
            }         
        }
    }
}
