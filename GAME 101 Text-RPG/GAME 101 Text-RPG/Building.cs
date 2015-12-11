using GAME_101_Text_RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    //creates the game layout of rooms building a graph who's nodes are Rooms (Dictionary, other objects in room)
    //story currently is only using 1 "floor" of 5 rooms as of Dec 11 2015
    class Building
    {
        Room R_0; //contains title info, credit info
        Room gameTools; //contains generic strings to be used through the game
        Room errorList;

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

        Room final;

        Dictionary<int, Room> gameBuilding = new Dictionary<int, Room>();

        public Building()
        {
            fillRooms();
            fillBuilding();
        }

        public Dictionary<int, Room> getBuilding()
        {
            return gameBuilding;
        }

        public Room getRoom(int location)
        {
            return gameBuilding[location];
        }

        private void fillBuilding()
        {
            gameBuilding.Add(0, R_0);
            gameBuilding.Add(1, R1_1);
            gameBuilding.Add(2, R1_2);
            gameBuilding.Add(3, R1_3);
            gameBuilding.Add(4, R1_4);
            gameBuilding.Add(5, R1_5);
            gameBuilding.Add(6, R2_1);
            gameBuilding.Add(7, R2_2);
            gameBuilding.Add(8, R2_3);
            gameBuilding.Add(9, R2_4);
            gameBuilding.Add(10, R2_5);
            gameBuilding.Add(11, R3_1);
            gameBuilding.Add(12, R3_2);
            gameBuilding.Add(13, R3_3);
            gameBuilding.Add(14, R3_4);
            gameBuilding.Add(15, R3_5);
            gameBuilding.Add(16, gameTools);
            gameBuilding.Add(17, errorList);
        }
    
        private void fillRooms()
        {
            R_0.choices = new Dictionary<int, string>()
            {
                {0, "The Antechamber" },
                {1, "Start Game" },
                {2, "Credits" },
                {3, "Exit" }
            };
            R_0.results = new Dictionary<int, string>()
            {
                {0, "How long has it been...? I've been wandering and hiding for so long,\nI'm having a hard time recalling my own name, What is it again?" },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" }
            };
            R_0.string1 = "Welcome to the game";
            //floor 1 room 1
            R1_1.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 1"},
                { 2, "Look in dresser floor 1 room 1"},
                { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            R1_1.results = new Dictionary<int, string>()
            {
                {0, "Here it is again... This damned hall." },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" },
                 { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            //R1_1.main = "It has been a long time since I've been here... I wonder where they left "
            //1 = floor 1 room 2
            R1_2.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 2"},
                { 2, "Look in dresser floor 1 room 2"},
                { 3, "Try to leave through entrance floor 1 room 2"},
                { 4, "Try to open door floor 1 room 2"},
                { 5, "Read letter floor 1 room 2"}
            };
            R1_2.results = new Dictionary<int, string>()
            {
                {0, "Here it is again... This damned hall." },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" },
                 { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            //2 = floor 1 room 3
            R1_3.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 3"},
                { 2, "Look in dresser floor 1 room 3"},
                { 3, "Try to leave through entrance floor 1 room 3"},
                { 4, "Try to open door floor 1 room 3"},
                { 5, "Read letter floor 1 room 3"}
            };
            R1_3.results = new Dictionary<int, string>()
            {
                {0, "Here it is again... This damned hall." },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" },
                 { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            //3 = floor 1 room 4
            R1_4.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 4"},
                { 2, "Look in dresser floor 1 room 4"},
                { 3, "Try to leave through entrance floor 1 room 4"},
                { 4, "Try to open door floor 1 room 4"},
                { 5, "Read letter floor 1 room 4"}
            };
            R1_4.results = new Dictionary<int, string>()
            {
                {0, "Here it is again... This damned hall." },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" },
                 { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            //4 = floor 1 room 5
            R1_5.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 5"},
                { 2, "Look in dresser floor 1 room 5"},
                { 3, "Try to leave through entrance floor 1 room 5"},
                { 4, "Try to open door floor 1 room 5"},
                { 5, "Read letter floor 1 room 5"}
            };
            R1_5.results = new Dictionary<int, string>()
            {
                {0, "Here it is again... This damned hall." },
                {1, "Ahh, yes {0}... {0}... {0}. The name is all I have left after what happened. \nI can't let it escape me as well. It's been 3 weeks since the incident. \n I think things have settled down enough for me \nto try to get out of this decrepit place." },
                { 2, "Designed and programmed by Martins Rugelis, 2015" },
                 { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };
            //5 = floor 2 room 1
            R2_1.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2f room 1"},
                { 2, "Look in dresser floor 2 room 1"},
                { 3, "Try to leave through entrance floor 2 room 1"},
                { 4, "Try to open door floor 2 room 1"},
                { 5, "Read letter floor 2 room 1"}
            };
            //6 = floor 2 room 2
            R2_2.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 2"},
                { 2, "Look in dresser floor 2 room 2"},
                { 3, "Try to leave through entrance floor 2 room 2"},
                { 4, "Try to open door floor 2 room 2"},
                { 5, "Read letter floor 2 room 2"}
            };
            //7 = floor 2 room 3
            R2_3.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 3"},
                { 2, "Look in dresser floor 2 room 3"},
                { 3, "Try to leave through entrance floor 2 room 3"},
                { 4, "Try to open door floor 2 room 3"},
                { 5, "Read letter floor 2 room 3"}
            };
            //8 = floor 2 room 4
            R2_4.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 4"},
                { 2, "Look in dresser floor 2 room 4"},
                { 3, "Try to leave through entrance floor 2 room 4"},
                { 4, "Try to open door floor 2 room 4"},
                { 5, "Read letter floor 2 room 4"}
            };
            //9 = floor 2 room 5
            R2_5.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 5"},
                { 2, "Look in dresser floor 2 room 5"},
                { 3, "Try to leave through entrance floor 2 room 5"},
                { 4, "Try to open door floor 2 room 5"},
                { 5, "Read letter floor 2 room 5"}
            };
            //10 = floor 3 room 1
            R3_1.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 1"},
                { 2, "Look in dresser floor 3 room 1"},
                { 3, "Try to leave through entrance floor 3 room 1"},
                { 4, "Try to open door floor 3 room 1"},
                { 5, "Read letter floor 3 room 1"}
            };
            //11 = floor 3 room 2
            R3_2.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 2"},
                { 2, "Look in dresser floor 3 room 2"},
                { 3, "Try to leave through entrance floor 3 room 2"},
                { 4, "Try to open door floor 3 room 2"},
                { 5, "Read letter floor 3 room 2"}
            };
            //12 = floor 3 room 3
            R3_3.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 3"},
                { 2, "Look in dresser floor 3 room 3"},
                { 3, "Try to leave through entrance floor 3 room 3"},
                { 4, "Try to open door floor 3 room 3"},
                { 5, "Read letter floor 3 room 3"}
            };
            //13 = floor 3 room 4
            R3_4.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 4"},
                { 2, "Look in dresser floor 3 room 4"},
                { 3, "Try to leave through entrance floor 3 room 4"},
                { 4, "Try to open door floor 3 room 4"},
                { 5, "Read letter floor 3 room 4"}
            };
            //14 = floor 3 room 5
            R3_5.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 5"},
                { 2, "Look in dresser floor 3 room 5"},
                { 3, "Try to leave through entrance floor 3 room 5"},
                { 4, "Try to open door floor 3 room 5"},
                { 5, "Read letter floor 3 room 5"}
            };
        }
    }
}


struct Room
{
        public Dictionary<int,string> choices;
        public Dictionary<int, string> results;
        public string string1;
        public Enemy enemy;
        public int string3;
        public string string4;
        public string string5;
};

