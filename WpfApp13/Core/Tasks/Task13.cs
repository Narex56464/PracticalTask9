using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task13
    {
        private double X;
        private int N;

        public Task13(double x, int n)
        {
            X = x;
            N = n;
        }

        public double FindValue()
        {
            double substraction = 1;

            for (int i = 1; i <= N; i++)
            {
                substraction += ((-1) * i * X * (2 * i)) / (2 * i);
            }
            return substraction;
        }
    }
}
