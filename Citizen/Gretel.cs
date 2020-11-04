using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawneeLibrary;


namespace Citizen
{
    public class Gretel : Citizens
    {
        public Gretel(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public Gretel()
        {
            //max first
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Gretel - I found a sandwich in one of your parks and I want to know it did not have mayonnaise!!!!!!!!!";
            Life = 6;
            ReplyChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = " She's a resident of Pawnee who's always ready to complain and never satisfied with the solution to her outrageous problem that the Parks and Recreation Department comes up with. When she confronts Ron at his new, rotating workstation and then runs around in circles to try and stop him from ignoring her complaint about waste in the water system is possibly the funniest moment of the entire run. There are slugs everywhere on the sidewalk in front of my house. I want them gone but not killed, I love animals.But get rid of them.They're gross. But make sure they're happy. But not too happy";
        }
    }

    public class ChanceFrenlm : Citizens
    {
        public ChanceFrenlm(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public ChanceFrenlm()
        {
            //max first
            MaxLife = 17;
            MaxDamage = 1;
            Name = "Chance Frenlm - What is so bad about corn syrup? It is natural. Corn is a fruit, Syrup comes from a bush";
            Life = 7;
            ReplyChance = 20;
            Block = 15;
            MinDamage = 7;
            Description = "He is prone to leading chants at the public forums.Get it? Chance and chants.And what kind of last name is Frenlm? Ham and mayonnaise! Ham and mayonnaise!";
        }
    }

    public class HerbScaifer : Citizens
    {
        public HerbScaifer(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public HerbScaifer()
        {
            //max first
            MaxLife = 13;
            MaxDamage = 23;
            Name = "Herb Scaifer -Zorp the Suveyor is coming";
            Life = 9;
            ReplyChance = 4;
            Block = 15;
            MinDamage = 1;
            Description = "He is The current leader of the 'Zorpies,' makes an unforgettable appearance in End of the World and teaches us all about the armageddon predicted in Lou Presodivich's 'Organize it! 2: Engage with Zorp.' Would you take a check ?";
        }
    }

    public class GarthBlundin : Citizens
    {
        public GarthBlundin(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public GarthBlundin()
        {
            //max first
            MaxLife = 40;
            MaxDamage = 5;
            Name = "Garth Blundin -Big deal. You put on a costume for a couple of hours? By that logic, every time I go to bed at night, I am Wolverine....I won them, madam. In a raffle.";
            Life = 20;
            ReplyChance = 23;
            Block = 1;
            MinDamage = 6;
            Description = "When changes to Pawnee's antiquated town charter are put on the table, the historically obsessed Garth comes to their defense and challenges Leslie to a 'living in the past' contest. It's one of the rare instances where the show's protagonist fails to come out on top.";
        }
    }

    public class CarlLorthner : Citizens
    {
        public CarlLorthner(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public CarlLorthner()
        {
            //max first
            MaxLife = 9;
            MaxDamage = 1;
            Name = "Carl Lorthner - AFTER THAT I'M GOING TO SHOW YOU THIS LOG I FOUND. IT'S GOT LIKE 50 WORMS ON IT. I CALL IT WORM LOG.";
            Life = 1;
            ReplyChance = 1;
            Block = 1;
            MinDamage = 1;
            Description = "Head of the Park Rangers";
        }
    }

    public class Tammy2Swanson : Citizens
    {
        public Tammy2Swanson(string name, int life, int maxLife, int replyChance, int block, int minDamage, int maxDamage, string description) : base(name, life, maxLife, replyChance, block, minDamage, maxDamage, description) { }

        public Tammy2Swanson()
        {
            //max first
            MaxLife = 40;
            MaxDamage = 20;
            Name = "Tammy 2 Swanson - Oh sorry, I pronounced that wrong. I am trolling for dad D.";
            Life = 20;
            ReplyChance = 25;
            Block = 50;
            MinDamage = 15;
            Description = "Every time she laughs, an angel dies. Even telemarketers avoide her, Her birth was payback sor the sins of man. But you of man. But you know the worst thing about her?..... She works for the library.";
        }
    }
}
