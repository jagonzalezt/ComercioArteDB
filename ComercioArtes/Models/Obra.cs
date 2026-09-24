namespace ComercioArtes.Models
{
    public class Obra
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TecnicaObra Tecnica { get; set; }
        public string Dimensiones { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public EstadoObra Estado { get; set; }
        public int IdArtista { get; set; }

        public Obra()
        {
            Titulo = string.Empty;
            Descripcion = string.Empty;
            Dimensiones = string.Empty;
            Estado = EstadoObra.Disponible;
        }

        public Obra(int id, string titulo, string descripcion, TecnicaObra tecnica,
                    string dimensiones, int anio, decimal precio, int idArtista)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Tecnica = tecnica;
            Dimensiones = dimensiones;
            Anio = anio;
            Precio = precio;
            IdArtista = idArtista;
            Estado = EstadoObra.Disponible;
        }

        public override string ToString() => Titulo;
    }
}
