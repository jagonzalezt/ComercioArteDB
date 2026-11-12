namespace ComercioArtes.Models
{
    public enum TecnicaObra
    {
        Oleo, Acuarela, Escultura, Fotografia,
        Digital, Grabado, Dibujo, Mixta, Otro
    }

    public enum EstadoObra { Disponible, Reservada, Vendida }

    public enum MetodoPago
    {
        Efectivo, TarjetaCredito, TarjetaDebito,
        Transferencia, PayPal
    }

    public enum EstadoFactura { Emitida, Cancelada }
}
