using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peripherals_Lab3
{
    public static class DAC
    {
        public static double[] ConvertToAnalog(byte value, double c1, double c2, double e0)
        {
            var capCoeff = c1 / (c2 + c1);
            var sum = 0.0;
            var temp = new double[8];

            for (int i = 0; i < temp.Length; i++)
            {
                var delta = (e0 * (value & 1) - sum) * capCoeff;
                sum += delta;
                temp[i] = sum;
                value >>= 1;
            }
            return temp;
        }
    }
}
