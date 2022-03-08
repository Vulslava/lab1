using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Integration;

namespace WindowsFormsApp1
{
    public class Integral : InterfaceIntegral
    {
        private double numbPart;

        public Integral(double numbPart)
        {
            this.numbPart = numbPart;
        }

        public double Calculate(Func<double, double> func, double down, double up)
        {
            return DoubleExponentialTransformation.Integrate(func, down, up, numbPart);
        }
    }
}
