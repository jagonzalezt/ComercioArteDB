using System;

namespace ComercioArtes.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdComprador { get; set; }
        public decimal Total { get; set; }
        public EstadoFactura Estado { get; set; }

        public Factura()
        {
            Fecha  = DateTime.Now;
            Estado = EstadoFactura.Emitida;
        }

        public Factura(int id, int idComprador, decimal total)
        {
            Id           = id;
            IdComprador  = idComprador;
            Total        = total;
            Fecha        = DateTime.Now;
            Estado       = EstadoFactura.Emitida;
        }
    }
}
