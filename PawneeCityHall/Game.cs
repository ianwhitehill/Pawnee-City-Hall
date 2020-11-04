using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawneeLibrary;

namespace PawneeCityHall
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.Title = "Escape from Pawnee city hall";

            bool exit = false;

            Quote RonQuote1 = new Quote(45, 70, "The less I know about other people’s affairs, the happier I am. I’m not interested in caring about people. I once worked with a guy for three years and never learned his name. Best friend I ever had. We still never talk sometimes", 20);

            Quote RonQuote2 = new Quote(50, 100, "I regret nothing.The end.", 35);

            Quote RonQuote3 = new Quote(60, 78, "Clear alcohols are for rich women on diets.", 45);


            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("In this game you will be playing Ron from the TV show Parks and Recreation. " +
                "It is quitting time for the day and you most make it out of city hall. However, there are coworkers and " +
                "Pawnee citizens who need your attention, you must avoid them by using some of Ron Swanson’s famous quotes.\n");

            //TOOD 1) create Rons and let players pick there Ron 
            Console.WriteLine("Choose your character:\n" +
                "A) Ron Swanson\n" +
                "B) Ron Dunn\n" +
                "C) Wimpy Ron\n" + 
                "D) Dirty Kimono Ron");

            ConsoleKey userPlayer = Console.ReadKey(true).Key;

            switch (userPlayer)
            {
                case ConsoleKey.A:
                  Ron player = new Ron("Ronald Swanson", 60, 60, 100, 101, RonEnum.RonSwanson); 
                    break;
                case ConsoleKey.B:
                   player = new Ron("Ron Dunn", 50, 50, 90, 100, RonEnum.RonDunn);
                    break;
                case ConsoleKey.C:
                    player = new Ron("Wimpy Ron", 40, 40, 85, 98, RonEnum.WimpyRon);
                    break;
                case ConsoleKey.D:
                    player = new Ron("Dirty Kimono Ron", 35, 35, 75, 80, RonEnum.DirtyKimonoRon);
                    break;
                default:
                    player = new Ron("Ronald Swanson", 60, 60, 100, 101, RonEnum.RonSwanson);
                    break;
            }

            Console.Clear();

            do
            {

                Console.WriteLine(Room.getRoom());

                //TODO 2) create coworkers and citizens (monster)

                //TODO 3) display coworker or citiizen randomly 
                bool reload = false;
                do
                {
                    Console.WriteLine("Choose an action:\n" +
                        "E) Engage\n" +//attach
                        "I) Ignore\n" +//run way 
                        "H) Info\n" + //monster info
                        "X) Exit Game");

                    ConsoleKey userInput = Console.ReadKey(true).Key;
                    //TODO 4) Clear line 
                    switch (userInput)
                    {
                        case ConsoleKey.E:
                            //TODO 5) Handle engage 
                            //TODO 6) If player wins
                            //TODO 7) If player dies
                            //TODO 8) If monster dies 
                            break;
                        case ConsoleKey.I:
                            //TODO 9) Monster gets a free attack 
                            //TODO 10) New room new Monster 
                            break;
                        case ConsoleKey.H:
                            //TODO 10) Monster and player info 
                            break;
                        case ConsoleKey.X:
                            //TODO 11) Display unhappy texted 
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Re-think that move, son.\n");
                            break;
                    }

                    //TODO 12) check players life 
                } while (!exit && !reload);
            } while (!exit);
        }
    }
}
