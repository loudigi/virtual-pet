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
            int counter = 20;
            Console.Write(String.Format("{0,-10}","Hunger " + counter));
            for (int i = 0; i < counter; i++){
                Console.Write("|");
            }
            Console.WriteLine();

            int counter2 = 8;
            Console.Write(String.Format("{0,-10}", "Life " + counter2));
            for (int i = 0; i < counter2; i++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
        }
        
    }
    
}
