using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task18
    {
        private double D;

        public Task18(double d)
        {
            D = d;
        }

        public (int K, double AK_1, double AK) FindFirstK()
        {
            double AK_1 = 2;
            double AK = 2;

            int k = 1;
            while (true)
            {
                AK = 2 + 1 / AK_1;
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
