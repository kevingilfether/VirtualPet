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
        private double weight;
        private int powerLevel;
        private string mood;


        //Properties
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
    }
}
