using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> IsGreater = (a) =>
          {
              int b = 10;
              return a > b;
          };
            Console.WriteLine( IsGreater(20));
            Console.ReadLine();

          
        }
    }

}
