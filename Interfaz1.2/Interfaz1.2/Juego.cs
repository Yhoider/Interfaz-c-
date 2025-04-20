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

namespace Interfaz1._2
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

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
        // Restaura la pestaña al tamaño por defecto
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        // Logica para el desplazamiento de la pestaña en el escritorio
        private void Juego_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Oculta el texto predefinido
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "Coordenadas X")
            {
                intcoordeX.Text = "";
                intcoordeX.ForeColor = Color.LightGray;

            }
        }

        // Si se seleciona la casilla y se deja vacia pone de nuevo el texto predefinido
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "")
            {
                intcoordeX.Text = "Coordenadas X";
                intcoordeX.ForeColor = Color.DimGray;
            }
        }
        // Oculta el texto predefinido
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtcoordeY.Text == "Coordenadas Y")
            {
                txtcoordeY.Text = "";
                txtcoordeY.ForeColor = Color.LightGray;

            }
        }
        // Si se seleciona la casilla y se deja vacia pone de nuevo el texto predefinido
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "")
            {
                intcoordeX.Text = "Coordenadas Y";
                intcoordeX.ForeColor = Color.DimGray;
            }
        }
    }
}
