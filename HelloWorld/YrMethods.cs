using System;

namespace HelloWorld
{
    class YrMethods
    {
        
        public string str() {

            String str = "This is String return method.";
            return str;
        }

        public static int add (int a = 0, int b = 0) {

            int sum = a + b;     
            return sum;
        }

        public static int subtract(int a = 0, int b = 0) {

            int minus = a - b;
            return minus;
        }
    }
}
