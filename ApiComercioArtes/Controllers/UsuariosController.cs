using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ApiComercioArtes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsuariosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var listaUsuarios = new List<Dictionary<string, object>>();
            string conexionString = _configuration.GetConnectionString("ConexionSQL");

            try
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    string query = "SELECT UsuarioID, Nombre, Apellido, Telefono, RolID FROM Usuarios";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var fila = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string nombreColumna = reader.GetName(i);
                                    object valor = reader.GetValue(i);
                                    fila[nombreColumna] = valor == DBNull.Value ? null : valor;
                                }
                                listaUsuarios.Add(fila);
                            }
                        }
                    }
                }
                return Ok(listaUsuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}