using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class RBI
    {
        public virtual double calculateInterest(double p,double r,double t)
        {
            return ((p * r  * t)/100);
        }
    }

    class HDFC : RBI
    {
        public override double calculateInterest(double p, double r, double t)
        {
            return ((p * r * t) / 100);
        }
    }

    class SBI : RBI
    {
        public override double calculateInterest(double p, double r, double t)
        {
            return ((p * r * t) / 100);
        }
    }

    class ICICI : RBI
    {
        public override double calculateInterest(double p, double r, double t)
        {
            return ((p * r * t) / 100);
        }
    }
}
