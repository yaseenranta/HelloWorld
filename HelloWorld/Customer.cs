using System;

class Customer {

    String _fullname;

    //constructor 
    public Customer() {
        Console.WriteLine("Customer class Initialized");
    }
    //instance method
    public Customer(String Fullname)
    {        
        this._fullname = Fullname;
    }

    public void print() {
        
        Console.WriteLine("Customer name = {0}", this._fullname);
    }

    //destructor
    ~Customer(){

    }

}
