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
            VirtualPet myPet = new VirtualPet("Fred", 4, 2, 10, 6);
            Console.WriteLine("Hi! Meet " + myPet.Name + " the " + myPet.Animal);
            myPet.PrintStatus();
        }
        
    }
    
}
