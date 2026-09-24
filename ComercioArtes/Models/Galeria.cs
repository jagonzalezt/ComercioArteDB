namespace ComercioArtes.Models
{
    public class Galeria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }

        public Galeria()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Ubicacion = string.Empty;
            Telefono = string.Empty;
        }

        public Galeria(int id, string nombre, string descripcion,
                       string ubicacion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Telefono = telefono;
        }

        public override string ToString() => Nombre;
    }
}
