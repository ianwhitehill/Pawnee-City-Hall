using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawneeLibrary
{
    public static class Room
    {
        public static string getRoom()
        { 
            string[] Murals =
            {
                "Good Pawnee, Bad Pawnee\n",
                "Wedding at Turnbill Mansion\nThis mural depicts the unsanctioned 1867 marriage of Pawnee settler " +
                "Emily Lagana to Chief Kuruk of the Wamapoke. The secret ceremony, presided over by the progressive " +
                "Reverend Turnbill, was beautiful and moving. Then word got out and the ceremony was a bloodbath.\n",
                "Sunday Boxing\nFor a while in the 1880s most of the law enforcement officials in Pawnee either quit " +
                "or died from self-inflicted gunshot wounds while drunk. As a result, things were pretty wild. " +
                "Spontaneous bare-knuckle fighting rings spread throughout the town, including this one, " +
                "in which the Reverend Bradley took on all comers after the Sunday sermon. Here, the Reverend takes " +
                "on Anna Beth Stevenson, who had won her previous 11 bouts against the men of the town. The streak " +
                "came to an end on this punch, though Stevenson won the rematch a week later on a 60 round TKO.",
                "Sarah Nelson Quindle\n In 1849, Sarah Nelson Quindle exposed her elbow outdoors, which was a Class-A felony." +
                " Although she felt the law was unjust, she acknowledged she’d broken it, and nobly accepted her" +
                " punishment: to be set adrift on Lake Michigan.\n",
                "Trading Post\n Pawnee would never have survived if settlers hadn't learned how to co-exist peacefully" +
                " with their Native American neighbors. They would come together at Trading Posts to exchange food " +
                "and goods. Sort of like a flea market, with a high risk of intentional small pox. One would like to " +
                "believe that this man is paying the Native American to correctly guess the weight of his baby," +
                " but that's not what's happening.\n",
                "Pawnee Zoo\n The Pawnee Zoo has been around for 150 years. It's one of the oldest zoos in America, " +
                "and with over 250 species of animals on display, it continues to dazzle Pawneeans today.Unfortunately," +
                " the muralist chose to depict a rather disturbing and isolated event in the history of the zoo:" +
                " In 1914, a Jewish ornithologist who was headed for the Mississippi River took a wrong turn and " +
                "wandered into Pawnee looking for directions. The mayor at the time had never seen a Jewish person" +
                " before, and, believing him to be some kind of rare alien creature, placed him in the zoo's abandoned " +
                "otter cage.A few days later the residents of Pawnee received confirmation that this was merely " +
                "a human being with a different heritage, and let him out with great apologies. The mayor even invited " +
                "the man to settle right there in Pawnee for good, and offer which the man politely declined.\n",
                "The Trial of Chief Wamapo\nWithout courageous settlers and the US Cavalry, there would be no Pawnee today." +
                " Their battles with the Wamapo Indian tribes were epic and brought great glory to both sides.This " +
                "mural depicts the trial of Chief Wamapo, who was accused of Being Indian. Tragically, " +
                "in 1834 that was a crime punishable by death.Despite the proximity of the cannon to Wamapo's body," +
                " the cavalry missed him on the first two shots. On the third shot, they got lucky and hit his left" +
                " shin. He died several years later of old age.\n"
            };
            Random rand = new Random();
            int indexNBR = rand.Next(Murals.Length);
            string Mural = Murals[indexNBR];
            return Mural;
        }
    }
}
