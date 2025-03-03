using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task10
    {
        private int N;

        public Task10(int n)
        {
            N = n;
        }

        public double Multiplication()
        {
            double multi = 2;

            for(int i = 2; i <= N; i++)
            {
                multi *= 1.0/ i;
            }
            return multi;
        }
    }
}
