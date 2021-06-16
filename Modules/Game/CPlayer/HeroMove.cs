using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace HubArioSinglePlayer.Modules.Game.CPlayer
{
    class HeroMove : Player
    {
        public HeroMove(Collision collision, Ellipse hero, int size) : base(collision, hero, size)
        {
        }

        public new void Move(KeyEventArgs e)
        {
            List<double> cord = new List<double> { Player_Hero.Margin.Left, Player_Hero.Margin.Top, Player_Hero.Margin.Right, Player_Hero.Margin.Bottom };
            if (e.Key == Key.R)
            {
                Player_Hero.Margin = new Thickness(400, 200, cord.ElementAt(2), cord.ElementAt(3));
            }

            if (e.Key == Key.Up)
            {
                List<double> temp = new List<double> { cord.ElementAt(0), cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0), cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }
            if (e.Key == Key.Down)
            {
                List<double> temp = new List<double> { cord.ElementAt(0), cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0), cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }
            if (e.Key == Key.Left)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1), cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1), cord.ElementAt(2), cord.ElementAt(3));
                }
            }
            if (e.Key == Key.Right)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1), cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1), cord.ElementAt(2), cord.ElementAt(3));
                }
            }

            if (e.Key == Key.Up && e.Key == Key.Left)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }

            if (e.Key == Key.Up && e.Key == Key.Right)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1) - 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }

            if (e.Key == Key.Down && e.Key == Key.Left)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) - 1 * Player_Hero_Speed, cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }

            if (e.Key == Key.Down && e.Key == Key.Right)
            {
                List<double> temp = new List<double> { cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3) };
                if (Collision.IfCollisionMap((int)temp.ElementAt(0), (int)temp.ElementAt(1)))
                {
                    Player_Hero.Margin = new Thickness(cord.ElementAt(0) + 1 * Player_Hero_Speed, cord.ElementAt(1) + 1 * Player_Hero_Speed, cord.ElementAt(2), cord.ElementAt(3));
                }
            }
        }
    }
}
