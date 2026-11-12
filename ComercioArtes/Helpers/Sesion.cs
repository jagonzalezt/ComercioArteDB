namespace ComercioArtes.Helpers
{
    // Guarda los datos del usuario que inicio sesion.
    // Se usa para mostrar solo las pantallas que le corresponden a su rol.
    internal static class Sesion
    {
        // Numeros de los roles (tabla Roles de la base de datos)
        public const int Administrador = 1;
        public const int Artista = 2;
        public const int Comprador = 3;

        public static int UsuarioID;
        public static int RolID;
        public static string Nombre = "";

        public static string NombreRol()
        {
            if (RolID == Administrador) return "Administrador";
            if (RolID == Artista) return "Artista";
            if (RolID == Comprador) return "Comprador";
            return "Sin rol";
        }

        // Dice si el usuario puede entrar a un modulo.
        // Modulos: Dashboard, Artistas, Obras, Galerias, Compradores, Transacciones, Estructuras, Reportes (Estructuras y Reportes solo el Administrador)
        public static bool PuedeVer(string modulo)
        {
            // Todos los usuarios pueden ver el Dashboard
            if (modulo == "Dashboard")
                return true;

            // El administrador ve todo
            if (RolID == Administrador)
                return true;

            // El artista maneja sus obras y las galerias
            if (RolID == Artista)
                return modulo == "Obras" || modulo == "Galerias";

            // El comprador solo ve las transacciones
            if (RolID == Comprador)
                return modulo == "Transacciones";

            return false;
        }
    }
}
