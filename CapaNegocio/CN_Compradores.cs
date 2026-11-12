using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Compradores
    {
        private CD_Compradores objetoCapaDatos = new CD_Compradores();

        public DataTable ObtenerCompradores()
        {
            return objetoCapaDatos.ListarCompradores();
        }

        public bool GuardarComprador(string nombre, string correo, string telefono, string direccion, string metodoPago)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(correo)) throw new Exception("El correo electrónico es obligatorio.");
            if (string.IsNullOrWhiteSpace(metodoPago)) throw new Exception("El método de pago es obligatorio.");

            return objetoCapaDatos.InsertarComprador(nombre, correo, telefono, direccion, metodoPago);
        }

        public bool ActualizarComprador(int compradorID, string nombre, string correo, string telefono, string direccion, string metodoPago)
        {
            if (compradorID <= 0) throw new Exception("ID de comprador no válido.");
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(correo)) throw new Exception("El correo electrónico es obligatorio.");
            if (string.IsNullOrWhiteSpace(metodoPago)) throw new Exception("El método de pago es obligatorio.");

            return objetoCapaDatos.EditarComprador(compradorID, nombre, correo, telefono, direccion, metodoPago);
        }

        public bool EliminarComprador(int compradorID)
        {
            if (compradorID <= 0) throw new Exception("ID de comprador no válido.");
            return objetoCapaDatos.EliminarComprador(compradorID);
        }
    }
}