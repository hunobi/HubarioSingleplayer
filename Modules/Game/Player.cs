using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using HubArioSinglePlayer.Modules.Game.CPlayer;

namespace HubArioSinglePlayer.Modules.Game
{
    internal class Player
    {
        protected Ellipse Player_Hero;
        protected int Player_Hero_Speed;
        protected int Player_Size;
        protected Collision Collision;

        public Player(Collision collision, Ellipse hero, int size)
        {
            Collision = collision;
            Player_Hero = hero;
            Player_Size = size;
            Player_Hero_Speed = 20;
        }

        public int GetPlayerHeroSpeed()
        {
            return Player_Hero_Speed; 
        }

        public void Move(KeyEventArgs e)
        {
            new HeroMove(Collision,Player_Hero,Player_Size).Move(e);
        }
    }
}
