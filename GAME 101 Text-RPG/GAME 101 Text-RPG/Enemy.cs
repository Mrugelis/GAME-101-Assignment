using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{

    class Enemy :Character 
    {
        int type; //0 regular monster, 1 hard monster, 3 boss monster
        int weaponDamage;
        int points;
        bool alive; //0 aware, 1 unaware

        public Enemy(int kind)
        {
            switch (kind)
            {
                case 0:
                    Name = "Monster";
                    weaponDamage = 15;
                    Health = 50;
                    Level = 1;
                    points = 100;
                    type = kind;
                    alive = true;
                    break;
                case 1:
                    Name = "Crazy Monster";
                    weaponDamage = 50;
                    Health = 140;
                    points = 1000;
                    Level = 2;
                    type = kind;
                    alive = true;

                    break;
                case 2:
                    Name = "Boss Monster";
                    weaponDamage = 75;
                    Health = 250;
                    points = 1500;
                    Level = 5;
                    type = kind;
                    alive = true;

                    break;
                default:
                    Name = "Monster";
                    weaponDamage = 15;
                    Health = 5;
                    Level = 1;
                    type = kind;
                    alive = true;
                    break;
            }
            
        }
        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public int WeaponDamage
        {
            get
            {
                return weaponDamage;
            }

            set
            {
                weaponDamage = value;
            }
        }

        public bool Alive
        {
            get
            {
                return alive;
            }

            set
            {
                alive = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public static Dictionary<int, Enemy> generateEnemyList()
        { 
            Enemy one = new Enemy(0);
            Enemy two = new Enemy(1);
            Enemy three = new Enemy(0);
            Enemy four = new Enemy(1);
            Enemy five = new Enemy(1);
            Enemy finalBoss = new Enemy(2);
            one.Location = rndLoc();
            two.Location = rndLoc();
            three.Location = rndLoc();
            four.Location = rndLoc();
            five.Location = 1;
            finalBoss.Location = 4;
            return new Dictionary<int, Enemy>()
            {
                {0, one },
                {1, two },
                {2,three },
                {3, four },
                {4, five },
                {5, finalBoss}
       
            };
        }

        private static int rndLoc()
        {
            Random rnd = new Random();

            return rnd.Next(1, 5);
        }
    }
}