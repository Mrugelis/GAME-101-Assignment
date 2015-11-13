using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            bool title = true;
            int choice;
            int re = 1;
            int location = 0;
            Engine engine = new Engine(location); //instantiates game
            Player player = new Player();

            while (game == true) //while we want to run the game
            {
              
                    Engine.Draw(engine.TitleScreen);
                    choice = Engine.userInput(2);// Engine.getRoom(location).Count); get this fucntionality working
                if (choice == 1) //choice = 1 means run game, choice = 2 means quit game
                {
                    engine.Location++;
                    location++;
                    title = false;
                    while (re != 0)
                    {
                        Console.Clear();
                        Engine.DrawRoom(Engine.getRoom(engine.Location));
                        /*Console.WriteLine("What is your location");
                        Int32.TryParse(Console.ReadLine(), out location);
                        engine.Location = location;*/
                        Update(ref location, userInput(5));
                        engine.Location = location;

                    }

                    //preload game assets here
                }
                else
                {
                    game = false;
                    break;
                }
            
                
            }
        }

        public static int userInput(int index)
        {
            int choice;
            if (Int32.TryParse(Console.ReadLine(), out choice) && 0 < choice && choice <= index)
            {
               // validChoice = true;  //global validation variable
                return choice;
            }
            else
            {
                /* if (validChoice == true)
                {
                    Console.WriteLine(“Invalid choice, please select an option.”);
                    validChoice = false;
                } */
                return userInput(index);
            }
        }
        
        public static void Update(ref int room, int x)
        {
            if(x == 4)
            {
                room++;
            }
            //game logic here
        }

        //goes in engine
       /* public bool Update()
        {
           
           int choice = engine.ReadInput(Player.Location); 
           if(choice==9)
            {
                return false;
            }
            else
            {
                //call game logic
                return true;
            }
        }

        static void Main(string[] args)
        {
            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy("Bob", 3, true, 10);
            int gameState = 1;
            string myPlayerName;
            string myDecision;
      
           Console.WriteLine("Enter Player Name");
           myPlayerName = Console.ReadLine();
           Console.WriteLine("Welcome {0}, you wake in a dense fog. Only to see a dark silhouette fading into the distance.", myPlayerName);
           Console.WriteLine("Do you follow the mysterious figure? y / n");

            do
           {
               myDecision = Console.ReadLine();

               if (myDecision == "y")
               {
                   Console.WriteLine("As you head towards the figure");
                   gameState = 2;
               }
               else if (myDecision == "n")
               {
                   Console.WriteLine("You wander in the opposite direction, hoping to find an indication of where you are.");
                   firstEnemy.enemyPatrol();
                   gameState = 0;
               }
           } while (gameState == 1);

           if (gameState == 0)
           {
               Console.WriteLine("impending doom");
           }



           if (gameState == 2)
           {
               Console.WriteLine("story continues");


            
           }

            titleScreen();


        }

        static void infoScreen(int state)
        {
            bool screen = true;
            string info = "How to play:" + "\r\n" + "";
            Console.Write(info);
            while(screen == true)
            {
                string input = Console.ReadLine();
                if (input == "1" && state == 1)
                {
                    screen = false; //not neccessary, since this just holds the screen waiting for input?
                    Console.Clear();
                    titleScreen();
                }
            }
         
        }

        static void titleScreen()
        {

        } */
    }
}

