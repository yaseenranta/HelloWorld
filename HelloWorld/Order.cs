using System;

    class Order : Customer
    {

    int orderId = 0;
    String[] orderType = new String[2];
    int orderTypeIndex;
    String customerName;
    String customerEmail;
    public Order() {
        Console.WriteLine("Order parameter less constructor invoked.");
    }

    public Order(int orderTypeIndex,String Fullname,String Email) {
        orderType[0]        = "Parcel";
        orderType[1]        = "Dine-in";
        this.customerName   = Fullname;
        this.customerEmail  = Email;
        this._fullname      = Fullname;
        this._email         = Email;
        this.orderTypeIndex = orderTypeIndex - 1;
        this.orderId += 1;

    }
    //hides the print method that is exist in customer base class
    public new void print() {
        String ot = this.orderType[orderTypeIndex];

        Console.WriteLine("Order Id : {0}", this.orderId);
        Console.WriteLine("Customer Name : {0}",this.customerName );
        Console.WriteLine("Customer Email : {0}", this.customerEmail);
        Console.WriteLine("Order Type : {0}", ot);
    }

}