using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_101_Text_RPG
{ 
    //sets up a default character health 1, level 1, experience 0, name
    class Character
    {
        int health;
        int level;
        string name;
        int experience;

        public Character()
        {
            Health = 1;
            Level = 1;
            Experience = 0;
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                name = value;
            }
        }


        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }


        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }


        public int Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
            }
        }
    }
}
