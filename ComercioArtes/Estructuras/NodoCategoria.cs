using System.Collections.Generic;

namespace ComercioArtes.Estructuras
{
    // Un nodo del arbol de categorias.
    // Una categoria puede tener subcategorias (sus hijos).
    public class NodoCategoria
    {
        public string Nombre;
        public List<NodoCategoria> Hijos = new List<NodoCategoria>();

        // Obras que estan directamente en esta categoria (sin contar las subcategorias)
        public int ObrasPropias;
        public decimal ValorPropio;

        public NodoCategoria(string nombre)
        {
            Nombre = nombre;
        }
    }
}
