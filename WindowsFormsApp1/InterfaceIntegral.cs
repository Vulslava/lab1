using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface InterfaceIntegral
    {
        double Calculate(Func<double, double> func, double down, double up);
    }
}
