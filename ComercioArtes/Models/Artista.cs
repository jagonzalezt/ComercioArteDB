namespace ComercioArtes.Models
{
    public class Artista : Persona
    {
        public string Pais { get; set; }
        public string Biografia { get; set; }
        public string Trayectoria { get; set; }

        public Artista()
        {
            Pais = string.Empty;
            Biografia = string.Empty;
            Trayectoria = string.Empty;
        }

        public Artista(int id, string nombre, string correo, string telefono,
                       string pais, string biografia, string trayectoria)
            : base(id, nombre, correo, telefono)
        {
            Pais = pais;
            Biografia = biografia;
            Trayectoria = trayectoria;
        }

        public override string Rol => "Artista";
    }
}
