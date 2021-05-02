using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Animals
    {
        float weight;
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Animals(string color, float weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public abstract string MakeSound();
        
    }
    abstract class AnimalWithTail : Animals
    {
        float tailLength;
        public float TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            this.tailLength = tailLength;
        }
      
    } 
    class Cat : AnimalWithTail
    {
        public Cat (string color, float weight, float tailLength) : base(color, weight, tailLength)
        {

        }
        string Purr()
        {
            return "purrrr";
        }
        string Meow()
        {
            return "meow";
        }
        public override string MakeSound() {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return ($"This is a Cat, Color = {Color}, Weight = { Weight}, TailLength ={ TailLength}");
        }

    }
    class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {

        }
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return ($"This is a Dog, Color = { Color}, Weight = { Weight}, TailLength ={ TailLength}");
        }
    }
}
