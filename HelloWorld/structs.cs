using System;


namespace HelloWorld
{
    /*
    * Struct is value type and class is reference type.
    * Struct is store in heap and class is store in stack.
    * 
    */
    struct chk
    {


        public void print()
        {
            Console.WriteLine("Struct print method. Id : {0},Email : {1}", this.Id,this.Email);
        }
        
        public int Id    {set;get;}
        public string Email { set; get; }
        

    }
}
