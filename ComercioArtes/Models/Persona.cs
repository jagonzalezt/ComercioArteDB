namespace ComercioArtes.Models
{
    /// <summary>
    /// Clase base abstracta que representa a cualquier persona en el sistema.
    /// Principio OOP: Herencia + Abstracción.
    /// </summary>
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        protected Persona()
        {
            Nombre = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
        }

        protected Persona(int id, string nombre, string correo, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }

        // Cada subclase define su propio rol (polimorfismo)
        public abstract string Rol { get; }

        public override string ToString() => Nombre;
    }
}
