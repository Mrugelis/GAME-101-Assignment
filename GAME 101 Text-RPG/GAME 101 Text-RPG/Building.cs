using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    //creates the game layout of rooms building a graph who's nodes are rooms (dictionaries)
    class Building
    {

        public Building()
        {
            fillBuilding();
        }

        public void fillBuilding()
        {
             //fills Building with rooms
            Room R1_1;
            Room R1_2;
            Room R1_3;
            Room R1_4;
            Room R1_5;

            Room R2_1;
            Room R2_2;
            Room R2_3;
            Room R2_4;
            Room R2_5;

            Room R3_1;
            Room R3_2;
            Room R3_3;
            Room R3_4;
            Room R3_5;
        }
    }
}



struct Room
{
       public Dictionary<int,string> choice1;
        public string choice2;
        public string choice3;
        public string choice4;
        public string choice5;
};

