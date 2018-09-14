using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");
            YrMethods yrM = new YrMethods();
            String str = yrM.str();
            //string
            Console.WriteLine(str);
            //sum
            int sum = YrMethods.add(4, 40);
            Console.WriteLine("add : {0}",sum);

            int minus = YrMethods.subtract(4, 40);
            Console.WriteLine("Subtract : {0}", minus);
        }
    }
}
