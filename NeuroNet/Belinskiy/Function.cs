using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    public abstract class Function
    {
        public abstract double GetValue(double value);

        public abstract double GetFunctionDerivative(double value);
    }
}
