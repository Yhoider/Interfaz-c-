using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jugador
{
    /// <summary>
    /// Representa a un jugador del sistema.
    /// </summary>

    public string User { get; set; }
    public string Password { get; set; }

    public Jugador(string user, string password)
    {
        this.User = user;
        this.Password = password;
    }
}
