using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Factorial
    {
        public static void CalcularFactorial()
        {
			int numero, i, resultado=1;
			Console.Write("Introduce un numero : ");
			numero=int.Parse( Console.ReadLine());
			
			for ( i = 1; i <= numero; i++)
			{
				resultado = resultado * i;
			}
			Console.WriteLine("El factorial de {0} es {1}", numero, resultado);

			
		}
    }
}
