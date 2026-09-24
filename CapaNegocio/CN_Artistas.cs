using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Artistas
    {
        private CD_Artistas objetoCapaDatos = new CD_Artistas();

        public DataTable ObtenerArtistas() => objetoCapaDatos.ListarArtistas();

        public bool Guardar(string nombre, string apellido, string email, string password, string telefono, string seudonimo, string biografia, string sitioWeb)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
                throw new Exception("El nombre y el correo electrónico son obligatorios.");
            return objetoCapaDatos.InsertarArtista(nombre, apellido, email, password, telefono, seudonimo, biografia, sitioWeb);
        }

        public bool Actualizar(int id, string nombre, string apellido, string email, string telefono, string seudonimo, string biografia, string sitioWeb)
        {
            if (id <= 0) throw new Exception("ID de artista no válido.");
            return objetoCapaDatos.EditarArtista(id, nombre, apellido, email, telefono, seudonimo, biografia, sitioWeb);
        }

        public bool Eliminar(int id)
        {
            if (objetoCapaDatos.TieneObras(id))
                throw new Exception("No se puede eliminar: el artista posee obras de arte asignadas en el catálogo.");
            return objetoCapaDatos.EliminarArtista(id);
        }
    }
}