using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Set fields 
        private string petName = "Fuzzy";
        private string petAnimalType = "Falcon";
        private int petHunger;
        private int petExcitement;
        private int petEnergy;
        private int petDependency;
        public string BarMeter = "|#";

        public VirtualPet()
        {
            // empty contructor
        }
        public VirtualPet( int hunger, int excite, int tired, int indie)
        {
            
            this.petHunger = hunger;
            this.petExcitement = excite;
            this.petEnergy = tired;
            this.petDependency = indie;
        }

        #region Properties
        //Set Properties
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

        public int Excite
        {
            get { return this.petExcitement; }
            set { this.petExcitement = value; }
        }

        public int Energy
        {
            get { return this.petEnergy; }
            set { this.petEnergy = value; }
        }

        public int Dependency
        {
            get { return this.petDependency; }
            set { this.petDependency = value; }
        }

        #endregion

        #region Methods

        //Random value generation 
        static int RandoVal(int num1, int num2)
        {
            Random rnd = new Random();
            int  num = rnd.Next(num1, num2);
            return num;
        }
        //Set Methods with a check for current poperty values before updating them with random values.
        public void Fly()
        {
            Console.WriteLine(this.petName + " is soaring high. Can you see him?\n");
            if (this.Excite != 1 && this.Excite != 10)
            {
                this.Excite += RandoVal(1, (10 - this.Excite));
            }
            if (this.Excite != 1 && this.Hunger != 10)
            {
                this.Hunger += RandoVal(1, (10 - this.Hunger));
            }
            if (this.Excite != 1 && this.Excite != 10)
            {
                this.Energy -= RandoVal(1, (this.Energy - 1));
            } 
            this.PrintStatus();

        }
        
        public void Play()
        {
            Console.WriteLine("Aww that's cute, " + this.petName + " is playing with ya! He can do aerial tricks.\n");
            if (this.Energy != 1 && this.Energy != 10)
            {
                this.Energy -= RandoVal(1, (this.Energy - 1));
            }
            if (this.Excite != 1 && this.Excite != 10)
            {
                this.Excite += RandoVal(1, (10 - this.Excite));
            }
            if (this.Dependency != 1 && this.Dependency != 10)
            {
                this.Dependency += RandoVal(1, (10 - this.Dependency));
            } 
            this.PrintStatus();
        }

        public void Hunt()
        {
            Console.WriteLine(this.petName + " is in hunt mode now. Very focused on his prey.");
            if(this.Energy != 1 && this.Energy != 10)
            {
                this.Energy += RandoVal(1, (10 - this.Energy));
            }
            if(this.Dependency != 1 && this.Dependency != 10)
            {
                this.Dependency -= RandoVal(1, (this.Dependency - 1));
            }
            
            if(this.Hunger != 1 && this.Hunger != 10)
            {
                this.Hunger -= RandoVal(1, (this.Hunger - 1));
            }
            
            this.PrintStatus();
        }

        public void Attack()
        {
            Console.WriteLine(this.petName + " is attacking!!! Oh boy! I'd hate to be on the other side of those talons.\n");
            if(this.Energy != 1 && this.Energy != 10)
            {
                this.Energy -= RandoVal(1, (this.Energy - 1));
            }
            
            if(this.Dependency != 1 && this.Dependency != 10)
            {
                this.Dependency -= RandoVal(1, (this.Dependency - 1));
            }
            
            if(this.Excite != 1 && this.Excite != 10)
            {
                this.Excite += RandoVal(1, (10 - this.Excite));
            }
            
            this.PrintStatus();
        }

      
        public void UserInput()
        {
            Console.WriteLine("Here's "+ this.Name + "!" + " What do you want to do?\n\n" + "1. Fly\n" + "2. Play\n" + "3. Hunt\n" +"4. Attack\n" + "5. Go home\n");

            string userSelect = Console.ReadLine();

            if(userSelect == "1")
            {
                this.Fly();

            }else if( userSelect == "2")
            {
                this.Play();

            }else if(userSelect == "3")
            {
                this.Hunt();

            }else if(userSelect == "4")
            {
                this.Hunt();

            }else if(userSelect == "5")
            {
                Console.WriteLine("See Ya!!!");
                return;
            }else
            {
                Console.WriteLine("**** " +userSelect + " - is not one of the options. Try again. ****");
                this.PrintStatus();
            }
        }
        
        public void PrintStatus()
        {
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\nThis is " +this.Name + "\'s " + "current status\n");
            Console.Write(String.Format("{0,-12}", "Hunger "));
            Console.Write("{0,-3}", this.Hunger);
            for (int i = 0; i < this.Hunger; i++)
            {
                Console.Write(BarMeter);
            }
            Console.WriteLine();
            


            Console.Write(String.Format("{0,-12}", "Dependency "));
            Console.Write("{0,-3}", this.Dependency);
            for (int i = 0; i < this.Dependency; i++)
            {
                Console.Write(BarMeter);
            }
            Console.WriteLine();

           
            Console.Write(String.Format("{0,-12}", "Excitement "));
            Console.Write("{0,-3}", this.Excite);
            for (int i = 0; i < this.Excite; i++)
            {
                Console.Write(BarMeter);
            }
            Console.WriteLine();


            Console.Write(String.Format("{0,-12}", "Energy "));
            Console.Write("{0,-3}",this.Energy);
            for (int i = 0; i < this.Energy; i++)
            {
                Console.Write(BarMeter);
            }
            Console.WriteLine("\n\n===============================================");
            Console.WriteLine("\n");
            this.UserInput();
        }
        #endregion
    }
}
