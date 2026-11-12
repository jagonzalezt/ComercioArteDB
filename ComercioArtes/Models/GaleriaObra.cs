using System;

namespace ComercioArtes.Models
{
    /// <summary>
    /// Tabla intermedia que resuelve la relación muchos a muchos
    /// entre Galeria y Obra (una galería puede tener muchas obras
    /// y una obra puede estar en varias galerías).
    /// </summary>
    public class GaleriaObra
    {
        public int Id { get; set; }
        public int IdGaleria { get; set; }
        public int IdObra { get; set; }
        public DateTime FechaIngreso { get; set; }

        public GaleriaObra() { }

        public GaleriaObra(int id, int idGaleria, int idObra)
        {
            Id = id;
            IdGaleria = idGaleria;
            IdObra = idObra;
            FechaIngreso = DateTime.Today;
        }
    }
}
