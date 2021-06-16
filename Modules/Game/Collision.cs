using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace HubArioSinglePlayer.Modules.Game
{
    class Collision
    {

        private int Map_OX, Map_OY;

        public Collision(int map_OX, int map_OY)
        {
            Map_OX = map_OX;
            Map_OY = map_OY;
        }

        public bool IfCollisionMap(int x, int y)
        {
            if (
                   //(Mapa.Width >= x) &&
                   // (Mapa.Height >= y) &&
                   (Map_OX >= x) &&
                   (Map_OY >= y) &&
                   (x >= 0) &&
                   (y >= 0)
              )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private class Punkt
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Punkt(double ox, double oy)
            {
                this.X = ox;
                this.Y = oy;
            }
        }
        public static bool IfCanEat(int x, int y, Ellipse hero)
        {

            double heroX = hero.Margin.Left;
            double heroY = hero.Margin.Top;
            if(Checker(new Punkt(x,y), new Punkt(heroX, heroY)))
            {
                return true;
            }
    
            return false;
        }

        private static bool Checker(Punkt food, Punkt player)
        {
            List<Punkt> lista = new List<Punkt>();
            lista.Add(new Punkt(food.X, food.Y - 10));
            lista.Add(new Punkt(food.X, food.Y + 10));
            lista.Add(new Punkt(food.X - 10, food.Y));
            lista.Add(new Punkt(food.X + 10, food.Y));
            lista.Add(new Punkt(food.X + 10, food.Y + 10));
            lista.Add(new Punkt(food.X - 10, food.Y - 10));


            foreach (Punkt punkt in lista)
            {
                if (
                    (punkt.X >= player.X - 5 && punkt.X <= player.X + 15) &&
                    (punkt.Y >= player.Y - 5 && punkt.Y <= player.Y + 15)
                   ) return true;
            }
            return false;
        }
    }
}
