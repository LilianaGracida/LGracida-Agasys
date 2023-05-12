using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class PalabraMasLarga
    {
        public static void palabraMasLarga()
        {
            string palabraLarga = "";
            Console.WriteLine("Ingrese una cadena de texto");
            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split(' ');
            string[] palabrasLargas = new string[' '];
            foreach (string palabra in palabras)
            {
                if(palabra.Length > palabraLarga.Length)
                {
                    palabrasLargas = palabra.Split(' ');
                    
                }
            }
            palabraLarga = palabrasLargas[palabrasLargas.Length -1];
            Console.WriteLine("La palabra mas larga es: "+palabraLarga);
        }
    }
}
