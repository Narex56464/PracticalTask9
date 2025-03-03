using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task23
    {
        private int N;

        public Task23(int n)
        {
            N = n;
        }

        public (double factorial, double degree) Factorial()
        {
            double factorial = 1;
            double degree = 1;
            for(int i = 2; i <= N; ++i)
            {
                factorial *= i;
                degree += Math.Pow(2, i);
            }
            return (factorial, degree);
        }
    }
}
