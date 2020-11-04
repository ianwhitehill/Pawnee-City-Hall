using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawneeLibrary
{
    public class Combat
    {
        public static void DoBattle(Ron ron, Citizens citizens)
        {
            DoAttack(ron, citizens);

            if (citizens.Life > 0)
            {
                DoAttack(citizens, ron);
            }
        }

        public static void DoAttack(Character attacker, Character defender)
        {
            //get random from 1 to 100 as dice
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(60);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();
                //assing damage 
                defender.Life -= damageDealt;

                Console.WriteLine("{0} hit {1} for {2} damage",
                    attacker.Name,
                    defender.Name,
                    damageDealt);

            }
            else
            {
                Console.WriteLine("{0} missed", attacker.Name);
            }
        }
    }
}
