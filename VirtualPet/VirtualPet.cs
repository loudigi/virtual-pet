using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        private string petName = "Fuzzy";
        private string petAnimalType = "Falcon";
        private int petHunger;
        private int petBoredom;
        private int petTiredness;
        private int petHappiness;

        public VirtualPet()
        {
            // empty contructor
        }
        public VirtualPet(string name, int hunger, int bored, int tired, int happy)
        {
            this.petName = name;
            this.petHunger = hunger;
            this.petBoredom = bored;
            this.petTiredness = tired;
            this.petHappiness = happy;
        }

        public string Name
        {
            get { return this.petName; }
        }

        public string Animal
        {
            get { return this.petAnimalType; }
        }

        public int Hunger
        {
            get { return this.petHunger;}
            set { this.petHunger = value;}
        }

        public int Boredom
        {
            get { return this.petBoredom; }
            set { this.petBoredom = value; }
        }

        public int Tiredness
        {
            get { return this.petTiredness; }
            set { this.petTiredness = value; }
        }

        public int Happiness
        {
            get { return this.petHappiness; }
            set { this.petHappiness = value; }
        }

        public void PrintStatus()
        {
            Console.WriteLine("\nThis is " +this.Name + "\'s " + "current status\n");
            Console.Write(String.Format("{0,-12}", "Hunger "));
            Console.Write("{0,-3}", this.Hunger);
            for (int i = 0; i < this.Hunger; i++)
            {
                Console.Write("[|]");
            }
            Console.WriteLine();

            
            Console.Write(String.Format("{0,-12}", "Happiness "));
            Console.Write("{0,-3}", this.Happiness);
            for (int i = 0; i < this.Happiness; i++)
            {
                Console.Write("[|]");
            }
            Console.WriteLine();

           
            Console.Write(String.Format("{0,-12}", "Boredom "));
            Console.Write("{0,-3}", this.Boredom);
            for (int i = 0; i < this.Boredom; i++)
            {
                Console.Write("[|]");
            }
            Console.WriteLine();


            Console.Write(String.Format("{0,-12}", "Tiredness "));
            Console.Write("{0,-3}",this.Tiredness);
            for (int i = 0; i < this.Tiredness; i++)
            {
                Console.Write("[|]");
            }
            Console.WriteLine("\n");
        }
    }
}
