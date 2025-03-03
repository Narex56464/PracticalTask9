using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task20
    {
        private int N;

        public Task20(int n)
        {
            N = n;
        }

        public List<int> Numbers()
        {
            List<int> numbers = new List<int>();

            for(int i = 10; i <= N; i++)
            {
                if(i % 5 == 0 && i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }
}
