using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx2
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal's Genaric Sound Here..");
        }
        static void Main(string[] args)
        {
            // animal
            Animal animal = new Animal();
            animal.MakeSound();
            // cat
            Cat cat = new Cat();
            cat.MakeSound();
            // dog
            Dog dog = new Dog();
            dog.MakeSound();

            Console.ReadKey();
        }
    }
    class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat's Sound Meeoowwwww!");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog's Sound Breaking! Ghewwww!");
        }
    }
}
