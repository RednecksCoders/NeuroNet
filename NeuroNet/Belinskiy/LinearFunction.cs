using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    public class LinearFunction : Function
    {
        public override double GetValue(double value)
        {
            return value;
        }

        public override double GetFunctionDerivative(double value) 
        {
            return 1;
        }
    }
}
