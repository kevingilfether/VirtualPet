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
            Pet jenny = new Pet("Jenny the Xenomorph", 45.5, 5, "eagers");

            //quitFlag - if true, keep going
            bool quitFlag = false;

            //ASCII Alien - to add in

//            ___--=--------___
//        /. \___\____   _, \_      /-\
//       /. .  _______     __/=====@
//       \----/  |  / \______/      \-/
//   _/         _/ o \
//  / |    o   /  ___ \
// / /    o\\ |  / O \ /|      __-_
//|o|     o\\\   |  \ \ /__--o/o___-_
//| |      \\\-_  \____  ----  o___-
//|o|       \_ \     /\______-o\_-
//| \       _\ \  _/ / |
//\o \_   _/      __/ /
// \   \-/   _       /|_
//  \_      / |   - \  |\
//    \____/  \ | /  \   |\
//            | o |   | \ |
//            | | |    \ | \
//           / | /      \ \ \
//         /|  \o|\--\  /  o |\--\
//         \----------' \---------'


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
            Console.WriteLine("  ___--=--------___\n /. \\___\\____   _, \\_      /-\\\n/. .  _______     __/=====@\n\\----/  |  / \\______/      \\-/");
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
