using System;

class Customer {

    protected String _fullname;
    protected String _email;
    /*
    * Class have more then one constructor with different signature 
    * Contructor don't return any data type
    * 
    */
    //constructor
    public Customer()
    {
        
    }


    public Customer(String Fullname,String Email)
    {        
        this._fullname = Fullname;
        this._email = Email;

        
    }


    //instance method
    public void print() {
        
        Console.WriteLine("Customer name = {0}", this._fullname);
        Console.WriteLine("Customer email = {0}", this._email);
    }

    //destructor
    ~Customer(){

    }

}
