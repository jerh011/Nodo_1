using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo_1
{
    class Lista
    {
        private Nodo _primero=new Nodo();
        private Nodo _ultimo=new Nodo();

        public Lista() {
            _primero = null;
            _ultimo = null;
        }
        public void InsertaNodo() { 
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato del nuevo Nodo: ");
            nuevo.Dato = Convert.ToInt32(Console.ReadLine());
            if (_primero == null)
            {
                _primero = nuevo;
                _primero.Siguiente = _primero;
                _ultimo = _primero;
            }
            else {
                _ultimo.Siguiente = nuevo;
                nuevo.Siguiente = _primero;
                _ultimo=nuevo;
            }
            Console.WriteLine("\n Nodo ingresado con Exito\n\n");
        }

        public void DesplegarLista() {
            Nodo actual= new Nodo();
            actual = _primero;

            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                } while (actual != _primero);

            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
            }
        
        }


    }
}
