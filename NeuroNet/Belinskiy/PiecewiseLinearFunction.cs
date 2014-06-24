using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    // кусочно-линейная функция
    class PiecewiseLinearFunction : Function
    {
        public override double GetValue(double value)
        {
            if (value >= 0.5)
            {
                return 1;
            }
            else if (value>-0.5 && value<0.5)
            {
                return Math.Abs(value);
            }

            return 0;
        }

        public override double GetFunctionDerivative(double value)
        {
            return 0;
        }
    }
}
