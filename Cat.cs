using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public enum Gender
    {
        Female,
        Male
    }
    class Cat
    {
        string name;
        public string Name { 
            get {
                return name;
            } 
        }
        
        double _energy;
        
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        public double Energy
        {
            get
            {
                return _energy;
            }
            private set
            {
                if (value < MinEnergy)
                {
                    Console.WriteLine("Not enough energy to jump & quot");
                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

        public Cat(string name, Gender gender)
        {
            this.name=name;
            Gender g = gender;
            Energy = MaxEnergy;
        }
        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }
        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }
    }

}
