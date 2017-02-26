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
            Console.SetWindowSize(52, 42);
            var arr = new[]
{
@"╔═╗┬ ┬┌─┐┌─┐┬ ┬  ╔╦╗┬ ┬┌─┐  ╔═╗┌─┐┬  ┌─┐┌─┐┌┐┌",
@"╠╣ │ │┌─┘┌─┘└┬┘   ║ ├─┤├┤   ╠╣ ├─┤│  │  │ ││││",
@"╚  └─┘└─┘└─┘ ┴    ╩ ┴ ┴└─┘  ╚  ┴ ┴┴─┘└─┘└─┘┘└┘",
            };

            var arr2 = new[] {

@"                      \/",
@"                    __.---;_",
@"                  .'  './'0)',\",
@"                  |o)  |     | ';",
@"                  :'--; \.__/'   ;",
@"                   ;.' (         |",
@"              __.-'   _.)        |",
@"          -===-----'''           | ",
@"                 ;^;         .  ^+^^",
@"               ;^  :         :       ^;",
@"                \  {          :_     /",
@"                 ^'-;          :'--'^",
@"                    ,,____,,-'",
@"",
@"                 __   _______   ______",
@"       ============(((=======(((==============",

            };

            Console.WriteLine("\n");
            foreach (string line in arr) { Console.WriteLine(line); }
            Console.WriteLine("\n");

            Console.WriteLine("\n");
            foreach (string line2 in arr2) { Console.WriteLine(line2); }
            Console.WriteLine("\n");

            VirtualPet myPet = new VirtualPet(5, 5, 5, 5);
            Console.WriteLine("Hi! Meet " + myPet.Name + " the " + myPet.Animal +". He's a cool pet.\n");

            myPet.UserInput();
        }

    }

}
