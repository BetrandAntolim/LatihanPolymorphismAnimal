using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Animal";
            animal.Speak();

            Dog dog = new Dog();
            dog.Name = "Spike";
            animal = dog;
            dog.Speak();

            Cat cat = new Cat();
            cat.Name = "Tom";
            animal = cat;
            cat.Speak();

            Console.ReadKey();
        }
    }
}
