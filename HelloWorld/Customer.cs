using System;
using System.Collections.Generic;

namespace HelloWorld
{
    //Interface can not be initial
    //A class can inherit one or more interface
    //Interface don't have fields and property
    //Interface have only declaration,no implementation
    //Interface does not offer construct.
    interface ICustomer
    {        
        void print();                
    }

    interface IStudent
    {
        void printDetail(Student s);
       // List<Student> studentList();    

    }

    interface IStudentResult
    {
        void printDetail();
    }


    abstract class AStudent : IStudent, IStudentResult
    {

        public int Id { set; get; }
        public string Email { set; get; }
        public string Fullname { set; get; }
        public int Classname { set; get; }
        public List<Student> studentList;

        public abstract void totalStudent();

        void IStudentResult.printDetail()
        {
           
        }

        public void printDetail(Student s)
        {
            Console.WriteLine("Student Id : {0}", s.Id);
            Console.WriteLine("Student Name : {0}", s.Fullname);
            Console.WriteLine("Student Email : {0}", s.Email);
            Console.WriteLine("Student Class : {0}", s.Classname);
            Console.WriteLine("---*** --- ***---");
        }

       public List<Student> StudentList()
        {
            return studentList;
        }
    }

}
