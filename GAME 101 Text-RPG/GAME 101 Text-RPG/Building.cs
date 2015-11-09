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
            Rooms _1_1;
            Rooms _1_2;
            Rooms _1_3;
            Dictionary<int, Rooms> roomChoices = new Dictionary<int, Rooms>;    
        }
    }

    struct Rooms
    {
        public string choice1;
        public string choice2;
        public string choice3;
        public string choice4;
        public string choice5;
    };
}
