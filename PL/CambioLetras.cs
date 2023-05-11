using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class CambioLetras
    {
        public static void Cambio()
        {

            string s = "abcdefghijklmnopqrstuvwxyz";
            char[] chars = s.ToCharArray();
            for (int ctr = 2; ctr < chars.Length; ctr++)
            {
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
            }

        }
    }
}
