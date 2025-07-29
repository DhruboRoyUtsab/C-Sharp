namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();
            //myDog.Eat();

            Cat myCat = new Cat();
            myCat.MakeSound();
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Make sound");
        }
    }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Barking");

            }
        }

        class Collie : Dog
        {
            public override void MakeSound()
            {
                Console.WriteLine("Collie going Nuts");

            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat is Meowing");
            }
        }
    }
