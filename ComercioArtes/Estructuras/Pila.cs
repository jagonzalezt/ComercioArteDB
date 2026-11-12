using System;
using System.Collections.Generic;

namespace ComercioArtes.Estructuras
{
    // Pila: lo ultimo que entra es lo primero que sale (LIFO).
    // En NicaArt se usa para deshacer la ultima obra agregada a una factura.
    public class Pila<T>
    {
        private Nodo<T> tope;   // el ultimo nodo que se agrego
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
        }

        public bool EstaVacia()
        {
            return tope == null;
        }

        // Agrega un dato encima de la pila
        public void Apilar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = tope;
            tope = nuevo;
            cantidad++;
        }

        // Saca y devuelve el dato que esta arriba
        public T Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila esta vacia.");

            T dato = tope.Dato;
            tope = tope.Siguiente;
            cantidad--;
            return dato;
        }

        // Devuelve el dato de arriba sin sacarlo
        public T VerTope()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila esta vacia.");

            return tope.Dato;
        }

        // Devuelve los datos desde el tope hacia abajo (para mostrarlos)
        public List<T> ComoLista()
        {
            List<T> lista = new List<T>();
            Nodo<T> actual = tope;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}
