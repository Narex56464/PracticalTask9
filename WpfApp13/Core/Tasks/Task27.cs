using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task27
    {
        public double SumSquares()
        {
            double[] squares = new double[68];
            
            for (int i = 12, j = 0; i < 80; i++, ++j)
            {
                squares[j] = Math.Pow(i, 2);
            }

            double sum = 0;
            for(int i = 0; i < squares.Length; ++i)
            {
                sum += squares[i];
            }


            return sum;
        }
    }
}
