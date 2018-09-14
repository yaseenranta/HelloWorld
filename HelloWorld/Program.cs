using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] items = new String[4];

            items[1] = "Small";
            items[2] = "Medium";
            items[3] = "Large";

            Console.WriteLine("            |----------------------------|\n            |   Welcome to coffee shop   |            \n            |----------------------------|");
            String userChoice = "";
            int result = 0;
            do
            {
                Boolean isNumber = false;
                do
                {
                    Console.WriteLine("Select Coffee Type");
                    Console.WriteLine("1 for small - 2 for medium - 3 for large");
                    string userChoiceS = Console.ReadLine();
                    
                    isNumber = int.TryParse(userChoiceS, out result);
                    if (isNumber)
                    {
                        
                        do {
                            Console.WriteLine("Do You Want to order another Item. Please Select yes or no.");
                            userChoice = Console.ReadLine().ToUpper();

                        } while (userChoice != "YES" && userChoice != "NO");

                        
                    }
                    else
                    {
                        Console.WriteLine("Please select valid option");
                    }


                } while (!isNumber);
                
            } while (userChoice == "YES");
            
            Console.WriteLine("You order : {0} coffee",items[result]);
        }
    }
}
