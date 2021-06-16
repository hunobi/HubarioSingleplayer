using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HubArioSinglePlayer.Modules.Game
{
    class Food
    {
        private int Heroes_Speed;
        private int Player_Size;
        private Ellipse Hero;
        private Grid Map;
        private List<Ellipse> FoodList = new List<Ellipse>();
        

        public Food(int SpeedPlayer, Grid mapa, Ellipse Hero)
        {
            this.Heroes_Speed = SpeedPlayer;
            Map = mapa;
            this.Hero = Hero;
            Player_Size = (int)Hero.Height;
        }

        public int EatFood()
        {

           // Console.WriteLine("x = {0} ; y = {1}", VecOX.Count, VecOY.Count);
            for(int i = 0; i < FoodList.Count; i++)
            {
                int x = (int)FoodList.ElementAt(i).Margin.Left;
                int y = (int)FoodList.ElementAt(i).Margin.Top;

                if(Collision.IfCanEat(x,y, Hero))
                {
                    Map.Children.Remove(FoodList.ElementAt(i));
                    FoodList.RemoveAt(i);
                    
                    return 1;
                }
            }

            return 0;
        }
     
        public void CreateFood()
        {            
            Random r = new Random();
            double x = 1;
            while (x % Heroes_Speed != 0) x = r.Next(0, 960);
            double y = 1;
            while (y % Heroes_Speed != 0) y = r.Next(0, 720);
            Ellipse temp = new Ellipse();
            temp.Width = 20;
            temp.Height = 20;
            temp.Fill = System.Windows.Media.Brushes.Yellow;
            temp.HorizontalAlignment = HorizontalAlignment.Left;
            temp.VerticalAlignment = VerticalAlignment.Top;
            temp.Margin = new Thickness(x, y, 0, 0);

            Map.Children.Add(temp);
            FoodList.Add(temp);
        }
    }
}
