using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2.interfaces
{
    public interface IMultiple
    {
        double Multiple(double x, double y);
    }
    public interface ISubstraction {

        double Substraction(double x, double y);
    }
    public interface Addition { 
    double Addition(double x, double y);
}
    public interface Division
    {
        double Division(double x, double y);

    }
}
