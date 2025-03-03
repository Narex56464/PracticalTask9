using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task6
    {
        private int N;

        public Task6(int n)
        {
            N = n;
        }

        public string FindK()
        {
            int k = 0;

            while((3 * k) <= N)
            {
                k++;
            }

            int thirdK = k * 3;

            return $"Наименьшее число = {k}\nЧисло 3K = {thirdK}";
        }
    }
}
