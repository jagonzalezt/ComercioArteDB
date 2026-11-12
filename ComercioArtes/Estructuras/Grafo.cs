using System.Collections.Generic;

namespace ComercioArtes.Estructuras
{
    // Grafo no dirigido con lista de adyacencia.
    // Cada nodo tiene una clave (por ejemplo "A1" para el artista 1,
    // "O3" para la obra 3 y "G2" para la galeria 2) y un nombre para mostrar.
    // En NicaArt relaciona artistas, obras y galerias.
    public class Grafo
    {
        private Dictionary<string, string> nombres = new Dictionary<string, string>();
        private Dictionary<string, List<string>> vecinos = new Dictionary<string, List<string>>();

        public void AgregarNodo(string clave, string nombre)
        {
            if (nombres.ContainsKey(clave))
                return;

            nombres[clave] = nombre;
            vecinos[clave] = new List<string>();
        }

        // Une dos nodos (la union va en los dos sentidos)
        public void AgregarArista(string clave1, string clave2)
        {
            if (!nombres.ContainsKey(clave1) || !nombres.ContainsKey(clave2))
                return;

            if (!vecinos[clave1].Contains(clave2))
                vecinos[clave1].Add(clave2);

            if (!vecinos[clave2].Contains(clave1))
                vecinos[clave2].Add(clave1);
        }

        public string NombreDe(string clave)
        {
            return nombres[clave];
        }

        public List<string> Vecinos(string clave)
        {
            return vecinos[clave];
        }

        // Recorrido en anchura (BFS) desde un nodo.
        // Devuelve, para cada nodo alcanzado, el nodo desde el que se llego a el.
        public Dictionary<string, string> RecorrerEnAnchura(string inicio)
        {
            Dictionary<string, string> padres = new Dictionary<string, string>();
            Cola<string> pendientes = new Cola<string>();

            padres[inicio] = null;
            pendientes.Encolar(inicio);

            while (!pendientes.EstaVacia())
            {
                string actual = pendientes.Desencolar();

                foreach (string vecino in vecinos[actual])
                {
                    if (!padres.ContainsKey(vecino))
                    {
                        padres[vecino] = actual;
                        pendientes.Encolar(vecino);
                    }
                }
            }
            return padres;
        }

        // Arma el camino desde el inicio hasta un destino, usando los padres del recorrido
        public List<string> CaminoHasta(Dictionary<string, string> padres, string destino)
        {
            List<string> camino = new List<string>();
            string actual = destino;

            while (actual != null)
            {
                camino.Insert(0, actual);
                actual = padres[actual];
            }
            return camino;
        }
    }
}
