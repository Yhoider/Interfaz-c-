using System;
using System.Collections.Generic;

namespace Interfaz1._2
{
    internal static class SistemaUsuarios
    {
        private static Dictionary<string, Jugador> usuarios = new Dictionary<string, Jugador>();

        public static bool CrearCuenta(string user, string password)
        {
            if (usuarios.ContainsKey(user))
            {
                return false; // Usuario ya existe
            }
            else
            {
                usuarios[user] = new Jugador(user, password);
                return true; // Cuenta creada exitosamente
            }
        }

        public static Jugador IniciarSesion(string user, string password)
        {
            if (usuarios.TryGetValue(user, out Jugador usuario) && usuario.Password == password)
            {
                return usuario; // Inicio de sesión exitoso
            }
            else
            {
                return null; // Credenciales incorrectas
            }
        }

        public static bool CambiarPassword(string user, string nuevaPassword)
        {
            if (usuarios.TryGetValue(user, out Jugador usuario))
            {
                usuario.Password = nuevaPassword;
                return true; // Contraseña cambiada exitosamente
            }
            else
            {
                return false; // Usuario no encontrado
            }
        }
    }
}

