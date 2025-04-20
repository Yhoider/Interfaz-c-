using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jugador
{
    public string User { get; }
    public string Password { get; set; }

    public Jugador(string user, string password)
    {
        User = user;
        Password = password;
    }
}

