using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Cola
    {
        Nodo _inicio;
        public void AddCola(Nodo nodo, int prioridad)
        {
            if (_inicio == null)
            {
                _inicio = nodo;
            }
            else
            {
                if(prioridad==1)
                {
                    Nodo buscar = this.BuscarUltimoPrioridad1(_inicio);
                    Nodo aux = buscar.Siguiente;
                    buscar.Siguiente = nodo;
                    nodo.Siguiente = aux;

                }
                else if(prioridad==2)
                {
                    Nodo buscar = BuscarUltimoPrioridad2(_inicio);
                    Nodo aux = buscar.Siguiente;
                    buscar.Siguiente = nodo;
                    nodo.Siguiente = aux;
                }
                else
                {
                    Nodo buscar = this.BuscarUltimoPrioridad3(_inicio);
                    Nodo aux = buscar.Siguiente;
                    buscar.Siguiente = nodo;
                    nodo.Siguiente = aux;
                }
            }
        }

        public Nodo BuscarUltimoPrioridad1(Nodo nodo)
        {
            if (nodo.Siguiente == null)
            {
                return nodo;
            }else if (nodo.Siguiente.Prioridad == "2" )
            {
                return nodo;
            }
            else
            {
                return BuscarUltimoPrioridad1(nodo.Siguiente);
            }
        }
        public Nodo BuscarUltimoPrioridad2(Nodo nodo)
        {
            if (nodo.Siguiente != null)
            {

                if( nodo.Prioridad == "3" || nodo.Siguiente.Prioridad == "3")
                {
                    return nodo;
                }
                else
                {
                    return BuscarUltimoPrioridad2(nodo.Siguiente);
                }
            
            }
            else
            {
                return nodo;
            }
        }
        public Nodo BuscarUltimoPrioridad3(Nodo nodo)
        {
            if (nodo.Siguiente == null)
            {
                return nodo;
            }
            else
            {
                return BuscarUltimoPrioridad3(nodo.Siguiente);
            }
        }
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }
    }
}
