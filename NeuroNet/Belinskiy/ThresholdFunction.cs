using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    // функция единичного скачка (пороговая)
    class ThresholdFunction : Function
    {
        public override double GetValue(double value)
        {
            if (value >= 0)
            {
                return 1;
            }
            return 0;
        }

        public override double GetFunctionDerivative(double value)
        {
            return 0;
        }
    }
}
