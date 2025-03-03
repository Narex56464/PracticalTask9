using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task26
    {
        private int N;//202

        public Task26(int n)
        {
            N = n;
        }

        public int Palindrome()
        {
            int copy = 0;

            for (int i = N; i != 0; i /= 10)
            { 
                copy = copy * 10 + i % 10;
            }

            if (copy == N) return copy;
            return 0;
        }
    }
}
