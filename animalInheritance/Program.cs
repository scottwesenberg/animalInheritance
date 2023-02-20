using System;
using System.Data.Common;

namespace Inheritance
{

    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;
        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }
    // derived class 
    class Cow : Animal
    {
        
        public string gender;  
        protected int age;
        protected int weight;  

        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public virtual int getWeight()
        {
            return weight;
        }
        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access type directly because it is protected and this is a derived class
        public override string getType()
        {
            return type;
        }

        public virtual string sound()
        {
            return "MOOOOOOOOOO!!!!";
        }
    }

    // derived class of Animal 
    class Program
    {
        static void Main(string[] args)
        {
            // object of the base class Animal
            Animal ducky = new Animal();
            ducky.setName("Sir Quacksalot");
            ducky.setType("Duck");
            // color is a public field
            ducky.color = "yellow";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"The name is {ducky.getName()}");
            Console.WriteLine($"I am a {ducky.getType()}");
            Console.WriteLine($"My color is {ducky.color}");
            Console.WriteLine();

            // object of derived class Cow
            Cow mooer = new Cow();
            mooer.setName("Flipper");
            mooer.setType("Cow");
            // color is a public field
            mooer.color = "white";
            // weight is a protected field
            mooer.setWeight(345);
            // age is a protected field
            mooer.setAge(3);

            Console.WriteLine("Cow Information...");
            Console.WriteLine($"Hey, the name is {mooer.getName()}");
            Console.WriteLine($"I'm a {mooer.getType()}");
            Console.WriteLine($"My color is {mooer.color}");
            Console.WriteLine($"I have lived for {mooer.getAge()} years");
            Console.WriteLine($"I like to {mooer.sound()}");
            Console.WriteLine($"I weight {mooer.getWeight()}lbs");

            Console.ReadLine(); 
        }

    }
}