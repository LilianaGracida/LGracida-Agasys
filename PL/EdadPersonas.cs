using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class EdadPersonas
    {
        public static void Calcular()
        {
            ML.EdadPersonas edadPersonas = new ML.EdadPersonas();
            List<int> Edades =new List<int>();
            Console.WriteLine("Ingrese la edad de 10 personas");
            for(int i = 1;i <= 10;i++)
            {
               Console.WriteLine("Ingresa a edad de la persona "+i);
               int Edad = int.Parse(Console.ReadLine());
             
               Edades.Add(Edad);
            }
            edadPersonas = BL.EdadPersonas.Calculo(Edades);
            if (edadPersonas.Correct)
            {
                
                Console.WriteLine("\n De las 10 edades ingresadas");
                Console.WriteLine( " Son Mayores de Edad "+edadPersonas.Adultos );
                Console.WriteLine(" Son Menores de Edad " + edadPersonas.Menores);
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
        }
    }
}
