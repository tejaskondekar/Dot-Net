using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> IsEven = (a) => 
            {
                return a % 2 == 0;
            };

            Console.WriteLine(IsEven(4)) ;
            Console.ReadLine();
        }
    }
}
