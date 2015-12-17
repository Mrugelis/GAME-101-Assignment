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
