using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class SopaLetras
    {
        public static void SopaDeLetras()
        {
            String s = "hola";

            s = String.Concat(s.OrderBy(ch => ch));

            Console.WriteLine(s);
        }
    }
}
