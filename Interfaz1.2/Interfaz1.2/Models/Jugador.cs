using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jugador
{
    /// <summary>
    /// Nombre de usuario del jugador.
    /// </summary>
    public string User { get; set; }

    /// <summary>
    /// Contraseña del jugador.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Constructor de la clase <see cref="Jugador"/>. Inicializa un nuevo jugador con el nombre de usuario
    /// y la contraseña proporcionados.
    /// </summary>
    /// <param name="user">El nombre de usuario del jugador.</param>
    /// <param name="password">La contraseña del jugador.</param>
    public Jugador(string user, string password)
    {
        // Inicializa las propiedades User y Password con los valores proporcionados.
        this.User = user;
        this.Password = password;
    }


}
