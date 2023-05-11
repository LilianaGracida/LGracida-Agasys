using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Elecciones
    {
        public static void Votar()
        {
            List<string> listaVotos = new List<string>();
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Para estas elecciones se tienen 3 candidatos");
                Console.WriteLine("1.- Juan \n" +  "2.- Maria \n"+ "3.- Lucia");
                Console.WriteLine("Escribe el nombre del candidato por quien desea votar");
                string Nombre = Console.ReadLine();
                listaVotos.Add(Nombre);
            }
            ML.Elecciones elecciones = BL.Elecciones.Votos(listaVotos);
            if (elecciones.Correct)
            {
                Console.WriteLine("Aqui tiene el resultado de las elecciones");
                Console.WriteLine("El Primer Lugar es para  "+elecciones.Nombre1 +" con "+elecciones.Primero+"votos");
                Console.WriteLine("El Segundo Lugar es para  " + elecciones.Nombre2 + " con " + elecciones.Segundo + "votos");
                Console.WriteLine("El TercerLugar es para  " + elecciones.Nombre3 + " con " + elecciones.Tercero + "votos");
            }
        }
    }
}
