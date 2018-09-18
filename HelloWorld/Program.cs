using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");

        Console.WriteLine("Please enter your Fullname and Email");
        String Fullname = Console.ReadLine();
        Console.WriteLine("Please enter your Email");
        String Email = Console.ReadLine();        
        int result = 0;
        Boolean type = false;
        do {
            int val = 0;
            if (result != 1 || result != 2)
            {
                Console.WriteLine("Order Type : 1 for Parcel and 2 for dine-in");
                String orderType = Console.ReadLine();

                type = int.TryParse(orderType, out val);
                result = val;
            }
            else {
                type = false;   
            }
           
        } while (!type);

       
        Console.WriteLine("---- Order Detail ----");

        Order odr = new Order(result,Fullname,Email);
            odr.print();

        Console.WriteLine("Invoke Print Method from order class object by reference customer class");
            //Customer ctm = new Order();
            Customer ctm = odr;
            ctm.print();

        
        
    }


    }

