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

        //Methods
        public void Bark()
        {
            Console.WriteLine("Arff!");
        }

        public string PlaysVidya(string newMood)
        {
            this.mood = newMood;
            return this.mood;
        }

        public int PowerUp (int newPowerLevel)
        {
            Console.WriteLine(name + " is powering up!");
            this.powerLevel = newPowerLevel;
            return this.powerLevel;
        }


    }
}
