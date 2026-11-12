namespace ComercioArtes.Estructuras
{
    // Arbol de categorias de obras. Ejemplo:
    //   Obras de arte
    //     Pintura
    //       Oleo
    //       Acuarela
    //     Escultura
    //     ...
    // Los totales de cada categoria se calculan con recursividad.
    public class ArbolCategorias
    {
        public NodoCategoria Raiz;

        public ArbolCategorias(string nombreRaiz)
        {
            Raiz = new NodoCategoria(nombreRaiz);
        }

        // Crea el arbol con las categorias que usa NicaArt
        public static ArbolCategorias CrearPorDefecto()
        {
            ArbolCategorias arbol = new ArbolCategorias("Obras de arte");

            arbol.AgregarCategoria("Obras de arte", "Pintura");
            arbol.AgregarCategoria("Pintura", "Óleo");
            arbol.AgregarCategoria("Pintura", "Acuarela");

            arbol.AgregarCategoria("Obras de arte", "Escultura");
            arbol.AgregarCategoria("Obras de arte", "Fotografía");

            arbol.AgregarCategoria("Obras de arte", "Arte gráfico");
            arbol.AgregarCategoria("Arte gráfico", "Grabado");
            arbol.AgregarCategoria("Arte gráfico", "Dibujo");
            arbol.AgregarCategoria("Arte gráfico", "Digital");

            arbol.AgregarCategoria("Obras de arte", "Otras técnicas");
            arbol.AgregarCategoria("Otras técnicas", "Mixta");
            arbol.AgregarCategoria("Otras técnicas", "Otro");

            return arbol;
        }

        // Busca una categoria por su nombre (recursivo)
        public NodoCategoria Buscar(NodoCategoria nodo, string nombre)
        {
            if (nodo.Nombre == nombre)
                return nodo;

            foreach (NodoCategoria hijo in nodo.Hijos)
            {
                NodoCategoria encontrado = Buscar(hijo, nombre);
                if (encontrado != null)
                    return encontrado;
            }
            return null;
        }

        // Agrega una subcategoria dentro de otra categoria
        public bool AgregarCategoria(string nombrePadre, string nombreNuevo)
        {
            NodoCategoria padre = Buscar(Raiz, nombrePadre);
            if (padre == null)
                return false;

            padre.Hijos.Add(new NodoCategoria(nombreNuevo));
            return true;
        }

        // Suma una obra a una categoria
        public bool AgregarObra(string nombreCategoria, decimal precio)
        {
            NodoCategoria categoria = Buscar(Raiz, nombreCategoria);
            if (categoria == null)
                return false;

            categoria.ObrasPropias++;
            categoria.ValorPropio += precio;
            return true;
        }

        // Cuenta las obras de una categoria y de todas sus subcategorias (recursivo)
        public int ContarObras(NodoCategoria nodo)
        {
            int total = nodo.ObrasPropias;

            foreach (NodoCategoria hijo in nodo.Hijos)
            {
                total = total + ContarObras(hijo);
            }
            return total;
        }

        // Suma el valor de una categoria y de todas sus subcategorias (recursivo)
        public decimal SumarValor(NodoCategoria nodo)
        {
            decimal total = nodo.ValorPropio;

            foreach (NodoCategoria hijo in nodo.Hijos)
            {
                total = total + SumarValor(hijo);
            }
            return total;
        }

        // Convierte el nombre de la tecnica que se guarda en la base de datos
        // (por ejemplo "Oleo") al nombre de la categoria del arbol ("Óleo")
        public static string CategoriaDeTecnica(string tecnica)
        {
            switch (tecnica)
            {
                case "Oleo": return "Óleo";
                case "Acuarela": return "Acuarela";
                case "Escultura": return "Escultura";
                case "Fotografia": return "Fotografía";
                case "Grabado": return "Grabado";
                case "Dibujo": return "Dibujo";
                case "Digital": return "Digital";
                case "Mixta": return "Mixta";
                default: return "Otro";
            }
        }
    }
}
