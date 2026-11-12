using Microsoft.EntityFrameworkCore;

namespace ApiComercioArtes.Data
{
    public class DbcontexSistema : DbContext
    {
        public DbcontexSistema(DbContextOptions<DbcontexSistema> options) : base(options)
        {
        }

        // Define aquí los DbSet que corresponden a tus tablas principales
        // (Asegúrate de tener tus clases Model creadas o puedes usar consultas directas)
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ObraArteModel> ObrasArte { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
    }

    // Modelos temporales o de mapeo para las entidades de la BD
    [Microsoft.EntityFrameworkCore.Keyless] // O puedes definir su [Key] según tu base de datos
    public class UsuarioModel
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int RolID { get; set; }
    }

    public class ObraArteModel
    {
        public int ObraID { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
        public bool Activo { get; set; }
    }

    public class PedidoModel
    {
        public int PedidoID { get; set; }
        public DateTime FechaPedido { get; set; }
        public decimal Total { get; set; }
    }
}