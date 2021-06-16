using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Controls;

namespace HubArioSinglePlayer.Modules.Game
{
    class Scores
    {
        //zewnetrzne
        Label score;
        Label cord;
        // wewnetrzne
        private int OX, OY;

        public Scores(Label score, Label cord)
        {
            this.score = score;
            this.cord = cord;
        }

        public void Update(Ellipse Hero)
        {
            GetHeroCord(Hero);
            SetHeroCord();
        }

        public void SetHeroScore(int ile)
        {
            score.Content = (Convert.ToInt32(score.Content) + ile).ToString();
        }

        private void SetHeroCord()
        {
            cord.Content = String.Format("[ {0} , {1} ]", OX, OY);
        }


        private void GetHeroCord(Ellipse Hero)
        {
            OX = (int)Hero.Margin.Left;
            OY = (int)Hero.Margin.Top;
        }
    }
}
