using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Warrior
    {
        private string name;
        private int health;
        private int maxAttack;
        private int maxBlock;

        public Warrior(string name, int health, int maxAttack, int maxBlock)
        {
            this.name = name;
            this.health = health;
            this.maxAttack = maxAttack;
            this.maxBlock = maxBlock;
        }

        public string Name
        {
            get
            {
                return name;
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

        public int MaxAttack
        {
            get
            {
                return maxAttack;
            }
        }

        public int MaxBlock
        {
            get
            {
                return maxBlock;
            }
        }
    }
}
