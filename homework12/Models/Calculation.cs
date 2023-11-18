using homework12.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12.Models
{
    internal class Calculation : Icalculator
    {
        public char Operator;
        public Calculation() { }
        public Calculation(char Operator)
        {
            this.Operator = Operator;
        }
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
          return x* y;
        }

        public double Substraction(double x, double y)
        {
        return x - y;
        }
    }
}
