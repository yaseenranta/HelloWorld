using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");
            //convert implicitly (datatype convert automatic by the complier when there is no loss of data and no exception throwing)

            int ival = 100;
            float fval = ival;

            Console.WriteLine("Implicit conversion : {0}", fval);
            //throwing an exception because fractional part will be loss on implicit conversion.
            //need to convert explicitly with (int)
             fval = 99999999929.233F;
            //ival = (int) fval;
            //ival = Convert.ToInt32(fval);
            //convert string into int
            string str = "100ab";
            int result = 0;
            //parse() convert string into integer and throw exception if value is not integer
            ival = int.Parse(str);

            //TryParse() convert string into integer and return 0 or 1. if value is not integer.
            int.TryParse(str, out result);

            Console.WriteLine("Explicit conversion : {0}", result);


        }
    }
}

