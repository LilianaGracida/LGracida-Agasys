using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Elecciones
    {
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public int Candidato1 { get; set; } 
        public int Candidato2 { get; set; }
        public int Candidato3 { get; set; }
        public int Invalido { get; set; }
        public bool Correct { get; set; }
        public int Primero { get; set; }
        public int Segundo { get; set; }
        public int Tercero { get; set; }
    }
}
