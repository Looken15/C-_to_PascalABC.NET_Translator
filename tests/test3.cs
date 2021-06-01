using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class test3
    {
        static int Inc(int a, string b, byte c)
        {
            a += b.Length;
            return a + c;
        }

        static void Pr()
        {
            Console.WriteLine("privet");
        }

        static void Main()
        {
            var res = Inc(5, "b", 001);
            Pr();
        }
    }
}
