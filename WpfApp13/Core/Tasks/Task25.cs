using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task25
    {
        private int N;

        public Task25(int n)
        {
            N = n;
        }

        public string Numbers()
        {
            int x = 0;

            int k = 0;
            int sum = 0;

            while(N >= 10)
            {
                k = N % 10;
                N = N / 10;
                sum += k;
            }
            sum += N;

            return $"Первая цифра числа: {N}\nСумма цифр цисла: {sum}";
        }
    }
}
