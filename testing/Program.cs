using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        class Animal { }
        class Dog : Animal { }
        

        void PrintTypes(Animal a)
        {
            Console.WriteLine(a.GetType() == typeof(Animal)); // false 
            Console.WriteLine(a is Animal);                   // true 
            Console.WriteLine(a.GetType() == typeof(Dog));   // true
        }

        static void Main(string[] args)
        {
            Dog s = new Dog();
            Animal S = new Animal();

            Console.WriteLine(s.GetType() == typeof(Animal)); // false 
            Console.WriteLine(s is Animal);                   // true 
            Console.WriteLine(s.GetType() == typeof(Dog));   // true
            Console.WriteLine("***********************");
            Console.WriteLine(S.GetType() == typeof(Animal)); // false 
            Console.WriteLine(S is Dog);                   // true 
            Console.WriteLine(S.GetType() == typeof(Dog));   // true

            Console.ReadKey();



        }
}
        }
