using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Elecciones
    {
        public static ML.Elecciones Votos(List<string> listaVotos)
        {
            ML.Elecciones elecciones = new ML.Elecciones();
            foreach (string voto in listaVotos)
            {
                if (voto == "Juan")
                {
                    elecciones.Candidato1++;
                }
                else if (voto == "Maria")
                {
                    elecciones.Candidato2++;
                }
                else if (voto == "Lucia")
                {
                    elecciones.Candidato3++;
                }
                else
                {
                    elecciones.Invalido++;
                }
            }
            //Encontrar los lugares de acuerdo al numero de votos
            if (elecciones.Candidato1 > elecciones.Candidato2)
            {
                elecciones.Primero = elecciones.Candidato1;
                elecciones.Nombre1 = "Juan";
            }
            else
            {
                elecciones.Primero = elecciones.Candidato2;
                elecciones.Nombre2 = "Maria";
            }
            if (elecciones.Candidato3 > elecciones.Primero)
            {
                elecciones.Primero = elecciones.Candidato3;
                elecciones.Nombre3 = "Lucia";
            }
            if (elecciones.Candidato1 < elecciones.Candidato2)
            { elecciones.Tercero = elecciones.Candidato1;
                elecciones.Nombre1 = "Juan";
            }
            else
            {
                elecciones.Tercero = elecciones.Candidato2;
                elecciones.Nombre2 = "Maria";
            }
            if (elecciones.Candidato3 < elecciones.Tercero)
            { elecciones.Tercero = elecciones.Candidato3;
                elecciones.Nombre3 = "Lucia";
            } 
            if ((elecciones.Candidato1 != elecciones.Primero) & (elecciones.Candidato1 != elecciones.Tercero))
            {
                elecciones.Segundo = elecciones.Candidato1;
                elecciones.Nombre1 = "Juan";
            }
            else
            {
                if ((elecciones.Candidato2 != elecciones.Primero) & (elecciones.Candidato2 != elecciones.Tercero))
                {
                    elecciones.Segundo = elecciones.Candidato2;
                    elecciones.Nombre2 = "Maria";
                }
                else
                {
                    elecciones.Segundo = elecciones.Candidato3;
                    elecciones.Nombre3 = "Lucia";
                }
            }
            elecciones.Correct = true;
            return elecciones;
        }
    }
}
