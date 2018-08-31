using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee                       /*Parent Class  */
    {
        public string _FirstName;
        public string _LastName;

        public virtual void functionPrintFullName()
        {
            Console.WriteLine("Your name is {0} {1} - Parent", _FirstName, _LastName);
        }
    }

    public class FullTimeEmployee : Employee    /*Child Class 1 */
    {
        public override void functionPrintFullName()
        {
            Console.WriteLine("Your name is {0} {1} - Full Time", _FirstName, _LastName);
        }
    }

    public class PartTimeEmployee : Employee    /*Child Class 2 */
    {
        public override void functionPrintFullName()
        {
            Console.WriteLine("Your name is {0} {1} - Part Time", _FirstName, _LastName);
        }
    }

    public class TemporaryEmployee : Employee    /*Child Class 3 */
    {
        public override void functionPrintFullName()
        {
            Console.WriteLine("Your name is {0} {1} - Temporary", _FirstName, _LastName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee employee in employees)
            {
                employee.functionPrintFullName();
            }
            Console.Read();
        }
    }
}
