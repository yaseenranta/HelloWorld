using System;
using System.Collections.Generic;
using System.Reflection;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print in console.
            Console.WriteLine("Application starts...");

            Office.employees.Add(new Employee { Name = "Muhammad Yaseen", Salary = 5000, Age = 26 });
            Office.employees.Add(new Employee { Name = "Muhammad Altaf", Salary = 5000, Age = 26 });
            //List<Employee> Employees = Office.getEmployee();

            Assembly assemblyExecute = Assembly.GetExecutingAssembly();
            Type office = assemblyExecute.GetType("HelloWorld.Office");
            object officeInstance = Activator.CreateInstance(office);
            MethodInfo methodInfo = office.GetMethod("getEmployee");
            ParameterInfo[] parameterInfos = methodInfo.GetParameters();            
            
            List<Employee> Employees = (List<Employee>)methodInfo.Invoke(officeInstance, parameterInfos);

            foreach (Employee employee in Employees)
            {
                Console.WriteLine("Employee name is {0} and monthly salary is {1} and age is {2}",employee.Name,employee.Salary,employee.Age);
            }
        }

    }
    #region Office class
    class Office
    {
        #region Fields
        public static List<Employee> employees = new List<Employee>();

        #endregion

        #region Methods
        
        public static List<Employee> getEmployee()
        {
            
            return employees;
        }
        #endregion

    }
    #endregion

    #region Employee Class
    class Employee
    {
        #region Fields
        private static string _name;
        private static double _salary;
        private static int _age;
        #endregion

        #region Properties
        public String Name {
            set { _name = value; }
            get {return _name; }
        }
        public double Salary { set { _salary = value; } get { return _salary; } }
        public int Age { set { _age = value; } get { return _age; } }
        #endregion

        #region Methods
        public double getSalary()
        {
            return _salary;
        }

        public int getAge()
        {
            return _age;
        }

        public void getDetail()
        {

        }
        #endregion
    }
    #endregion


}
