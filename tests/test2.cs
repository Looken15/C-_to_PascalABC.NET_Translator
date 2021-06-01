using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class test2
    {
        static void Main()
        {
            for (int i = 0; i < 3; ++i)
            {
                int a = i;
            }

            double[] vs = new double[3];
            int k = 0;
            foreach (var x in vs)
            {
                vs[k] = x;
                k = k + 1;
            }

            int j = 0;
            while (j != 3)
            {
                k = j;
                j = j + 1;
            }


        }
    }
}
