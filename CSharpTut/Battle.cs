using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Battle
    {
        public static Random r = new Random();

        public static void StartFight(Warrior a, Warrior b)
        {
            while (a.Health > 0 && b.Health > 0)
            {
                if (a.Health > 0)
                {
                    int damage = getDamage(ref a, ref b);
                    Console.WriteLine("{0} attacks {1} dealing {2} damage,", a.Name, b.Name, damage);
                    b.Health -= damage;
                    Console.WriteLine("{0} now has {1} health\n", b.Name, b.Health);
                }
                if (b.Health > 0)
                {
                    int damage = getDamage(ref b, ref a);
                    Console.WriteLine("{0} attacks {1} dealing {2} damage", b.Name, a.Name, damage);
                    a.Health -= damage;
                    Console.WriteLine("{0} now has {1} health\n", a.Name, a.Health);
                }
            }
            Console.WriteLine(b.Health <= 0 ? a.Name + " won" : b.Name + " won");
        }

        public static int getDamage(ref Warrior attacker, ref Warrior defender)
        {
            int damage = r.Next(1, attacker.MaxAttack) - r.Next(0, defender.MaxBlock);
            return damage > 0 ? r.NextDouble() < 0.2 ? damage * 2 : damage : 0;
        }
    }
}
