using System.Collections.Generic;
using System.Linq;
using ComercioArtes.Models;

namespace ComercioArtes.Data
{
    /// <summary>
    /// Repositorio central de datos en memoria.
    /// Patrón Singleton: solo existe una instancia en toda la aplicación.
    /// </summary>
    public sealed class DataStore
    {
        private static readonly DataStore _instancia = new DataStore();
        public static DataStore Instancia => _instancia;

        // Contadores de IDs auto-incrementales
        private int _nextIdArtista        = 1;
        private int _nextIdComprador      = 1;
        private int _nextIdObra           = 1;
        private int _nextIdGaleria        = 1;
        private int _nextIdGaleriaObra    = 1;
        private int _nextIdFactura        = 1;
        private int _nextIdDetalleFactura = 1;

        public int SiguienteIdArtista()        => _nextIdArtista++;
        public int SiguienteIdComprador()      => _nextIdComprador++;
        public int SiguienteIdObra()           => _nextIdObra++;
        public int SiguienteIdGaleria()        => _nextIdGaleria++;
        public int SiguienteIdGaleriaObra()    => _nextIdGaleriaObra++;
        public int SiguienteIdFactura()        => _nextIdFactura++;
        public int SiguienteIdDetalleFactura() => _nextIdDetalleFactura++;

        // Colecciones principales
        public List<Artista>       Artistas        { get; } = new List<Artista>();
        public List<Comprador>     Compradores     { get; } = new List<Comprador>();
        public List<Obra>          Obras           { get; } = new List<Obra>();
        public List<Galeria>       Galerias        { get; } = new List<Galeria>();
        public List<GaleriaObra>   GaleriasObras   { get; } = new List<GaleriaObra>();
        public List<Factura>       Facturas        { get; } = new List<Factura>();
        public List<DetalleFactura>DetallesFactura { get; } = new List<DetalleFactura>();

        private DataStore() => CargarDemostracion();

        private void CargarDemostracion()
        {
            // ── Artistas ──────────────────────────────────────────
            Artistas.Add(new Artista(SiguienteIdArtista(), "Valentina Ríos",
                "valentina@arte.com", "+56 9 1111 2222",
                "Nicaragua", "Pintora surrealista con influencias latinoamericanas.",
                "Exposiciones en Chile, Argentina y España. Premio Nacional 2019."));

            Artistas.Add(new Artista(SiguienteIdArtista(), "Marco Delgado",
                "marco@arte.mx", "+52 55 3333 4444",
                "Nicaragua", "Escultor contemporáneo que trabaja con bronce y mármol.",
                "20 años de carrera. Colecciones en museos de EE.UU. y Europa."));

            Artistas.Add(new Artista(SiguienteIdArtista(), "Sofía Herrera",
                "sofia@arte.co", "+57 300 555 6666",
                "Nicaragua", "Fotógrafa documental y artística, enfoque en cultura andina.",
                "Ganadora del concurso Iberoamericano de Fotografía 2022."));

            Artistas.Add(new Artista(SiguienteIdArtista(), "Tomás Aguirre",
                "tomas@arte.ar", "+54 11 7777 8888",
                "Argentina", "Artista digital y grabador. Mezcla técnicas tradicionales con lo digital.",
                "Cofundador del colectivo PixelArte Buenos Aires."));

            // ── Obras ─────────────────────────────────────────────
            Obras.Add(new Obra(SiguienteIdObra(), "Raíces del Sur",
                "Óleo sobre lienzo, colores vibrantes que evocan la pampa.",
                TecnicaObra.Oleo, "120 x 90 cm", 2020, 3800m, 1));

            Obras.Add(new Obra(SiguienteIdObra(), "Fragmento Eterno",
                "Escultura en bronce fundido, forma orgánica abstracta.",
                TecnicaObra.Escultura, "45 x 30 x 25 cm", 2018, 9500m, 2));

            Obras.Add(new Obra(SiguienteIdObra(), "Luz del Mercado",
                "Fotografía fine art, edición limitada de 10 copias.",
                TecnicaObra.Fotografia, "80 x 60 cm", 2021, 780m, 3));

            Obras.Add(new Obra(SiguienteIdObra(), "Ciudad Invisible",
                "Grabado sobre papel de algodón, tiraje de 20.",
                TecnicaObra.Grabado, "50 x 40 cm", 2022, 450m, 4));

            Obras.Add(new Obra(SiguienteIdObra(), "Sueño Azul",
                "Técnica mixta: acuarela y collage sobre cartón.",
                TecnicaObra.Mixta, "60 x 45 cm", 2023, 1200m, 1));

            Obras.Add(new Obra(SiguienteIdObra(), "Montaña de Piedra",
                "Escultura en mármol blanco, pieza única.",
                TecnicaObra.Escultura, "60 x 40 x 40 cm", 2017, 14000m, 2));

            Obras.Add(new Obra(SiguienteIdObra(), "Retrato Digital #7",
                "Arte digital impreso en aluminio, edición de 5.",
                TecnicaObra.Digital, "70 x 50 cm", 2023, 620m, 4));

            // La obra 3 se marca como Vendida para el demo de factura
            Obras[2].Estado = EstadoObra.Vendida;

            // ── Galerías ──────────────────────────────────────────
            Galerias.Add(new Galeria(SiguienteIdGaleria(), "Galería Meridian",
                "Espacio de arte contemporáneo y vanguardista.",
                "Av. Las Artes 1240, Santiago", "+56 2 2345 6789"));

            Galerias.Add(new Galeria(SiguienteIdGaleria(), "Espacio Tierra",
                "Galería enfocada en arte latinoamericano y fotografía.",
                "Calle Palma 88, Medellín", "+57 4 234 5678"));

            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 1, 1));
            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 1, 2));
            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 1, 5));
            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 2, 3));
            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 2, 4));
            GaleriasObras.Add(new GaleriaObra(SiguienteIdGaleriaObra(), 2, 7));

            // ── Compradores ───────────────────────────────────────
            Compradores.Add(new Comprador(SiguienteIdComprador(), "Ana García",
                "ana@correo.com", "+1 555 0101",
                "Av. Principal 456, Miami", MetodoPago.TarjetaCredito));

            Compradores.Add(new Comprador(SiguienteIdComprador(), "Luis Mendoza",
                "luis@correo.com", "+1 555 0202",
                "Calle 45 #67, Nueva York", MetodoPago.Transferencia));

            Compradores.Add(new Comprador(SiguienteIdComprador(), "Sara Williams",
                "sara@correo.com", "+44 20 1234 5678",
                "Oxford St. 89, Londres", MetodoPago.PayPal));

            // ── Factura de demo ───────────────────────────────────
            var f1 = new Factura(SiguienteIdFactura(), 1, 780m);
            Facturas.Add(f1);
            DetallesFactura.Add(new DetalleFactura(SiguienteIdDetalleFactura(), 1, 3, 780m));
        }

        // ── Helpers de búsqueda ───────────────────────────────────
        public Artista   BuscarArtista(int id)   => Artistas.Find(a => a.Id == id);
        public Comprador BuscarComprador(int id) => Compradores.Find(c => c.Id == id);
        public Obra      BuscarObra(int id)      => Obras.Find(o => o.Id == id);
        public Galeria   BuscarGaleria(int id)   => Galerias.Find(g => g.Id == id);

        public List<Obra> ObrasDeGaleria(int idGaleria)
        {
            var ids = GaleriasObras
                .Where(go => go.IdGaleria == idGaleria)
                .Select(go => go.IdObra)
                .ToList();
            return Obras.Where(o => ids.Contains(o.Id)).ToList();
        }   

        public List<DetalleFactura> DetallesDeFactura(int idFactura) =>
            DetallesFactura.Where(d => d.IdFactura == idFactura).ToList();

        public decimal IngresosTotales() =>
            Facturas
                .Where(f => f.Estado == EstadoFactura.Emitida)
                .Sum(f => f.Total);
    }
}
