using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EdadPersonas
    {
        public static ML.EdadPersonas  Calculo(List<int> Edades)
        {
            ML.EdadPersonas edadPersona = new ML.EdadPersonas();
            try
            {
                foreach (int edad in Edades)
                {
                    if (edad >= 18)
                    {

                        edadPersona.Adultos++;
                    }
                    else
                    {
                        
                        edadPersona.Menores++;
                    }
                   
                }
                edadPersona.Correct = true;
                
                
            }
            catch (Exception ex)
            {
                edadPersona.ErrorMessage="Ocurrio un error"+ex;
            }
           
            return edadPersona;
        }
    }
}
