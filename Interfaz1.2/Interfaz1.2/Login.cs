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
using Microsoft.VisualBasic.ApplicationServices;
using static Interfaz.Crear_cuenta;

namespace Interfaz1._2
{
    public partial class Login : Form
    {
        // Inicializa el formulario
        public Login()
        {
            InitializeComponent();
        }
        // Importacion de packquetes desde una libreria ya existente
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        // Cierra el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        // Restaura la pestaña al tamaño por defecto
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        // Minimiza la pestalla
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Aumenta el tamaño del formulario al maximo de la pantalla 
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        // Oculta el texto predefinido
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;

            }
        }

        // Si se seleciona la casilla y se deja vacia pone de nuevo el texto predefinido
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }
        // Acultar el texto predefinido y oculta la contraseña
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }
        }
        // Si se seleciona la casilla y se deja vacia pone de nuevo el texto predefinido
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Contraseña";
                txtpassword.ForeColor = Color.DimGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        // Logica para el desplazamiento de la pestaña en el escritorio
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Jugador jugador = SistemaUsuarios.IniciarSesion(txtuser.Text, txtpassword.Text);

            if (jugador != null)
            {
                MessageBox.Show($"Bienvenido, {jugador.User}");

                // Abrir formulario de Juego
                Juego juegoForm = new Juego(); // Instancias el formulario Juego
                juegoForm.Show();              // Lo muestras
                this.Hide();                   // Ocultas el formulario actual (Login)
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form abrir_formulario = new ChangePassword();
            abrir_formulario.Show();
            this.Hide();
        }
    }
}
