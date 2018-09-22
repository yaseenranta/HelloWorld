using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");

            /*Student std = new Student();
            std.setId(1);
            std.setName("Muhammad Yaseen");

            Console.WriteLine("Student id : {0}, Student Name : {1}, Student passing Marks : {2}", std.getId(), std.getName(),std.getPassmark());
            
             */

            Student std = new Student();
            std.Id = 1;
            std.Name = "Muhammad Yaseen";
            Console.WriteLine("Student id : {0}, Student Name : {1}, Student passing Marks : {2}", std.Id, std.Name, std.Passmark);

            //create struct object in stack and reference variable of chk "check" store in heap, point to struct object.
            chk check = new chk();
            check.Id = 1;
            check.Email = "yaseenranta76@gmail.com";
            check.print();
        }
    }
}
