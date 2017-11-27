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
            Pet jenny = new Pet("Xenny the Xenomorph", 45.5, 5, "eagers");

            //quitFlag - if true, keep going
            bool quitFlag = false;

            //Main Program Logic
            do
            {
                jenny.StatusCheck();
                Console.WriteLine();
                MenuWriter();
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 7)
                    quitFlag = true;
                

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
