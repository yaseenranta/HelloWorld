using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application starts...");
            
            String userChoice = "";
            
            do
            {
                Console.WriteLine("Enter Your Number");
                int lmt = 0;
                bool isNumber = int.TryParse(Console.ReadLine(), out lmt);

                if (isNumber)
                {
                    Console.WriteLine("For loop started!");
                    for (int i = 0; i < lmt; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Loop Ended!");

                }else{
                    Console.WriteLine("Please enter valid number");
                }

                do
                {
                    Console.WriteLine("Do you want to continue again? Please choice Yes or No");
                    userChoice = Console.ReadLine();
                    if (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO") {
                        Console.WriteLine("Invalid choice");
                    }
                    
                }while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");
                
            } while (userChoice.ToUpper() == "YES");
        }
    }
}
