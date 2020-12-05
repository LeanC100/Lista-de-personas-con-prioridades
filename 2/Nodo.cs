using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Nodo
    {
        public string Nombre { get; set; }

        public string Prioridad { get; set; }
        public Nodo Siguiente { get; set; }
        public override string ToString()
        {
            return ($"{Nombre}");
        }

    }
}
