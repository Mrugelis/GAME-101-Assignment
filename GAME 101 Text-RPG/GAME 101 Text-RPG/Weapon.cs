using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{
    class Weapon
    {

        int weaponDamage;
        int weaponLevel;
        string name;
        
        public Weapon()
        {
            weaponDamage = 13;
            weaponLevel = 1;
            name = "Rusty Spoon";
        }

        /*  public void cacheFill()
         {
             //fills weapon cache array

         }

        public Weapon WeaponCache(int level, int index)
         {
             return weaponCache[level, index];
         }

         public Weapon getWeapon(int level, bool isPlayer)
         {
             //takes level of character and checks to see if it is the player and dispenses a weapon

             Random rnd = new Random();

             if (isPlayer == false)
             {
                 rnd.Next(1, 5);

                 return WeaponCache(level, rnd.Next(1, 5));
             }
             else
             {

                 rnd.Next(1, 5);

                 return WeaponCache(level, rnd.Next(1, 5));
             }
         }
         */
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

        public int WeaponLevel
        {
            get
            {
                return weaponLevel;
            }
            set
            {
                weaponLevel = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
}
