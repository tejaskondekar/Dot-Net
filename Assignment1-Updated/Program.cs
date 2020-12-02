using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
           Console.WriteLine ("Employee no =" + e.EmpNo);
            Console.ReadLine();
        }
    }
    class Employee
    {
        int empNo;
        String Name;
        decimal Basic;
        short DeptNo;

     public String name
         {
            set
            {  
                if (value = " ")
                {
                    Console.WriteLine("name can't be empty");
                }
            }
            
        }
    }
}
