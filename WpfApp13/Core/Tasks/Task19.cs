using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task19
    {
        private double D;

        public Task19(double d)
        {
            D = d;
        }

        public (int K, double AK_1, double AK) FindFirstK()
        {
            double AK_1 = 1;
            double AK = 2;

            int k = 2;
            while (true)
            {
                AK = (AK_1 - AK) / 2;
                ++k;
                if (Math.Abs(AK - AK_1) < D)
                {
                    return (k, AK_1, AK);
                }
                AK_1 = AK;
            }
        }
    }
}
