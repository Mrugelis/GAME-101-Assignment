using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Enemy
    {

        string enemyName;
        int weaponCount;
        bool isAlive;
        int currentState;


        public Enemy()
        {
            enemyName = "enemy";
            weaponCount = 5;
            isAlive = true;
            currentState = 2;
        }

        public Enemy(string name, int weapon, bool alive, int state)
        {
            Name = name;
            Weapon = weapon;
            Alive = alive;
            State = state;
        }

        public string Name
        {
            get
            {
                return enemyName;
            }
            set{
                enemyName = value; 
            }
        }

        public int Weapon
        {
            get
            {
                return weaponCount;
            }

            set
            {
                weaponCount = value;
            }
        }

        public int State
        {
            get
            {
                return currentState;
            }

            set
            {
                currentState = value;
            }
        }

        public bool Alive
        {
       
            get
            {
                return isAlive;
            }

            set
            {
                isAlive = value;
            }
      
        }

        public void enemyAttack()
        {
            Console.WriteLine("");
        }

        public void enemyPatrol()
        {
            Console.WriteLine("You hear lumbering, pounding footsteps in the fog.");
        }

        public void enemyAlert()
        {
            Console.WriteLine("Seems that we have a their lurking about!");
        }

        public void enemyDeath()
        {
            Console.WriteLine("You win!");
        }

    }
}