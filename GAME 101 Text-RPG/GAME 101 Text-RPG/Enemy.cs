using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Enemy:Character 
    {
        int type; //0 regular monster, 1 hard monster, 3 boss monster
        int weaponDamage; 
        int currentState; //0 aware, 1 unaware

        public Enemy(int kind)
        {
            switch (kind)
            {
                case 0:
                    Name = "Monster";
                    weaponDamage = 15;
                    Health = 50;
                    Level = 1;
                    type = kind;
                    break;
                case 1:
                    Name = "Crazy Monster";
                    weaponDamage = 25;
                    Health = 70;
                    Level = 2;
                    type = kind;
                    break;
                case 3:
                    Name = "Boss Monster";
                    weaponDamage = 35;
                    Health = 105;
                    Level = 5;
                    type = kind;
                    break;
                default:
                    Name = "Monster";
                    weaponDamage = 15;
                    Health = 5;
                    Level = 1;
                    type = kind;
                    break;
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
    }
}