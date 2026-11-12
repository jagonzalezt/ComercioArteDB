using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCapaDatos = new CD_Usuarios();

        public bool ValidarYRegistrar(int rolID, string nombre, string apellido, string email, string password, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                throw new Exception("El nombre y el apellido son obligatorios.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new Exception("Ingresa un correo electrónico válido.");

            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
                throw new Exception("La contraseña debe tener al menos 4 caracteres.");

            return objetoCapaDatos.RegistrarUsuario(rolID, nombre, apellido, email, password, telefono);
        }

        public DataTable LoguearUsuario(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new Exception("El correo y la contraseña no pueden estar vacíos.");

            return objetoCapaDatos.ValidarLogin(email, password);
        }
    }
}