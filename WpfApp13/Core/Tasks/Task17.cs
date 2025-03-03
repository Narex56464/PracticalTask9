using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task17
    {
        private int N;
        private double A;
        private double B;
        private double x;

        public Task17(int n, double a, double b)
        {
            N = n;
            A = a;
            B = b;
        }

        public (double[] result, double[] function) ValuesF()
        {
            double[] result = new double[N];
            double[] function = new double[N];

            double h = (B - A) / (N - 1);

            for(int i = 0; i < N; i++)
            {
                x = A + i * h;
                result[i] = x;
                function[i] = Function(x);
            }
            return (result, function);

        }

        public double Function(double x)
        {
            return 1 - Math.Sin(x);
        }
    }
}
