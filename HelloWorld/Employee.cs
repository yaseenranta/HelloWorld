using System;


    class Employee
    {
        public String _firstname = "";
        public String _lastname = "";
        public String _type = "";

        public virtual void print() {
            Console.WriteLine("First name : {0}, Last Name : {1}, Type : {2}",_firstname,_lastname,_type );
        }

    }




class ParttimeEmployee : Employee
{
    private new String _type = "Part time";

    public ParttimeEmployee(String FirstName, String LastName)
    {
        this._firstname = FirstName;
        this._lastname = LastName;
    }

    public override void print()
    {
        Console.WriteLine("First name : {0}, Last Name : {1}, Type : {2}", _firstname, _lastname, _type);
    }
}

class FulltimeEmployee : Employee
{
    private new String _type = "Full time";

    public FulltimeEmployee(String FirstName, String LastName)
    {
        this._firstname = FirstName;
        this._lastname = LastName;
    }

    public override void print()
    {
        Console.WriteLine("First name : {0}, Last Name : {1}, Type : {2}", _firstname, _lastname, _type);
    }


}

class TempEmployee : Employee
{
    private new String _type = "Temporary time";

    public TempEmployee( String FirstName,String LastName)
    {
        base._firstname = FirstName;
        base._lastname  = LastName;
        base._type = this._type;
    }

   /* public override void print()
    {
        Console.WriteLine("First name : {0}, Last Name : {1}, Type : {2}", _firstname, _lastname, _type);
    }
    */
}
