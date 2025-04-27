using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz1._2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using static Interfaz.Crear_cuenta;

namespace Interfaz1._2
{
    public partial class Login : Form
    {
        // Constructor del formulario de login, que inicializa los componentes de la interfaz.
        public Login()
        {
            InitializeComponent(); // Inicializa los componentes del formulario, como botones, cuadros de texto, etc.
        }

        // Importación de funciones externas de la librería "user32.dll" para manipular la ventana del formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Método para cerrar el formulario y salir de la aplicación.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación y termina la ejecución.
        }

        // Variables para almacenar la posición y el tamaño de la ventana.
        int lx, ly;
        int sw, sh;

        // Método para restaurar la ventana al tamaño por defecto cuando se hace clic en el botón "Restaurar".
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true; // Muestra el botón de maximizar.
            btnRestaurar.Visible = false; // Oculta el botón de restaurar.
            this.Size = new Size(sw, sh); // Restaura el tamaño original de la ventana.
            this.Location = new Point(lx, ly); // Restaura la ubicación original de la ventana.
        }

        // Método para minimizar la ventana cuando se hace clic en el botón "Minimizar".
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizado.
        }

        // Método para maximizar la ventana al tamaño completo de la pantalla.
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X; // Guarda la ubicación actual de la ventana.
            ly = this.Location.Y;
            sw = this.Size.Width; // Guarda el tamaño actual de la ventana.
            sh = this.Size.Height;
            btnMaximizar.Visible = false; // Oculta el botón de maximizar.
            btnRestaurar.Visible = true;  // Muestra el botón de restaurar.
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Cambia el tamaño de la ventana al tamaño máximo de la pantalla.
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; // Coloca la ventana en la esquina superior izquierda de la pantalla.
        }

        // Método que oculta el texto predeterminado en el cuadro de texto "Usuario" cuando el usuario hace clic.
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario") // Verifica si el texto es el predeterminado.
            {
                txtuser.Text = ""; // Borra el texto predeterminado.
                txtuser.ForeColor = Color.LightGray; // Cambia el color del texto a gris claro.
            }
        }

        // Método que restaura el texto predeterminado en el cuadro de texto "Usuario" si el usuario deja el campo vacío.
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "") // Si el campo está vacío.
            {
                txtuser.Text = "Usuario"; // Restaura el texto predeterminado.
                txtuser.ForeColor = Color.DimGray; // Cambia el color del texto a gris oscuro.
            }
        }

        // Método que oculta el texto predeterminado en el cuadro de texto "Contraseña" y muestra los caracteres como contraseñas.
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Contraseña") // Verifica si el texto es el predeterminado.
            {
                txtpassword.Text = ""; // Borra el texto predeterminado.
                txtpassword.ForeColor = Color.LightGray; // Cambia el color del texto a gris claro.
                txtpassword.UseSystemPasswordChar = true; // Muestra los caracteres como contraseñas (con puntos).
            }
        }

        // Método que restaura el texto predeterminado en el cuadro de texto "Contraseña" si el usuario deja el campo vacío.
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "") // Si el campo está vacío.
            {
                txtpassword.Text = "Contraseña"; // Restaura el texto predeterminado.
                txtpassword.ForeColor = Color.DimGray; // Cambia el color del texto a gris oscuro.
                txtpassword.UseSystemPasswordChar = false; // Deja de mostrar los caracteres como contraseñas.
            }
        }

        // Método para permitir mover la ventana del formulario sin bordes, haciendo clic y arrastrando.
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Llama a las funciones de Windows para mover la ventana.
        }

        // Método que maneja el inicio de sesión cuando el usuario hace clic en el botón de login.
        private void button1_Click(object sender, EventArgs e)
        {
            // Intenta iniciar sesión con el nombre de usuario y la contraseña proporcionados.
            Jugador jugador = SistemaUsuarios.IniciarSesion(txtuser.Text, txtpassword.Text);

            if (jugador != null) // Si las credenciales son correctas.
            {
                MessageBox.Show($"Bienvenido, {jugador.User}"); // Muestra un mensaje de bienvenida con el nombre de usuario.

                // Abre el formulario de juego y oculta el formulario de login.
                Juego juegoForm = new Juego(); // Instancia el formulario Juego.
                juegoForm.Show(); // Muestra el formulario de juego.
                this.Hide(); // Oculta el formulario de login.
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas."); // Muestra un mensaje de error si las credenciales son incorrectas.
            }
        }

        // Método que maneja el clic en el enlace para cambiar la contraseña.
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form abrir_formulario = new ChangePassword(); // Instancia el formulario para cambiar la contraseña.
            abrir_formulario.Show(); // Muestra el formulario para cambiar la contraseña.
            this.Hide(); // Oculta el formulario de login.
        }

    }
}
