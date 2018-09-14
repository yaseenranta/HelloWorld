using System;

namespace HelloWorld
{
    class Program
    {
        /*
         there are 4 types of parameter we can pass in method
         * Value parameter
         * Reference parameter
         * out parameter
         * Array parameter 
         * Defination - Value parameter does not affect on other parameter. its takes different memory location.
         * Defination - Reference parameter affect on other parameter. its point on same memory location.
         * Defination - out parameter gives one or more than one value.
         * Defination - Array Parameter use multiple value of same data type.
         */
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");
            YrMethods yrM = new YrMethods();
            String str = yrM.str();
            //string and it is a example of value parameter
            Console.WriteLine(str);
            //sum
            int sum = YrMethods.add(4, 40);
            Console.WriteLine("add : {0}",sum);

            int minus = YrMethods.subtract(4, 40);
            Console.WriteLine("Subtract : {0}", minus);
            //reference parameter
            Console.WriteLine("-------------------Reference parameter---------------------------");
            YrMethods.ref_param(ref sum);
            Console.WriteLine("change in sum var : {0}", sum);
            //out parameter
            Console.WriteLine("----------------------Out parameter------------------------------");
            int total = 0;
            int product = 0;
            YrMethods.out_param(10, 20, out total, out product);
            Console.WriteLine("Total : {0} && Product : {1}", total,product);
            Console.WriteLine("--------------------Array parameter------------------------------");
            //Array Parameter
            int cnt = 0;
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            YrMethods.array_param(out cnt, Numbers);
            
            Console.WriteLine("Total {0} Elements",cnt);
            
            Console.WriteLine("------------Array parameter without passing Array----------------");
            YrMethods.array_param(out cnt);

            Console.WriteLine("Total {0} Elements", cnt);
        }
    }
}
