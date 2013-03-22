using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public enum Sex { Male, Female };
        protected string name;
        protected int age;
        protected Sex sex;

        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Sex GetSex
        {
            get { return this.sex; }
        }

        public virtual void Speak()
        {
            throw new NotImplementedException("This method is virtual!");
        }

        public static double CalcAverageAge(ICollection<Animal> arrayOfAnimals)
        {
            double sum = 0;
            foreach (Animal animal in arrayOfAnimals)
            {
                sum = sum + animal.age;
            }
            double average = sum * 1.0 / arrayOfAnimals.Count;
            return average;
        }

        public static string IdentifyAnimal(string soundToIdentify)
        {
            string result;
            switch (soundToIdentify)
            {
                case "Riibiitt":
                    result = "Frog";
                    break;
                case "Meow":
                    result = "Cat";
                    break;
                case "Woof":
                    result = "Woof";
                    break;
                default:
                    result = "Unknown Animal";
                    break;
            }
            return result;
        }

        class Cat : Animal
        {
            public Cat(string name, int age, Sex sex)
                : base(name, age, sex)
            { }

            public override void Speak()
            {
                Console.WriteLine("Meow!");
            }
        }

        class Kitten : Cat
        {
            public Kitten(string name, int age)
                : base(name, age, Sex.Female)
            { }

            public override void Speak()
            {
                Console.WriteLine("Meow! I am female.");
            }
        }

        class Tomcat : Cat
        {
            public Tomcat(string name, int age)
                : base(name, age, Sex.Male)
            { }

            public override void Speak()
            {
                Console.WriteLine("Meow! I am male.");
            }
        }

        class Dog : Animal
        {
            public Dog(string name, int age, Sex sex)
                : base(name, age, sex)
            { }

            public override void Speak()
            {
                Console.WriteLine("Woof!!!");
            }
        }

        class Frog : Animal
        {
            public Frog(string name, int age, Sex sex)
                : base(name, age, sex)
            { }

            public override void Speak()
            {
                Console.WriteLine("Riibiitt!!!");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}