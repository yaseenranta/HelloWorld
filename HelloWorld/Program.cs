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
            /*Student Student = new Student();
            IStudentResult StudentResult = new Student();
            Student.Id = 1;
            Student.Email = "yaseenranta76@gmail.com";
            Student.Fullname = "Muhammad yaseen";
            Student.Classname = 9;
            //explicit interface implementation.
            ((IStudent)Student).printDetail();

            StudentResult.printDetail();*/
            
            List<Student> sList = new List<Student>();
                sList.Add(new Student() { Id = 1, Email = "yaseenranta76@gmail.com", Fullname = "Muhammad Yaseen", Classname = 9 });
                sList.Add(new Student() { Id = 2, Email = "ahp@gmail.com", Fullname = "Muhammad Altaf", Classname = 9 });
                sList.Add(new Student() { Id = 3, Email = "owais@gmail.com", Fullname = "Muhammad Owais", Classname = 9 });

            Student student = new Student();
            student.studentList = sList;

            List<Student> stdList = student.StudentList();
            Console.WriteLine("---*** Student Detail ***---");
            foreach (Student s in stdList)
            {
                student.printDetail(s);
            }

            student.totalStudent();
        }
    }

    class Student : AStudent
    {
        
       /*
        public new int Id { set; get; }
        public new string Email { set; get; }
        public new string Fullname { set; get; }
        public new int Classname { set; get; }
        */

         /*
          public new void  printDetail(Student s )
          {
              Console.WriteLine("Student Id    : {0}",s.Id);
              Console.WriteLine("Student Name  : {0}", s.Fullname);
              Console.WriteLine("Student Email : {0}",s.Email);
              Console.WriteLine("Student Class : {0}",s.Classname);
          }
          */

        /*
          void IStudentResult.printDetail()
          {
              Console.WriteLine("Student Result Detail");            
          }
          */
        public new List<Student> StudentList()
        {
            List<Student> std_list = base.StudentList();
            return std_list;
        }

        public override void totalStudent()
        {
            Console.WriteLine("Total Student = {0} ", studentList.Count );
        }
        


    }
}
