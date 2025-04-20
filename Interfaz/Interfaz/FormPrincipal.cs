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

namespace Interfaz
{
    
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }
        


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;

        private void panelFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);  
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Crear_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Crear_cuenta>();
            Crear.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Iniciar_sesion>();
            Iniciar.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void juego_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Juego>();
            Iniciar.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Abrir formulario dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms );
            }
            
            else {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender,FormClosedEventArgs e) {
            if (Application.OpenForms["Crear_cuenta"] == null)
                Crear.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Iniciar_sesion"] == null)
                Iniciar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Juego"] == null)
                Juego.BackColor = Color.FromArgb(4, 41, 68);
        }
        
    }     
}
    