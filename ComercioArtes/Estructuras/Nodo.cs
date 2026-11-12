namespace ComercioArtes.Estructuras
{
    // Un nodo guarda un dato y apunta al siguiente nodo.
    // Lo usan la pila y la cola.
    public class Nodo<T>
    {
        public T Dato;
        public Nodo<T> Siguiente;

        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
