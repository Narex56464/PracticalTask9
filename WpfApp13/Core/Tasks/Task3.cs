using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task3
    {
        private double A;
        private int N;

        public Task3(double a, int n)
        {
            A = a;
            N = n;
        }

        public double FindA()
        {
            double degree = 1;

            for(int i = 0; i < N; ++i)
            {
                degree *= A;
            }
            return degree;
        }
    }
}
