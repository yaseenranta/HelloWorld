using System;

namespace HelloWorld
{
    class YrMethods
    {

        public string str() {

            String str = "This is String return method.";
            return str;
        }

        public static int add(int a = 0, int b = 0) {

            int sum = a + b;
            return sum;
        }

        public static int subtract(int a = 0, int b = 0) {

            int minus = a - b;
            return minus;
        }

        //used as ref parameter example

        public static void ref_param(ref int param){
            param = 100;
        }

        public static void out_param(int a, int b, out int total, out int product) {
            total   = a + b;
            product = a * b;
                
        }
        /*
         * makes array parameter optional use params keyword
         * params keyword only once use in method
         * params keyword must be last in parameter
         */
        public static void array_param(out int cnt, params int [] Numbers) {
            cnt = Numbers.Length;
            foreach (int nm in Numbers) {
                Console.WriteLine(nm);
            }
        }
    }
}
