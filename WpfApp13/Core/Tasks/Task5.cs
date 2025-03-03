using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task5
    {
        private double A;
        private int N;

        public Task5(double a, int n)
        {
            A = a;
            N = n;
        }

        public double PositiveExpression()
        {
            double sum = 1;

            for (int i = 1; i <= N; ++i)
            {
                sum += A * i;
            }
            return sum;
        }

        public double NegativeExpression()
        {
            double sum = 1;

            for (int i = 1; i <= N; ++i)
            {
                sum += Math.Pow(-1, i) * A;
            }
            return sum;
        }
    }
}
