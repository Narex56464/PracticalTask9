using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task11
    {
        private double X;
        private int N;

        public Task11(double x, int n)
        {
            X = x;
            N = n;
        }

        public double FindValue()
        {
            double sum = 1;

            for(int i = 1; i <= N; i++)
            {
                sum += (X * i) / i;
            }
            return sum;
        }
    }
}
