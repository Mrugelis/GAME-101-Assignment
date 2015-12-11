using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Player:Character
    {
        int score;
        int collect; //keyitem collection 0,1,2,3

        public Player()
        {
            collect = 0;
            score = 0;
            Location = 0;
            Health = 100;
            Experience = 0;
            Level = 1;
            Name = "";
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Collect
        {
            get { return collect; }
            set { collect = value; }

        }

        public void Reset()
        {
            Location = 0;
            Health = 250;
            Experience = 0;
            Level = 1;
            Name = "";
        }
    }
}
