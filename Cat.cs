using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Cat
    {
        string name;
        public string Name { 
            get {
                return name;
            } 
        }
        public enum Gender
        {
            female,
            male
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
            set
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

        public Cat(string name="Lucky", string Gender="male")
        {
            name="Lucky";
            Gender = "male";
            Energy = MaxEnergy;
        }
        public void Jump(double newEnergy)
        {
            newEnergy = Energy - JumpEnergyDrain;
        }
        public void Sleep(double newSleepEnergy)
        {
            newSleepEnergy = Energy + SleepEnergyGain;
        }
    }

}
