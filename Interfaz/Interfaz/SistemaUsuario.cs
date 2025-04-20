using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class SistemaUsuarios
{
    private Dictionary<string, Jugador> usuarios;

    public SistemaUsuarios()
    {
        usuarios = new Dictionary<string, Jugador>();
    }

    public void CrearCuenta(string user, string password)
    {
        if (usuarios.ContainsKey(user))
        {
            MessageBox.Show("El usuario ya existe.");
        }
        else
        {
            usuarios[user] = new Jugador(user, password);
            MessageBox.Show("Cuenta creada exitosamente.");
        }
    }

    public Jugador IniciarSesion(string user, string password)
    {
        if (usuarios.TryGetValue(user, out Jugador usuario) && usuario.Password == password)
        {
            MessageBox.Show($"Ingreso exitoso. Bienvenido, {user}.");
            return usuario;
        }
        else
        {
            MessageBox.Show("Credenciales incorrectas.");
            return null;
        }
    }

    public void CambiarPassword(string user, string nuevaPassword)
    {
        if (usuarios.TryGetValue(user, out Jugador usuario))
        {
            usuario.Password = nuevaPassword;
            MessageBox.Show("Contraseña cambiada exitosamente.");
        }
        else
        {
            MessageBox.Show("Usuario no encontrado.");
        }
    }
}

