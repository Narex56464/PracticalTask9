using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task2
    {
        private int A;
        private int B;

        public Task2(int a, int b)
        {
            A = a;
            B = b;
        }

        public List<int> FindNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = B; i >= A; i--)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        public int FindN()
        {
            return B - A + 1;
        }
    }
}
