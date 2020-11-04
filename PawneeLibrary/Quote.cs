using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawneeLibrary
{
    public class Quote
    {
        //feilds
        private int _minDamage;

        //prop
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }


        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //it can not be more then max and can not be less then 1 
                if (value > 0 && value <= MaxDamage)
                {
                    //if me
                    _minDamage = value;
                }
                else
                {
                    // outside of defined range
                    _minDamage = 1;
                }
            }
        }

        //ctor
        //create a fully qualified ctor 
        //no default ctor. no blank weapons wiht initialize some of the info
        public Quote(int minDamage, int maxDamage, string name, int bonusHitChance)
        {
            //if you have any with buness rule that are based on there properties you must set them first 
            MaxDamage = maxDamage;//since minDamage rules uses maxDamage we need maxDamage first 
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;

        }


        //methods()
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\nBonus Hit {3}%",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance);

        }
    }
}
