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
            int choice;
            int select;
            int condition;
            bool escape = false;
            bool newGame = false; //return to title
            string answer;
            Engine engine = new Engine();
            Player player = new Player();
            while (game == true) //while we want to run the game
            {
                if (newGame == true) //if new game is true, create a new instance of the game
                {
                    engine.Reset();
                    player.Reset();
                    newGame = false;
                }
                Engine.Clear();
                engine.Update(player, 0);
                Engine.Draw(engine.Choices[0]);
                Engine.Draw(engine.getChoiceList(player.Location), player.Location);
                choice = Engine.userInput(engine.getChoiceList(player.Location).Count);       //wait for input
                switch (choice)
                {
                    case 1: //start game
                        Engine.Clear();
                        Engine.Draw("Instructions:\nAt any time entering 0 will return you to the main menu, \nno progress will be saved in this version.\nDecisions will be listed by number, \nand entering a number will execute the corresponding choice.\nPress Enter to continue.");
                        Engine.ReadLine();
                        Engine.Clear();
                        engine.Update(player, choice - 1); //sets passed value of choice to 0
                        Engine.Draw(engine.Results[0]);//initial story string, getting username
                        player.Name = Engine.getInput();
                        Engine.Clear();
                        Engine.Draw(engine.Results[1], player.Name); //intial story string
                        player.Location = 1;
                        engine.Update(player, choice);
                        while (engine.GameRunning == true)
                        {
                            Engine.Clear();
                            Engine.Draw(player);
                            Engine.Draw(engine.Results[0]);
                            Engine.Draw(engine.getChoiceList(player.Location), player.Location);
                            choice = Engine.userInput(engine.getChoiceList(player.Location).Count);
                            switch (choice)
                            {
                                case 0: //return to title
                                    Engine.Draw("Are you sure you want to return to the main menu? Y/N"); //all string literals in Program.cs will be moved to a dictionary object to be referenced
                                    answer = Engine.getInput();
                                    if (answer == "y" || answer == "Y")
                                    {
                                        engine.GameRunning = false;
                                        newGame = true;
                                        Engine.Clear();
                                    }
                                    break;
                                case 1:
                                    escape = false;
                                    engine.doCombat(player, ref escape, choice, ref newGame);
                                    Engine.Draw("Seems like there isn't anything of use here");
                                    Engine.ReadLine();

                                    break;
                                case 2:
                                    escape = false;
                                    engine.doCombat(player, ref escape, choice, ref newGame);         
                                    if (engine.Item == 0 || engine.Collected[engine.RoomInstance.roomNumber] != 0)
                                    {
                                        Engine.Draw("Seems like there isn't anything of use here");
                                    }
                                    else
                                    {
                                        Engine.Draw("You find something that looks like a piece of a locking mechanism.");
                                        player.Collect += engine.Item;
                                        engine.Collected[engine.RoomInstance.roomNumber] = 1;
                                    }
                                    Engine.ReadLine();
                                    break;

                                case 3:
                                    Engine.Draw("Seems like there isn't anything of use here");

                                    escape = false;
                                    engine.doCombat(player, ref escape, choice, ref newGame);           
                                    if (player.Location > 1)
                                    {
                                        Engine.Draw("You move down back to the previous room.");
                                        player.Location--;
                                        engine.Update(player, choice);
                                    }
                                    Engine.ReadLine();

                                    break;
                                case 4:
                                    Engine.Draw("Seems like there isn't anything of use here");

                                    escape = false;
                                    if (player.Location < 5)
                                    {
                                        Engine.Draw("You move onto the next room.");
                                        player.Location++;
                                        engine.Update(player, choice);
                                    }
                                    else
                                    {
                                        condition = player.Collect;
                                        switch (condition)
                                        {
                                            case 1:
                                                Engine.Draw("There are still 2 peices i need to complete the lock");
                                                Engine.ReadLine();

                                                break;
                                            case 2:
                                                Engine.Draw("The last piece has to be somewhere");
                                                Engine.ReadLine();

                                                break;
                                            case 3:
                                                Engine.Draw("I've done it! I'm finally going to be free of this place!");
                                                Engine.ReadLine();
                                                Engine.Draw(engine.Results[choice]);
                                                engine.doCombat(player, ref escape, choice, ref newGame);
                                                if(player.Health > 0 && engine.RoomInstance.enemy.Health <= 0)
                                                {
                                                    engine.GameRunning = false;
                                                    Engine.Clear(); 
                                                    Engine.Draw("Congratulations you have made it out!\n");
                                                    Console.WriteLine("Name: {0}\nScore: {1}\nLevel: {2}",player.Name, player.Score, player.Level);
                                                    Engine.ReadLine();
                                                    
                                                }
                                                break;
                                            default:
                                                Engine.Draw("There seems to be three peices needed to complete the locking mechanism.");
                                                Engine.ReadLine();
                                                break;
                                        }
                                    }
                                    Engine.ReadLine();

                                    break;
                                case 5:
                                    escape = false;
                                    engine.doCombat(player, ref escape, choice, ref newGame);     
                                    Engine.Draw("Seems like there isn't anything of use here");
                                    Engine.ReadLine();

                                    break;
                                default:
                                    choice = Engine.userInput(engine.getChoiceList(player.Location).Count);
                                    break;
                            }
                        }
                        break;
                    case 2: //credits
                        Engine.Clear();
                        Engine.Draw(engine.Results[2]);
                        Engine.Draw("1: Return to main menu");
                        choice = Engine.Read();
                        while (choice != 1)
                        {
                            Engine.Clear();
                            Engine.Draw(engine.Results[2]);
                            Engine.Draw("1: Return to main menu");
                            choice = Engine.Read();
                        }

                        break;
                    case 3: //exit game
                        game = false;
                        break;
                    default:
                        break;
                }
            }
        }


    }
}

