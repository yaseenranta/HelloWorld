using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");
            Student Student = new Student();
            IStudentResult StudentResult = new Student();
            Student.Id = 1;
            Student.Email = "yaseenranta76@gmail.com";
            Student.Fullname = "Muhammad yaseen";
            Student.Classname = 9;
            //explicit interface implementation.
            ((IStudent)Student).printDetail();

            StudentResult.printDetail();


        }
    }

    class Student : IStudent, IStudentResult
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string Fullname { set; get; }
        public int Classname { set; get; }

        public  void  printDetail()
        {
            Console.WriteLine("Student Id    : {0}",this.Id);
            Console.WriteLine("Student Name  : {0}", this.Fullname);
            Console.WriteLine("Student Email : {0}",this.Email);
            Console.WriteLine("Student Class : {0}",this.Classname);
        }

        void IStudentResult.printDetail()
        {
            Console.WriteLine("Student Result Detail");            
        }

        public String studentList()
        {
            return "Student List method";
        }
    }
}
