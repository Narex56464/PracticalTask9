using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task28
    {
        public double DiffirentSquares()
        {
            double[] squares = new double[66];

            for (int i = 22, j = 0; i < 88; i++, ++j)
            {
                squares[j] = Math.Pow(i, 2);
            }

            double diffirent = 0;
            for (int i = 0; i < squares.Length; ++i)
            {
                diffirent -= squares[i];
            }

            return diffirent;
        }
    }
}
