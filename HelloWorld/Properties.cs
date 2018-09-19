using System;


namespace HelloWorld
{
    class Properties
    {
    }

    //Anything hides fields or properties outside the class is called encapsulation.
    class Student
    {
        private int _id;
        private String _name;
        private int _passMark;

        public Student()
        {
            this._id = 0;
            this._name = null;
            this._passMark = 35;
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id should not be Zero or negative");
                }
                this._id = value;
            }

            get
            {

                return this._id;
            }

        }

        public String Name
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be null.");
                }

                this._name = value;
            }

            get
            {

                if (String.IsNullOrEmpty(this._name))
                {
                    return "No name";
                }

                return this._name;
            }

        }

        public int Passmark
        {

            get
            {
                return this._passMark;
            }

        }

        /* public void setId(int Id) {
             if(Id <= 0)
             {
                 throw new Exception("Student id should not be Zero or negative");
             }
             this._id = Id;
         }

         public int getId() {
             return this._id;
         }

         public int getPassmark() {
             return this._passMark;
         }

         public void setName(String Name) {

             if (string.IsNullOrEmpty(Name)) {
                 throw new Exception("Name should not be null.");  
             }

             this._name = Name;
         }

         public String getName() {

             if (String.IsNullOrEmpty(this._name)) {
                 return "No name";
             }

             return this._name;
         }

     }

          */
    }

}
