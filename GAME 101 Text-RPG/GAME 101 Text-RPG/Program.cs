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
        }
    }
}

