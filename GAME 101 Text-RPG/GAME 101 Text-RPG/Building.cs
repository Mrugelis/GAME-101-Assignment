using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    //creates the game layout of rooms building a graph who's nodes are Rooms (Dictionary, other objects in room)
    class Building
    {
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

        public Building()
        {
            fillBuilding();
        }

        public void fillBuilding()
        {
             //fills Building with rooms
            
        }

        public void fillRooms()
        {
            R1_1.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 1"},
                { 2, "Look in dresser floor 1 room 1"},
                { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };

            //1 = floor 1 room 2
            R1_2.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 2"},
                { 2, "Look in dresser floor 1 room 2"},
                { 3, "Try to leave through entrance floor 1 room 2"},
                { 4, "Try to open door floor 1 room 2"},
                { 5, "Read letter floor 1 room 2"}
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
            //3 = floor 1 room 4
            R1_4.choices = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 4"},
                { 2, "Look in dresser floor 1 room 4"},
                { 3, "Try to leave through entrance floor 1 room 4"},
                { 4, "Try to open door floor 1 room 4"},
                { 5, "Read letter floor 1 room 4"}
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
        public string choice1;
        public string choice2;
        public string choice3;
        public string choice4;
        public string choice5;
};

