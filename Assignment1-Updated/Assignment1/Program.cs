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
            Employee e1 = new Employee("Tejas", 6000, 2);
            Employee e2 = new Employee("Sumedh", 500);
            Employee e3 = new Employee("");

            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e3.EmpNo);

            Console.WriteLine (e3.EmpNo);
            Console.WriteLine (e2.EmpNo);
            Console.WriteLine (e1.EmpNo);


            /* Console.WriteLine("Enter name");
              e.Name = Console.ReadLine();
             Console.WriteLine(e.Name);

             Console.WriteLine("Enter basic salary");
             e.Basic = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(e.Basic);
             decimal a = e.GetNetSalary();
             Console.WriteLine(a);

             Console.WriteLine("Enter DptNo");
             e.DeptNo = Convert.ToInt16(Console.ReadLine()); 
             Console.WriteLine(e.DeptNo);*/


            Console.ReadLine();
        }
    }
    public class Employee
    {
        private static int lastEmpNo = 0; 
         int empNo;
        String name;
        decimal basic;
        short deptNo;
        static int temp = 0;

        public String Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Enter a valid name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value < 10000 && value > 4000)
                {
                    basic = value;
                }
                else
                {

                    Console.WriteLine("Enter a valid data");
                }
            }
            get { return basic; }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Enter valid deptNo");
                }
            }
            get { return deptNo; }
        }
        public int EmpNo

        {
            get{return empNo;}
           private set { empNo = value; }
                
            }


        public decimal GetNetSalary()
        {

            /* HRA =3%
             * float PF = 5%;
             float TA = 4 %;
             float IT = 5 %
             decimal NetSalary = Convert.ToDecimal(Basic + HRA + TA - PF - IT); */
            decimal HRA = (3*(1/100));
            decimal TA = (4 * (1 / 100));
            decimal PF = (5 * (1 / 100));
            decimal IT = (5 * (1 / 100));

            decimal NetSalary = (Basic + (HRA * Basic) + (TA * Basic) - (PF * Basic) - (IT * Basic));
            return NetSalary;
        }

        public Employee()
        {   
           // EmpNo = ++ lastEmpNo;
        }
        public Employee(String Name )
        {
            EmpNo = ++lastEmpNo;
            this.Name = Name;
        }
       public Employee(String Name , decimal Basic)
        {
            EmpNo = ++lastEmpNo;
            this.Name = Name;
            this.Basic = Basic;
        }
       public Employee(String Name , decimal Basic, short DeptNo)
        {
            EmpNo = ++lastEmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;

        }
       

    }
}

