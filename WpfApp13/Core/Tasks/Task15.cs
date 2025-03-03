using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task15
    {
        private double X;
        private int N;

        public Task15(double x, int n)
        {
            X = x;
            N = n;
        }

        public double FindValue()
        {
            double substraction = X;

            for (int i = 1; i <= N; i++)
            {
                substraction += ((-1) * i * X * (2 * i + 1)) / (2 * N + 1);
            }
            return substraction;
        }

        public string EqualInValue()
        {
            double value = FindValue();
            if (value == Math.Atan(X)) return "Полученное число является приближенным значением функции";
            else return "Полученное число не является приближенным значением функции";
        }
    }
}
