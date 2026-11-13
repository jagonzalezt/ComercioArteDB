using System;
using System.Collections.Generic;

namespace ComercioArtes.Estructuras
{
   
    public class Cola<T>
    {
        private Nodo<T> frente;   // el primero de la cola
        private Nodo<T> final;    // el ultimo de la cola
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        // Agrega un dato al final de la cola
        public void Encolar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);

            if (EstaVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
            cantidad++;
        }

        // Saca y devuelve el dato que esta al frente
        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola esta vacia.");

            T dato = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null)
                final = null;
            cantidad--;
            return dato;
        }

        // Devuelve el dato del frente sin sacarlo
        public T VerFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola esta vacia.");

            return frente.Dato;
        }

        // Devuelve los datos desde el frente hasta el final (para mostrarlos)
        public List<T> ComoLista()
        {
            List<T> lista = new List<T>();
            Nodo<T> actual = frente;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}
