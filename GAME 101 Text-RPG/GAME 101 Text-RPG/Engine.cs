using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Engine
    {
        int input;
        string title = "Welcome to the game: 1 for start 0 to quit.";
     /* Building build = new Building(); 
            Creates a building object a graph of structs, 
            where location is used to access a node pointing to the current room
        */
        public Engine(int ploc)
        {
            location = ploc;
            input = 1;
        }

        public static int Location(int choice)
        {
            int where = choice;
            return where;
        }

        public int Input
        {
            get { return input; }
            set { input = value; }
        }

        public static int userInput(int index)
        {
            int choice;
            if (Int32.TryParse(Console.ReadLine(), out choice) && 0 <= choice && choice <= index)
            {
                Location(choice);
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return userInput(choice);
            }
        }
        
        public string TitleScreen
        {

            get { return title; }
            
        }
 
        public static void Draw(Dictionary<int, string> room)
        {
            for (int i = 1; i <= room.Count; i++)
            {
                Console.WriteLine(room[i]);
            }
        }
    
        public static void Draw(string str)
        {
            Console.WriteLine(str);
        }

        public static string getString(int location)
        {
            //input is the location of the player
            //output is a story string from that locations dictionary
            if (location > 15 || location < 1)
            {
                //Throws error
                return getRoom(16)[1];
            }
            else
            {
                int choice = getRoom(location).Count;
                return getRoom(location)[userInput(choice)];
            }
        }
     
        public static Dictionary<int, string> getRoom(int index)
        {
            //index is the choice the player makes at a decision point
            //location is which room the player is in
            //0 = floor 1 room 1
            Dictionary<int, string> f1R1 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 1"},
                { 2, "Look in dresser floor 1 room 1"},
                { 3, "Try to leave through entrance floor 1 room 1"},
                { 4, "Try to open door floor 1 room 1"},
                { 5, "Read letter floor 1 room 1"}
            };

            //1 = floor 1 room 2
            Dictionary<int, string> f1R2 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 2"},
                { 2, "Look in dresser floor 1 room 2"},
                { 3, "Try to leave through entrance floor 1 room 2"},
                { 4, "Try to open door floor 1 room 2"},
                { 5, "Read letter floor 1 room 2"}
            };
            //2 = floor 1 room 3
            Dictionary<int, string> f1R3 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 3"},
                { 2, "Look in dresser floor 1 room 3"},
                { 3, "Try to leave through entrance floor 1 room 3"},
                { 4, "Try to open door floor 1 room 3"},
                { 5, "Read letter floor 1 room 3"}
            };
            //3 = floor 1 room 4
            Dictionary<int, string> f1R4 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 4"},
                { 2, "Look in dresser floor 1 room 4"},
                { 3, "Try to leave through entrance floor 1 room 4"},
                { 4, "Try to open door floor 1 room 4"},
                { 5, "Read letter floor 1 room 4"}
            };
            //4 = floor 1 room 5
            Dictionary<int, string> f1R5 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 1 room 5"},
                { 2, "Look in dresser floor 1 room 5"},
                { 3, "Try to leave through entrance floor 1 room 5"},
                { 4, "Try to open door floor 1 room 5"},
                { 5, "Read letter floor 1 room 5"}
            };
            //5 = floor 2 room 1
            Dictionary<int, string> f2R1 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2f room 1"},
                { 2, "Look in dresser floor 2 room 1"},
                { 3, "Try to leave through entrance floor 2 room 1"},
                { 4, "Try to open door floor 2 room 1"},
                { 5, "Read letter floor 2 room 1"}
            };
            //6 = floor 2 room 2
            Dictionary<int, string> f2R2 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 2"},
                { 2, "Look in dresser floor 2 room 2"},
                { 3, "Try to leave through entrance floor 2 room 2"},
                { 4, "Try to open door floor 2 room 2"},
                { 5, "Read letter floor 2 room 2"}
            };
            //7 = floor 2 room 3
            Dictionary<int, string> f2R3 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 3"},
                { 2, "Look in dresser floor 2 room 3"},
                { 3, "Try to leave through entrance floor 2 room 3"},
                { 4, "Try to open door floor 2 room 3"},
                { 5, "Read letter floor 2 room 3"}
            };
            //8 = floor 2 room 4
            Dictionary<int, string> f2R4 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 4"},
                { 2, "Look in dresser floor 2 room 4"},
                { 3, "Try to leave through entrance floor 2 room 4"},
                { 4, "Try to open door floor 2 room 4"},
                { 5, "Read letter floor 2 room 4"}
            };
            //9 = floor 2 room 5
            Dictionary<int, string> f2R5 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 2 room 5"},
                { 2, "Look in dresser floor 2 room 5"},
                { 3, "Try to leave through entrance floor 2 room 5"},
                { 4, "Try to open door floor 2 room 5"},
                { 5, "Read letter floor 2 room 5"}
            };
            //10 = floor 3 room 1
            Dictionary<int, string> f3R1 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 1"},
                { 2, "Look in dresser floor 3 room 1"},
                { 3, "Try to leave through entrance floor 3 room 1"},
                { 4, "Try to open door floor 3 room 1"},
                { 5, "Read letter floor 3 room 1"}
            };
            //11 = floor 3 room 2
            Dictionary<int, string> f3R2 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 2"},
                { 2, "Look in dresser floor 3 room 2"},
                { 3, "Try to leave through entrance floor 3 room 2"},
                { 4, "Try to open door floor 3 room 2"},
                { 5, "Read letter floor 3 room 2"}
            };
            //12 = floor 3 room 3
            Dictionary<int, string> f3R3 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 3"},
                { 2, "Look in dresser floor 3 room 3"},
                { 3, "Try to leave through entrance floor 3 room 3"},
                { 4, "Try to open door floor 3 room 3"},
                { 5, "Read letter floor 3 room 3"}
            };
            //13 = floor 3 room 4
            Dictionary<int, string> f3R4 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 4"},
                { 2, "Look in dresser floor 3 room 4"},
                { 3, "Try to leave through entrance floor 3 room 4"},
                { 4, "Try to open door floor 3 room 4"},
                { 5, "Read letter floor 3 room 4"}
            };
            //14 = floor 3 room 5
            Dictionary<int, string> f3R5 = new Dictionary<int, string>()
            {
                { 1, "Look in closet floor 3 room 5"},
                { 2, "Look in dresser floor 3 room 5"},
                { 3, "Try to leave through entrance floor 3 room 5"},
                { 4, "Try to open door floor 3 room 5"},
                { 5, "Read letter floor 3 room 5"}
            };
            Dictionary<int, string> error = new Dictionary<int, string>()
            {
                {1,"That is not a floor or room in this building" }
            };

            Dictionary<int, string> title = new Dictionary<int, string>()
            {
                {1,"Start the game!" },
                {2,"Quit."}
            };
            Dictionary<int, Dictionary<int, string>> building = new Dictionary<int, Dictionary<int, string>>()
            {
                {0,title },
                { 1, f1R1},
                { 2, f1R2},
                { 3, f1R3},
                { 4, f1R4},
                { 5, f1R5},
                { 6, f2R1},
                { 7, f2R2},
                { 8, f2R3},
                { 9, f2R4},
                { 10, f2R5},
                { 11, f3R1},
                { 12, f3R2},
                { 13, f3R3},
                { 14, f3R4},
                { 15, f3R5},
                {16, error }
            };

    
            if (index > 0 && index <=16)
            {
                return building[index];
            }
            else
            {

                return error;
            }
        }

        //what is in a Room
        struct Room
        {
            public Dictionary<int, string> choices;
            public string choice1;
            public string choice2;
            public string choice3;
            public string choice4;
            public string choice5;
        }
    }
}

