using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task9
    {
        private int N;

        public Task9(int n)
        {
            N = n;
        }

        public double Multiplication()
        {
            double multi = 1.0;

            for(int i = 1; i <= N; ++i)
            {
                multi *= i;
            }
            return multi;
        }
    }
}
