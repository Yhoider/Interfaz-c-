using System;
using System.Collections.Generic;

namespace Interfaz1._2.Models
{
    /// <summary>
    /// Representa el sistema de gestión de usuarios, que permite crear cuentas, iniciar sesión
    /// y cambiar contraseñas para los jugadores.
    /// </summary>
    internal static class SistemaUsuarios
    {
        /// <summary>
        /// Diccionario que almacena los usuarios registrados en el sistema, donde la clave es el
        /// nombre de usuario y el valor es el objeto <see cref="Jugador"/> correspondiente.
        /// </summary>
        private static Dictionary<string, Jugador> usuarios = new Dictionary<string, Jugador>();

        /// <summary>
        /// Crea una nueva cuenta de usuario si el nombre de usuario no existe en el sistema.
        /// </summary>
        /// <param name="user">El nombre de usuario para la nueva cuenta.</param>
        /// <param name="password">La contraseña asociada al nuevo usuario.</param>
        /// <returns>Devuelve <c>true</c> si la cuenta fue creada exitosamente, o <c>false</c> si el usuario ya existe.</returns>
        public static bool CrearCuenta(string user, string password)
        {
            // Verifica si el usuario ya existe en el sistema.
            if (usuarios.ContainsKey(user))
            {
                return false; // Usuario ya existe
            }
            else
            {
                // Crea un nuevo jugador con las credenciales proporcionadas.
                usuarios[user] = new Jugador(user, password);
                return true; // Cuenta creada exitosamente
            }
        }

        /// <summary>
        /// Inicia sesión verificando el nombre de usuario y la contraseña.
        /// </summary>
        /// <param name="user">El nombre de usuario del jugador.</param>
        /// <param name="password">La contraseña proporcionada para iniciar sesión.</param>
        /// <returns>Devuelve el objeto <see cref="Jugador"/> si las credenciales son correctas, o <c>null</c> si son incorrectas.</returns>
        public static Jugador IniciarSesion(string user, string password)
        {
            // Verifica si el usuario existe y si la contraseña es correcta.
            if (usuarios.TryGetValue(user, out Jugador usuario) && usuario.Password == password)
            {
                return usuario; // Inicio de sesión exitoso
            }
            else
            {
                return null; // Credenciales incorrectas
            }
        }

        /// <summary>
        /// Cambia la contraseña del usuario especificado.
        /// </summary>
        /// <param name="user">El nombre de usuario del jugador cuya contraseña se desea cambiar.</param>
        /// <param name="nuevaPassword">La nueva contraseña que se asignará al usuario.</param>
        /// <returns>Devuelve <c>true</c> si la contraseña se cambió exitosamente, o <c>false</c> si el usuario no fue encontrado.</returns>
        public static bool CambiarPassword(string user, string nuevaPassword)
        {
            // Verifica si el usuario existe en el sistema.
            if (usuarios.TryGetValue(user, out Jugador usuario))
            {
                // Cambia la contraseña del usuario.
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

