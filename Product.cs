using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Product
    {
        string name;
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Product(string name, double price, int age)
        {
            this.name = name;
            this.price = price;
            this.age = age;
        }
      
    }
    class Toy : Product
    {
        string producer;
        public string Producer
        {
            get { return producer; }
            set {producer = value;} 
        }
        string material;
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public Toy(string name, double price, int age, string producer, string material):base(name, price, age)
        {
            this.producer = producer;
            this.material = material;
        }
        public override string ToString()
        {
            return ($"This is a Toy, Name = {Name}, Price = {Price}, Age={Age}, Producer ={Producer}, Material={Material}");
        }
    }
    class Book : Product
    {
        string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        string publishingHouse;
        public string PublishingHouse
        {
            get { return publishingHouse; }
            set { publishingHouse = value; }
        }
        public Book(string name, double price, int age, string author, string publishingHouse) : base(name, price, age)
        {
            this.author = author;
            this.publishingHouse = publishingHouse;
        }
        public override string ToString()
        {
            return ($"This is a Book, Name = {Name}, Price = {Price}, Age={Age}, Author ={Author}, PublishingHouse={PublishingHouse}");
        }
    }
    class SportEquipment : Product
    {
            string producer;
            public string Producer
            {
                get { return producer; }
                set { producer = value; }
            } 
            public SportEquipment(string name, double price, int age, string producer) : base(name, price, age)
            {
                this.producer = producer; 
            }
            public override string ToString()
            {
                return ($"This is a SportEquipment, Name = {Name}, Price = {Price}, Age={Age}, Producer ={Producer}");
            }
    }

}
