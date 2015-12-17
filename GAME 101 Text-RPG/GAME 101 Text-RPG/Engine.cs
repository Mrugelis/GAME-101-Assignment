using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Engine
    {
        int location;
        int input;
        int item;
        bool gameRunning;
        string title = "This is the Game Name";
        Building build = new Building();
        Dictionary<int, Room> building;
        Dictionary<int, string> currentChoices;
        Dictionary<int, string> currentResults;
        Dictionary<int, Enemy> enemyList;
        Room currentRoom;
        Dictionary<int, int> collected = new Dictionary<int, int>
        {
            {1,0},
            {2,0},
            {3,0},
            {4,0},
            {5,0},
        };

        public Engine()
        {
            location = 0;
            input = 1;
            building = build.getBuilding();
            gameRunning = true;
            enemyList = Enemy.generateEnemyList();
        }

        public void Reset()
        {
            location = 0;
            input = 1;
            building = build.getBuilding();
            gameRunning = true;
        }

        public Dictionary<int, int> Collected
        {
            get { return collected; }
            set { collected = value; }
        }
        public Dictionary<int,string> Choices
        {
            get { return currentChoices; }
            set { currentChoices = value; }
        }
        public Dictionary<int, string> Results
        {
            get { return currentResults; }
            set { currentResults = value; }
        }
        public Dictionary<int, Enemy> EnemyList
        {
            get { return enemyList; }
            set { enemyList = value; }
        }
        public Room RoomInstance 
        {
            get { return currentRoom; }
            set { currentRoom = value; }
        }
        public int Location
        {
            get { return location; }
            set { location = value; }
        }

        public bool GameRunning
        {
            get { return gameRunning; }
            set { gameRunning = value; }
        }

        public int Input
        {
            get { return input; }
            set { input = value; }
        }

        public int Item
        {
            get { return item; }
            set { item = value; }
        }
        public string TitleScreen
        {
            get { return title; }
        }
        public static int rnd()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }
        public static string getInput()
        {
            string name = Console.ReadLine();
            return name;
        }

        public static int userInput(int index)
        {
            int choice;
            if (Int32.TryParse(Console.ReadLine(), out choice) && 0 <= choice && choice <= index)
            {
                return choice;
            }
            else
            {
//                Console.WriteLine("Invalid choice");
                return userInput(choice);
            }
        }

        public static int Read()
        {
            int choice;
            if (Int32.TryParse(Console.ReadLine(), out choice))
            {
                return choice;
            }
            else
            {
                //                Console.WriteLine("Invalid choice");
                return Read();
            }
        }
        
        public static string ReadLine()
        {
            return Console.ReadLine();
        }
        public static void Clear()
        {
            Console.Clear();
        }

        public static void Draw(string story, string pname)
        {
            Console.WriteLine(story, pname);
        }
        public static void Draw(Dictionary<int, string> roomChoices, int location)
        {
            if (location != 0) { 
            for (int i = 1; i <= roomChoices.Count; i++)
            {
                Console.WriteLine("{0}: " + roomChoices[i], i);
            }
        }
            else
            {
                for (int i = 1; i < roomChoices.Count; i++)
                {
                    Console.WriteLine("{0}: " + roomChoices[i], i);
                }
            }
        }
        public static void Draw(Player player) //draws the scorecard and stats
        {
            Console.WriteLine("Score: '{0}' Health: '{1}' Name: '{2}' Level: {3}\n\n", player.Score, player.Health, player.Name, player.Level);
        }
        public static void Draw(Player player, Enemy enemy)
        {
            Console.WriteLine("Score: '{0}' Health: '{1}' Name: '{2}' Damage: '{3}'\n\n", player.Score, player.Health, player.Name, player.Damage());
            Console.WriteLine("Health: '{0}' Name: '{1}'\n\n", enemy.Health, enemy.Name);

        }
        public static void Draw(string str)
        {
            Console.WriteLine(str);
        }

       /* public  string getString(int location)
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
                int choice = getChoiceList(location).Count;
                return currentRoom(location)[userInput(choice)];
            }
        }
     */
        public Dictionary<int, string> getChoiceList(int index)
        {
            //index is the choice the player makes at a decision point
            //location is which room the player is in
            //0 = floor 1 room 1

        /*    Dictionary<int, string> f1R1 = new Dictionary<int, string>()
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

            */
            if (index >= 0 && index <=16)
            {
                //return the choices in current room
                return currentRoom.choices;
            }
            else
            {
                //return list of error strings
                return build.getRoom(17).choices;
            }
        }
        public void Update(Player player, int choice)
        {
            Input = choice;
            RoomInstance = build.getRoom(player.Location);
            Choices = currentRoom.choices;
            Results = currentRoom.results;
            Item = currentRoom.item;
        }
        
        public Boolean Combat(Player player)
        {
            Enemy enemy = currentRoom.enemy;
            if(enemy.Health <= 0 || player.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean hasEnemy(int choice)
        {
            if(currentRoom.enemy.Location == choice)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void doCombat(Player player, ref bool escape, int choice, ref bool newGame)
        {
            string answer;
            if (hasEnemy(choice) && RoomInstance.enemy.Alive == true) 
            {
                while (Combat(player))
                {
                    Engine.Clear(); //clear screen to draw combat
                    Engine.Draw(player, RoomInstance.enemy);
                    Engine.Draw("1: Attack\n 2:Run");
                    choice = Engine.userInput(2);
                    switch (choice)
                    {
                        case 0: //return to title
                            Engine.Draw("Are you sure you want to return to the main menu? Y/N"); //all string literals in Program.cs will be moved to a dictionary object to be referenced
                            answer = Engine.getInput();
                            if (answer == "y" || answer == "Y")
                            {
                                GameRunning = false;
                                newGame = true;
                                Engine.Clear();
                            }
                            break;
                        case 1:
                            Console.WriteLine("You attack with {0}, doing {1} damage to the {2}", player.weaponName(), player.Damage(), RoomInstance.enemy.Name);
                            RoomInstance.enemy.Health -= player.Damage();
                            if (Engine.rnd() < 4)
                            {
                                Console.WriteLine("On counter attack, {0} hits you for {1} damage.", RoomInstance.enemy.Name, RoomInstance.enemy.WeaponDamage);
                                player.Health -= RoomInstance.enemy.WeaponDamage;
                            }
                            Engine.ReadLine();

                            break;
                        case 2:
                            if (Engine.rnd() < 2)
                            {
                                Console.WriteLine("You fail to escape, {0} hits you for {1} damage.", RoomInstance.enemy.Name, RoomInstance.enemy.WeaponDamage);
                                player.Health -= RoomInstance.enemy.WeaponDamage;
                                Engine.ReadLine();

                            }
                            else
                            {
                                escape = true;
                            }
                            break;
                        default:
                            choice = Engine.userInput(2);

                            break;
                    }
                    if (escape == true && player.Location < 5)
                    {
                        Engine.Draw("You get away safely, but the monster still lurks");
                        Engine.ReadLine();
                        break;
                    }
                    else
                    {
                        Engine.Draw("You cannot escape this battle!");
                    }

                }
                if (player.Health == 0)
                {
                    Engine.Clear();
                    Console.WriteLine("Game Over");
                    Engine.Draw(player);
                    Engine.Draw("\nPress Enter to return to the title screen.");
                    Engine.ReadLine();
                    GameRunning = false;
                    newGame = true;
                    Engine.Clear();
                }
                else if (escape == false)
                {
                    Engine.Draw("\nHurray you killed the monster!");
                    player.weaponGet().WeaponLevel++;
                    player.Score += RoomInstance.enemy.Points;

                    player.Level++;
                    player.weaponGet().WeaponLevel++;
                    RoomInstance.enemy.Alive = false;
                    if (player.Health < Player.maxHP / 4)
                    {
                        Engine.Draw("You consume the soul of your fallen enemy, restoring your health");

                        player.Health = Player.maxHP;
                    }
                }
                Engine.ReadLine();
            }
        }
        //what is in a Room
        /* struct Room
         {
             public Dictionary<int, string> choices;
             public string choice1;
             public string choice2;
             public string choice3;
             public string choice4;
             public string choice5;
         }*/
    }
}

