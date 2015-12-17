using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    //Contains and controls the game data and structure
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
            Console.WriteLine("Score: {0}. Health: {1}. Name: {2}. Level: {3}. Key Items Found: {4}/3\n\n", player.Score, player.Health, player.Name, player.Level, player.Collect);
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

        public Dictionary<int, string> getChoiceList(int index)
        {
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
        
        public Boolean Combat(Player player) //checks to see if combat still should be run
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
        public Boolean hasEnemy(int choice) //checks if there is an enemy at the location chosen
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
                    escape = false;
                    Clear(); //clear screen to draw combat
                    Draw(player, RoomInstance.enemy);
                    Draw("1: Attack\n 2:Run");
                    choice = userInput(2);
                    switch (choice)
                    {
                        case 0: //return to title
                            Draw("Are you sure you want to return to the main menu? Y/N"); 
                            answer = getInput();
                            if (answer == "y" || answer == "Y")
                            {
                                GameRunning = false;
                                newGame = true;
                                Clear();
                            }
                            break;
                        case 1://attack
                            Console.WriteLine("You attack with {0}, doing {1} damage to the {2}", player.weaponName(), player.Damage(), RoomInstance.enemy.Name);
                            RoomInstance.enemy.Health -= player.Damage();
                            if (rnd() < 4)
                            {
                                Console.WriteLine("On counter attack, {0} hits you for {1} damage.", RoomInstance.enemy.Name, RoomInstance.enemy.WeaponDamage);
                                player.Health -= RoomInstance.enemy.WeaponDamage;
                            }
                            ReadLine();

                            break;
                        case 2://try to run
                            if (rnd() < 2)
                            {
                                Console.WriteLine("You fail to escape, {0} hits you for {1} damage.", RoomInstance.enemy.Name, RoomInstance.enemy.WeaponDamage);
                                player.Health -= RoomInstance.enemy.WeaponDamage;
                                ReadLine();

                            }
                            else
                            {
                                escape = true;
                            }
                            break;
                        default:
                            choice = userInput(2);

                            break;
                    }
                    if (escape == true && player.Location < 5)
                    {
                        Draw("You get away safely, but the monster still lurks");
                        ReadLine();
                        break;
                    }
                    else if(escape == true && player.Location == 5)
                    {
                        Draw("You cannot escape this battle!");
                        ReadLine();
                        escape = false;
                    }

                }
                if (player.Health <= 0)
                {
                    Clear();
                    Console.WriteLine("Game Over");
                    player.Health = 0;
                    Draw(player);
                    Draw("\nPress Enter to return to the title screen.");
                    GameRunning = false;
                    newGame = true;
                }
                else if (escape == false)
                {
                    Draw("\nHurray you killed the monster!");
                    player.weaponGet().WeaponLevel++;
                    player.Score += RoomInstance.enemy.Points;

                    player.Level++;
                    player.weaponGet().WeaponLevel++;
                    RoomInstance.enemy.Alive = false;
                    if (player.Health < Player.maxHP / 4)
                    {
                        Draw("You consume the soul of your fallen enemy, restoring your health");

                        player.Health = Player.maxHP;
                    }
                }
                ReadLine();
            }
        }
    }
}

