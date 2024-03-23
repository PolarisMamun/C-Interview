using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> PrintStudentDetails(),
                ()=> PrintEmployeeDetails()
                );

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            /*
            * Assuming the Singleton is created from Employee Class
            * Refer to the GetInstance property from the Singleton class             
            */
            Singleton fromEmployee = Singleton.GetInstance; ;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            /*
             * Assuming the Singleton is created from Student Class
             * Refer to the GetInstance property from the Singleton class             
             */

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
