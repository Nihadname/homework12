using calculator2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2.Models
{
    internal class Calculation : IMultiple, ISubstraction, Addition, Division
    {
        public double Addition(double x, double y)
        {
           return x + y;
        }

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("0 bolme yoxdu"); ;
            }
            return x / y;
           
        }

        public double Multiple(double x, double y)
        {
         return x * y;
        }

        public double Substraction(double x, double y)
        {
         return x - y;
        }

        
    }
}
