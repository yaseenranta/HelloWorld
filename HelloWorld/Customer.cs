using System;

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
        void printDetail();
        String studentList();    

    }

    interface IStudentResult
    {
        void printDetail();
    }
    
}
