using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");

            /* voidDelegate del1, del2, del3,del4; 

             del1 = new voidDelegate(print);
             del2 = new voidDelegate(print);
             del3 = new voidDelegate(print);

             del1("Delegate del1 invoked");
             del2("Delegate del2 invoked");
             del3("Delegate del3 invoked");


             del4 = del1 + del2 + del3;*/

            /* voidDelwithoutParam del1, del2, del3, del4;

             del1 = new voidDelwithoutParam(print1);
             del2 = new voidDelwithoutParam(print2);
             del3 = new voidDelwithoutParam(print3);

             del4 = del1 + del2 + del3;
             del4();*/

            /* voidDelwithoutParam del = new voidDelwithoutParam(print1);
             del += print2;
             del += print3;
             del();*/

            /*intDelegate i1, i2, i3, i4;

            i1 = new intDelegate(int1);
            i2 = new intDelegate(int2);
            i3 = new intDelegate(int3);

            i4 = i1 + i2 + i3;
            //return last method value.
            //Multicast delegate return last member value.
            Console.WriteLine(i4());*/

            List<Student> students = new List<Student>();
            students.Add(new Student() {
                Id          = 1,
                Name        = "Muhammad Yaseen",
                age         = 26,
                totalMark   = 34
            });

            students.Add(new Student(){
                Id = 2,
                Name = "Muhammad Jawwad",
                age = 23,
                totalMark = 24
            });

            students.Add(new Student(){
                Id = 3,
                Name = "Muhammad Altaf",
                age = 28,
                totalMark = 65
            });


            students.Add(new Student(){
                Id = 4,
                Name = "Muhammad Muneef",
                age = 27,
                totalMark = 85
            });


            students.Add(new Student(){
                Id = 5,
                Name = "Muhammad Owais",
                age = 24,
                totalMark = 75
            });
            boolDelegate isPassORnot = new boolDelegate(isPassed);

            Student stdObj = new Student();
            stdObj.isPassed(students, isPassORnot);

           
        }

        public static bool isPassed(Student std)
        {
            if(std.totalMark >= std.passMark)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void print1() {
            Console.WriteLine("Method invoked 1");
        }

        public static void print2()
        {
            Console.WriteLine("Method invoked 2");
        }

        public static void print3()
        {
            Console.WriteLine("Method invoked 3");
        }

        public static int int1()
        {
            return 1;
        }

        public static int int2()
        {
            return 2;
        }

        public static int int3()
        {
            return 3;
        }
    }
}
