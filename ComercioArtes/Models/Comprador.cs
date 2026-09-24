using System;

namespace ComercioArtes.Models
{
    public class Comprador : Persona
    {
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public MetodoPago MetodoPago { get; set; }

        public Comprador()
        {
            Direccion = string.Empty;
            FechaRegistro = DateTime.Today;
            MetodoPago = MetodoPago.Efectivo;
        }

        public Comprador(int id, string nombre, string correo, string telefono,
                         string direccion, MetodoPago metodoPago)
            : base(id, nombre, correo, telefono)
        {
            Direccion = direccion;
            MetodoPago = metodoPago;
            FechaRegistro = DateTime.Today;
        }

        public override string Rol => "Comprador";
    }
}
