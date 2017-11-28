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
            Pet xenny = new Pet("Xenny the Xenomorph", 45.5, 5, "eager");

            //quitFlag - if true, keep going
            bool quitFlag = false;

            //Main Program Logic
            do
            {
                xenny.StatusCheck();
                Console.WriteLine();
                MenuWriter();
                string userInput = Console.ReadLine();           
                

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

        static void SwitchBoard(string userInput)
        {
            switch (userInput)
            {
                case "7":
                    quitFlag = true;
                    break;
                default:
                    Console.WriteLine("Hey, pick a valid option!");
                    MenuWriter();
                    string userInput2 = Console.ReadLine();
                    SwitchBoard(userInput2);
                    break;
            }
        }
    }
}
