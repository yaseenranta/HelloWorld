using System;
using System.IO;
using System.Runtime.Serialization;
namespace HelloWorld
{
    class ExceptionExample
    {
        private string logDir = @"C:\Users\MUNEEB\";


        public void example1()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(logDir+"data.txt");
                Console.WriteLine(sr.ReadToEnd());

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public void example2()
        {
            
            
            try
            {
                StreamReader sr = new StreamReader(logDir + "data.txt");
                String oldContent = sr.ReadToEnd();
                sr.Close();
                try
                {

                    Console.WriteLine("Please enter your first Number");
                    int fn = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please enter your Second Number");
                    int ln = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Total = {0}", fn / ln);
                }
                catch (Exception ex)
                {
                    if (File.Exists(logDir + "dataa.txt"))
                    {
                        StreamWriter sw = new StreamWriter(logDir + "data.txt");
                        sw.Write(oldContent);
                        sw.Write("\\n");
                        sw.Write(ex.GetType().Name + " : " + ex.Message);
                        sw.Close();
                        Console.WriteLine(ex.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException(logDir + "dataa.txt not found",ex);
                    }
                }
            }
            catch (Exception exception)
            {            
                Console.WriteLine("Current Exception : {0}", exception.GetType().Name);
                if(exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception : {0}", exception.InnerException.GetType().Name);
                }

            }
        }
    }

    [Serializable]
     class CustomException : Exception
    {

        public CustomException() : base() 
        {
            
        }

        public CustomException(String str) : base(str)
        {

        }

        public CustomException(String str , Exception innerException) : base(str,innerException)
        {

        }


        public CustomException(SerializationInfo info, StreamingContext context) : base(info , context)
        {

        }

    }
}
