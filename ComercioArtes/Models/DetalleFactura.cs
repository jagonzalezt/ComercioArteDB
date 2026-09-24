namespace ComercioArtes.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdObra { get; set; }
        public decimal PrecioVenta { get; set; }

        public DetalleFactura() { }

        public DetalleFactura(int id, int idFactura, int idObra, decimal precioVenta)
        {
            Id          = id;
            IdFactura   = idFactura;
            IdObra      = idObra;
            PrecioVenta = precioVenta;
        }
    }
}
