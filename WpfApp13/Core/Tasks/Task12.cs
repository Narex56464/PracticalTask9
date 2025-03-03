using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task12
    {
        private double X;
        private int N;

        public Task12(double x, int n)
        {
            X = x;
            N = n;
        }

        public double FindValue()
        {
            double substraction = X;

            for (int i = 1; i <= N; i++)
            {
                substraction += ((-1) * i * X * (2 * i + 1)) / (2 * i + 1);
            }
            return substraction;
        }
    }
}
