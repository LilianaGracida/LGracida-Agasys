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
            int indice;
            string abecedario = "abcdefghijklmnopqrstuvwxyz";
            char[] abc = abecedario.ToCharArray();
            string s = "bcdefghijklmnopkrstuvwxya";
            char[] chars = s.ToCharArray();

            Console.WriteLine("Escribe una palabra");
            string palabra = Console.ReadLine();
            char[] letras = palabra.ToCharArray();

            char[] cambio = new char[letras.Length];
            int i = -1;
            foreach (char c in letras)
            {
                i++;
                indice = Array.IndexOf(abc, c);
                if (indice == -1)
                {
                    Console.WriteLine("El elemento {0} no existe", letras);
                }
                else
                {
                    cambio[i] = chars[indice];
                    //Console.WriteLine("El elemento {0} existe en la posición {1}", letras, indice);
                }
                
            }
            
            foreach (int letter in cambio)
            {
                Console.WriteLine((char)letter);
            }
           
        }
    }
}
