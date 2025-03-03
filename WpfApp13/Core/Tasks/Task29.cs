using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task29
    {
        private double A;
        private int N;

        public Task29(double a, int n)
        {
            A = a;
            N = n;
        }

        public string DiffirentSquares()
        {
            double diffirent_squares = 0;

            for(double i = A; i < N; i++)
            {
                diffirent_squares -= Math.Pow(i, 2);
            }

            double diffirent = 0;

            for (double i = 1; i <= N; i++)
            {
                diffirent_squares -= i;
            }

            return $"Разность квадратов: {diffirent_squares}\nРазность натуральных чисел N: {diffirent}";
        }
    }
}
