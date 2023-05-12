using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Lista de ejercicios");
                Console.WriteLine("1.- Ejercicio 8");
                Console.WriteLine("2.- Ejercicio 9");
                Console.WriteLine("3.- Ejercicio 10");
                Console.WriteLine("4.-Factorial");
                Console.WriteLine("5.-Cambio de letras");
                Console.WriteLine("6.- Sopa de letras");
                Console.WriteLine("7.- Palabra mas larga");
                Console.WriteLine("8.- Salir");
                Console.WriteLine("Eliga una opcion");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    PL.EdadPersonas.Calcular();
                }
                else if (opcion == 2)
                {
                    PL.Elecciones.Votar();
                }
                else if (opcion == 3)
                {
                    PL.Empleado.Empleado1();
                    PL.Empleado.Empleado2();
                    PL.Empleado.Empleado3();
                }
                else if (opcion == 4)
                {
                PL.Factorial.CalcularFactorial();
                }
                else if (opcion == 5)
                {
                PL.CambioLetras.Cambio();
                }
                else if(opcion == 6)
                {
                PL.SopaLetras.SopaDeLetras();
                }
                else if (opcion == 7)
                {
                PL.PalabraMasLarga.palabraMasLarga();
                }
                else if(opcion == 8)
                {
                return;
                }

                Console.ReadKey();
        }
    }
}
