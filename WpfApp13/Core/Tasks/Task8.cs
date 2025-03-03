using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task8
    {
        private double A;

        public Task8(double a)
        {
            A = a;
        }

        public string Less()
        {
            double s = 0;
            int N = 0;

            while(s <= A)
            {
                N++;
                s += 1.0 / N;
            }
            return $"Сумма = {s}\nN = {N}";
        }
    }
}
