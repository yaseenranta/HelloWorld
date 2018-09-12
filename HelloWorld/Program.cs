using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Application starts...");
            Console.WriteLine("Enter Your Number");
            int lmt = 0;
            bool isNumber =   int.TryParse(Console.ReadLine(), out lmt);

            if (isNumber)
            {
                Console.WriteLine("For loop started!");
                for (int i = 0; i < lmt; i++)
                {
                    Console.WriteLine(i+'\n'); 
                }
                Console.WriteLine("Loop Ended!");
                //Console.WriteLine("While loop started!");
                //int start = 0;
                //while (start <= lmt) {
                //    Console.WriteLine(start + '\n');
                //    start = start + 2;
                //}
                //Console.WriteLine("While loop Ended!");

            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

            
        }
    }
}
