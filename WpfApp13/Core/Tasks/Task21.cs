using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Core.Tasks
{
    public class Task21
    {
        public List<double> Sqares()
        {
            List<double> sqares = new List<double>();

            for(int i = 11; i <= 99; i++)
            {
                sqares.Add(Math.Pow(i, 2));
            }
            return sqares;
        }
    }
}
