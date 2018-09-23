using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Student
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public int age { set; get; }
        public int passMark => 35;
        public int totalMark { set; get; }

        public void isPassed(List<Student> student, boolDelegate boolDele)
        {
            foreach (Student s in student)
            {
                //  checkMarks(s,boolDele);      
                if (boolDele(s))
                {
                    Console.WriteLine("{0} has taken {1} marks and he has been Passed.", s.Name, s.totalMark);
                }
                else
                {
                    Console.WriteLine("{0} has taken {1} marks and he has been Failed.", s.Name, s.totalMark);
                }
            }
        }

       /* public void checkMarks(Student s, boolDelegate boolDele)
        {
            if (boolDele(s))
            {
                Console.WriteLine("{0} has taken {1} marks and he has been Passed.", s.Name, s.totalMark);
            }
            else
            {
                Console.WriteLine("{0} has taken {1} marks and he has been Failed.", s.Name, s.totalMark);
            }
        }
        */
    }  
}
