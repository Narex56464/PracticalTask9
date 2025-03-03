using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task4
    {
        private double A;
        private int N;

        public Task4(double a, int n)
        {
            A = a;
            N = n;
        }

        public List<int> FindDegree()
        {
            List<int> degree = new List<int>();

            for (int i = 1; i <= N; ++i)
            {
                degree.Add(i);
            }
            return degree;
        }
    }
}
