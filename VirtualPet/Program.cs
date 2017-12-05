using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random object for Tick Method
            Random rand = new Random();

            //Pet Generator
            Console.WriteLine("Say hi to your new xenomorph!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What's your xenomorph's name?");
            string xennyName = Console.ReadLine();


            Pet xenny = new Pet(xennyName, 45.5, 5, "eager");

            //quitFlag - if true, keep going
            bool quitFlag = false;

            //Main Program Logic
            do
            {
                xenny.StatusCheck();
                Console.WriteLine();
                MenuWriter();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        xenny.StatusCheck();
                        break;
                    case "2":
                        xenny.Bark();
                        break;
                    case "3":
                        xenny.PlaysVidya("amped");
                        break;
                    case "4":
                        xenny.PowerUp(9001);
                        break;
                    case "5":
                        xenny.Feed();
                        break;
                    case "6":
                        xenny.Tick(rand.Next(6));
                        break;
                    case "7":
                        quitFlag = true;
                        break;
                    default:
                        break;
                }


            }

            while (quitFlag == false);

            Console.WriteLine("Have a great day!");



        }
        static void MenuWriter()
        {
            Console.WriteLine();
            Console.WriteLine("1. Check Status");
            Console.WriteLine("2. Pat head");
            Console.WriteLine("3. Play video games");
            Console.WriteLine("4. Overthrow the patriarchy");
            Console.WriteLine("5. Feed");
            Console.WriteLine("6. Wait a \"tick!\"");
            Console.WriteLine("7. Quit");
        }

    }
}
