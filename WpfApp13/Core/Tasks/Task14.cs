using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task14
    {
        private double X;
        private int N;

        public Task14(double x, int n)
        {
            X = x;
            N = n;
        }

        public double FindValue()
        {
            double substraction = X;

            for (int i = 1; i <= N; i++)
            {
                substraction += ((-1) * i * 1 * X * i) / (i);
            }
            return substraction;
        }

        public string EqualInValue()
        {
            double value = FindValue();
            if (value == Math.Log10(1 + X)) return "Полученное число является приближенным значением функции";
            else return "Полученное число не является приближенным значением функции";
        }   
    }
}
