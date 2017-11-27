using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //fields
        private string name;
        private double weight;
        private int powerLevel;
        private string mood;


        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int PowerLevel
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }

        public string Mood
        {
            get { return this.mood; }
            set { this.mood = value; }
        }

        //Constructors
        public Pet()
        {

        }

        public Pet(string name, double weight, int powerLevel, string mood)
        {
            this.name = name;
            this.weight = weight;
            this.powerLevel = powerLevel;
            this.mood = mood;
        }

        //Methods
        public void Bark()
        {
            Console.WriteLine("Arff!");
        }

        public string PlaysVidya(string newMood)
        {
            this.mood = newMood;
            Console.WriteLine("You play some video games with " + this.name + ".");
            return this.mood;
        }

        public int PowerUp (int newPowerLevel)
        {
            Console.WriteLine(this.name + " is powering up!");
            this.powerLevel = newPowerLevel;
            return this.powerLevel;
        }
        
        public double Feed()
        {
            Console.WriteLine("You feed " + this.name + " some delicious mint Newman-O's.");
            this.weight = this.weight + 1.5;
            return this.weight;
        }

        //Tick Method

        public void Tick(int nextRand)
        {
            this.mood = "A little bored";
            this.weight = this.weight - nextRand;
            this.powerLevel = 5;
        }

        //Status Print Method

        public void StatusCheck()
        {
            Console.WriteLine("  ___--=--------___\n /. \\___\\____   _, \\_      /-\\\n/. .  _______     __/=====@\n\\----/  |  / \\______/      \\-/");
            Console.WriteLine();
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Mood: " + this.mood);
            Console.WriteLine("Weight: " + this.weight);
            Console.WriteLine("Power Level: " + this.powerLevel);
        }


    }
}
