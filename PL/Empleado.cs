using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Empleado
    {
        public static void Empleado1()
        {
            ML.Empleado empleado = new ML.Empleado();
            
                Console.WriteLine("Escriba su Nombre");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Escriba su Apellido");
                empleado.Apellido = Console.ReadLine();
                Console.WriteLine("Escriba su sueldo diario");
                empleado.SueldoDiario = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el numero de dias trabajados");
                empleado.DiasTrabajados = int.Parse(Console.ReadLine());

                empleado = BL.Empleado.Calcula_Sueldo(empleado);

                if (empleado.Correct)
                {
                    Console.WriteLine("Empleado 1");
                    Console.WriteLine(empleado.Nombre+" "+empleado.Apellido);
                    Console.WriteLine("El sueldo por "+empleado.DiasTrabajados+" dias trabajados es "+empleado.Sueldo);
                }
            }
        public static void Empleado2()
        {
            ML.Empleado empleado = new ML.Empleado();

            Console.WriteLine("Escriba su Nombre");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido");
            empleado.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su sueldo diario");
            empleado.SueldoDiario = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero de dias trabajados");
            empleado.DiasTrabajados = int.Parse(Console.ReadLine());

            empleado = BL.Empleado.Calcula_Sueldo(empleado);

            if (empleado.Correct)
            {
                Console.WriteLine("Empleado 2");
                Console.WriteLine(empleado.Nombre + " " + empleado.Apellido);
                Console.WriteLine("El sueldo por " + empleado.DiasTrabajados + " dias trabajados es " + empleado.Sueldo);
            }
        }
        public static void Empleado3()
        {
            ML.Empleado empleado = new ML.Empleado();

            Console.WriteLine("Escriba su Nombre");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido");
            empleado.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su sueldo diario");
            empleado.SueldoDiario = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero de dias trabajados");
            empleado.DiasTrabajados = int.Parse(Console.ReadLine());

            empleado = BL.Empleado.Calcula_Sueldo(empleado);

            if (empleado.Correct)
            {
                Console.WriteLine("Empleado 3");
                Console.WriteLine(empleado.Nombre + " " + empleado.Apellido);
                Console.WriteLine("El sueldo por " + empleado.DiasTrabajados + " dias trabajados es " + empleado.Sueldo);
            }
        }
    }
}
