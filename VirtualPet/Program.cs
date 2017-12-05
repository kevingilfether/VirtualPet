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
            Console.WriteLine(@"
	
                     A L | E N     .---._
                                  /==----\_
                 |\              |8=---()-\|   |\
         /|      ::\             |8=-/|\(_)>_   \\
         |:\     `::\_            \=/:\= (_)\|   |\
         `::|     |::::.            \;:\=\(_)>_  |\\
          |b\\_,_ \`::::\             \:\=\( \/  \_(
          `\88b`\|/|'`:::\   .-----   :8:\=|`=>_  [d[
           \;\88b.\=|///::`-/::;;;;:\ |8;|=\( )/   [8[
      __    ||/`888b.\_\/\:/:;/'/-\::\/( \|=(=)>_  [d|
     //):.. `::|/|\""96.\|//;/|'| /-\::+\|-\=(. )/  [8[
    | (/ 88e::.. `'.|| ""min;/\\/8|\.-|::|8|||=|`='_  `[d |
     `-| 8888ee::,,,`\/ 88utes8P//8|-|::|8||\=|( )/   ]8[
      |:`""|####b:::/8pq8e/::'`;q8|/::dP'|\|=|`='_   [d|
 .= -. \::..`""##Gst:q| e|:/..\:|8|.:/|'/\/|/|(_)/   ]8[
/ (,:;:, \::::.\#/88q;`;'\||.:/-//.;/<8\\\^\||./>    `]d[
`8888b::,,_::/ 88q;.`;| d8 /`-.]/|./  | 8 |\|:|;/.d |     [8 |
      `""88###n::-/d8P.\e/-|d/ _//;;|/   |8(|::(/).8/     ]d[
    `""###o2:1dP;`q./=/d/_//|8888\   ;8|^\/`-'8/      [8\
       `""v7|9q8e;./=/d//=/\|eeeb|  /dP= =<ee8/       ]d-
          \| 9; qe / -d / .|/=/ 888 |:\ `--= - = 88p'        [8[
                  (d5b;,/ d /.|/= -\Oo88 |:/                   ,8_\
         _ |\q88 | d / / '=q8|888/:/                    ]d|
        _\\\/ q8 /| 8\_""/////eb|/_                    [8_\
        \|\\<== _(; d888b,.////////--._               ]8|
       _ /\\\/ 888p |= """";;;;`eee.////.;-._          ,8p\
         /,\\\/ 88p\ /==/ 8 /.'88`""""88888eeee`.        ]8|
          .d || 8,\/ p / -dp_d8 |:8:.d\=\    `"""" |=\\     .[8_\
    |8||8||8.-/'d88/8p/|:8:|8b\=\        /|\\|    ]8p|
    |8||8||8b''d.='8p//|:8:'`88b`\       |||||)   [8'\
    `8b:qb.\888:e8P/'/P'8:|:8:`888|      |'\||'  /8p|

               q8q\\qe---_P;'.'P|:8:|:8:|`q/\\     '_///  /8p_\

               _|88b-:==:-d6/P' |8::'|8:| ,|\||    '-=' .d8p/
    |__8Pdb-q888P-'  .:8:| |8:| |/\||\     .-e8p/\|
     .-\888b.__      |:8/' |8:| \ _|;|,-eee8\8\|
     \.-\'88/88/e.e.e|8/|\_--.-.-e8|8|88\8p\|
       .'`-;88]88|8|/':|:\ `q|8|8|8'-\| \|
        `' || || |_/(/|;\)`-\\`--,\|
              `' /v""""""""""vVV\
");

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
