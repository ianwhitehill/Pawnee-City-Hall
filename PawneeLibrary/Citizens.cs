using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawneeLibrary
{
    public class Citizens : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public Citizens()
        {

        }

        public Citizens(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description)
        {
            Name = name;            
            ReplyChance = replyChance;
            Block = block;          
            MaxDamage = maxDamage;
            Description = description;
            Life = life;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format("{0}\nLife: {1} of {2}nDescription: {3}\n",
                Name,
                Life,
                MaxLife,
                Description);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
