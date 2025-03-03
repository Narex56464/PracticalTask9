using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task24
    {
        private int N;

        public Task24(int n)
        {
            N = n;
        }

        public int Numbers()
        {
            int x = 0;

            for(; N != 0; N /= 10)
            {
                int r = N / 10;
                if(r > x) x = r;
            }

            return x;
        }
    }
}
