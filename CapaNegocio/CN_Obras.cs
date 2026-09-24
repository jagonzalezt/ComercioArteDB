using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Obras
    {
        private CD_Obras objetoCapaDatos = new CD_Obras();

        /// <summary>
        /// Obtiene el listado completo de obras activas desde la base de datos.
        /// </summary>
        public DataTable ObtenerObras()
        {
            return objetoCapaDatos.ListarObras();
        }

        /// <summary>
        /// Valida los datos y envía la petición de inserción a la Capa de Datos.
        /// </summary>
        public bool GuardarObra(int artistaID, string titulo, string descripcion, decimal precio, int stock, string imagenURL, string tecnica, string anio, string dimensiones, string estado)
        {
            // Validaciones de lógica de negocio
            if (artistaID <= 0)
                throw new Exception("Debe seleccionar un artista válido.");

            if (string.IsNullOrWhiteSpace(titulo))
                throw new Exception("El título de la obra es obligatorio.");

            if (precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (string.IsNullOrWhiteSpace(tecnica))
                throw new Exception("La técnica de la obra es obligatoria.");

            // Pasamos los parámetros respetando la firma exacta de CD_Obras
            return objetoCapaDatos.InsertarObra(artistaID, titulo, descripcion, precio, stock, imagenURL, tecnica, anio, dimensiones, estado);
        }

        /// <summary>
        /// Valida los datos y envía la petición de actualización a la Capa de Datos.
        /// </summary>
        public bool ActualizarObra(int obraID, int artistaID, string titulo, string descripcion, decimal precio, int stock, string imagenURL, string tecnica, string anio, string dimensiones, string estado)
        {
            // Validaciones de seguridad e integridad
            if (obraID <= 0)
                throw new Exception("ID de obra no válido.");

            if (artistaID <= 0)
                throw new Exception("Debe seleccionar un artista válido.");

            if (string.IsNullOrWhiteSpace(titulo))
                throw new Exception("El título de la obra es obligatorio.");

            if (precio <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (string.IsNullOrWhiteSpace(tecnica))
                throw new Exception("La técnica de la obra es obligatoria.");

            // Pasamos los parámetros incluyendo el ObraID hacia CD_Obras
            return objetoCapaDatos.EditarObra(obraID, artistaID, titulo, descripcion, precio, stock, imagenURL, tecnica, anio, dimensiones, estado);
        }

        /// <summary>
        /// Realiza la baja lógica de una obra mediante su ID.
        /// </summary>
        public bool EliminarObra(int obraID)
        {
            if (obraID <= 0)
                throw new Exception("ID de obra no válido.");

            return objetoCapaDatos.EliminarObra(obraID);
        }
    }
}