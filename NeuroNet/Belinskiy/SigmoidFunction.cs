using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    public class SigmoidFunction : Function
    {
        public override double GetValue(double value)
        {
            return 1.0 / (1.0 + Math.Exp(-value));
        }

        public override double GetFunctionDerivative(double value)
        {
            return value * (1.0 - value);
        }

    }
}
