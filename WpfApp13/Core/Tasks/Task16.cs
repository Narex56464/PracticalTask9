using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task16
    {
        private int N;
        private double A;
        private double B;

        public Task16(int n, double a, double b)
        {
            N = n;
            A = a;
            B = b;
        }

        public (double H, double[] point) Values()
        {
            double H = (B - A) / (N - 1);

            double[] point = new double[N];

            for(int i = 0; i < N; i++)
            {
                point[i] = A + i * H;
            }
            return (H, point);
        }
    }
}
