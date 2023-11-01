using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo_1
{
    class Nodo
    {
        private int _datos;
        private Nodo _Siguiente;

        public int Dato 
        {
            get { return _datos; }
            set { _datos = value; }
        }
        public Nodo Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }


    }
}
