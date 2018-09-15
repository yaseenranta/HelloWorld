using System;
using LivingBeings.Animal;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");
            Console.WriteLine("Namespace practice");
            Console.WriteLine(cat.legs());
            Console.WriteLine(Dog.legs());
        }
    }
}

namespace LivingBeings
{
    namespace Animal
    {
        class cat
        {

            public static String legs()
            {

                String str = "Cat have 4 legs";
                return str;
            }

            public static String isWalk()
            {

                String str = "yes";
                return str;
            }
        }
    }
}
//namespace organize the code. Namespace avoids to conflict between methods
//namespace don't corresponds to file,directory, or assembles. They could be written in separate file or projects.

namespace LivingBeings
{
    namespace Animal
    {
        class Dog
        {

            public static String legs()
            {

                String str = "cats have 4 legs";
                return str;
            }

            public static String isWalk()
            {

                String str = "yes";
                return str;
            }
        }
    }
}
