using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawneeLibrary
{
    public sealed class Ron : Character
    {
        public RonEnum TheRon { get; set; }
        public Quote RonQuote { get; set; }

        public Ron(string name, int replyChance, int block, int life, int maxLife, RonEnum theRon)
        {
            Name = name;
            ReplyChance = replyChance;
            Block = block;
            Life = life;
            MaxLife = maxLife;
            TheRon = theRon;

            switch (TheRon)
            {
                case RonEnum.RonSwanson:
                    ReplyChance += 20;
                    break;

                case RonEnum.DirtyKimonoRon:
                    ReplyChance += 10;
                    break;

                case RonEnum.RonDunn:
                    ReplyChance += 5;
                    break;

                case RonEnum.WimpyRon:
                    ReplyChance += 0;
                    break;
            }
        }

        public override string ToString()
        {
            string description = "";

            switch (TheRon)
            {
                case RonEnum.RonSwanson:
                    description = "Ronald Ulysses Swanson but call me Ron";
                        break;

                case RonEnum.DirtyKimonoRon:
                    description = "I would like to address the goofy-looking, dirty-kimono-wearing, corn-rowed clown in the room";
                    break;

                case RonEnum.RonDunn:
                    description = "Almost the mirror opposite of Ron Swanson, Dunn is a hippie and a vegan.";
                    break;

                case RonEnum.WimpyRon:
                    description = "You goofball, Tammy pointed out that my face looked better without any hair on it, and it did collect a lot of food crumbs which is very un-sanitary";
                    break;
            }

            return string.Format($"{Name}\nLife: {Life} to {MaxLife}\nDescription: {description}");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(RonQuote.MinDamage, RonQuote.MaxDamage + 1);
            return base.CalcDamage();
        }
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + RonQuote.BonusHitChance;
        }
    }
}
