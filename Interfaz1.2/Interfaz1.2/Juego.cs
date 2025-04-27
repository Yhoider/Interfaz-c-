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

namespace Interfaz1._2
{
    public partial class Juego : Form
    {
        private Campo campo; // Representa el campo de juego donde se disparan los proyectiles.
        private Disparar disparar; // Clase que gestiona los disparos y las interacciones con los barcos.

        // Constructor de la clase Juego que inicializa el formulario y las instancias de las clases Campo y Disparar.
        public Juego()
        {
            InitializeComponent();
            campo = new Campo(5, 5); // Inicializa el campo de juego con 5 filas y 5 columnas.
            campo.GenerarCampo(); // Genera el campo con la disposición de los barcos.
            disparar = new Disparar(campo); // Crea la instancia de la clase Disparar pasando el campo como parámetro.
        }

        // Declaración de métodos para manipulación de la ventana.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Método que cierra la aplicación cuando se hace clic en el botón de cerrar.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Termina la ejecución de la aplicación.
        }

        // Variables de posición y tamaño de la ventana para maximizarla y restaurarla.
        int lx, ly;
        int sw, sh;

        // Método que minimiza la ventana cuando se hace clic en el botón de minimizar.
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizado.
        }

        // Método que maximiza la ventana cuando se hace clic en el botón de maximizar.
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false; // Oculta el botón de maximizar.
            btnRestaurar.Visible = true; // Muestra el botón de restaurar.
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Establece el tamaño de la ventana al tamaño máximo de la pantalla.
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; // Coloca la ventana en la esquina superior izquierda de la pantalla.
        }

        // Método que restaura el tamaño de la ventana al tamaño predeterminado.
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true; // Muestra el botón de maximizar.
            btnRestaurar.Visible = false; // Oculta el botón de restaurar.
            this.Size = new Size(sw, sh); // Restaura el tamaño de la ventana.
            this.Location = new Point(lx, ly); // Restaura la ubicación de la ventana.
        }

        // Método que permite mover la ventana con el mouse (sin bordes de ventana).
        private void Juego_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Llama a los métodos de Windows para mover la ventana.
        }

        // Método para ocultar el texto de la casilla de texto cuando se selecciona (coordenada X).
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "Coordenadas X")
            {
                intcoordeX.Text = ""; // Borra el texto predeterminado.
                intcoordeX.ForeColor = Color.LightGray; // Cambia el color del texto a gris claro.
            }
        }

        // Método que restaura el texto predeterminado si se deja vacía la casilla de texto (coordenada X).
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "")
            {
                intcoordeX.Text = "Coordenadas X"; // Restaura el texto predeterminado.
                intcoordeX.ForeColor = Color.DimGray; // Cambia el color a gris oscuro.
            }
        }

        // Método para ocultar el texto de la casilla de texto cuando se selecciona (coordenada Y).
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (intcoordeY.Text == "Coordenadas Y")
            {
                intcoordeY.Text = ""; // Borra el texto predeterminado.
                intcoordeY.ForeColor = Color.LightGray; // Cambia el color del texto a gris claro.
            }
        }

        // Método que restaura el texto predeterminado si se deja vacía la casilla de texto (coordenada Y).
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (intcoordeX.Text == "")
            {
                intcoordeX.Text = "Coordenadas Y"; // Restaura el texto predeterminado.
                intcoordeX.ForeColor = Color.DimGray; // Cambia el color a gris oscuro.
            }
        }

        // Método que se ejecuta al hacer clic en el botón de disparar.
        private void btnDisparar_Click(object sender, EventArgs e)
        {
            // Obtiene las coordenadas de los cuadros de texto (X, Y) y las convierte a enteros.
            int x = Convert.ToInt32(intcoordeX.Text) - 1; // Restamos 1 para ajustarlas al índice de la matriz.
            int y = Convert.ToInt32(intcoordeY.Text) - 1;

            // Realiza el disparo utilizando la clase Disparar.
            bool acierto = disparar.RealizarDisparo(x, y);

            // Muestra el resultado del disparo.
            if (acierto)
            {
                MessageBox.Show("¡Impacto! Has hundido un barco.");
            }
            else
            {
                MessageBox.Show("Fallaste. Intenta de nuevo.");
            }

            // Verifica si ya no quedan barcos y muestra el mensaje correspondiente.
            if (!disparar.QuedanBarcos())
            {
                MessageBox.Show("¡Todos los barcos han sido hundidos! Fin del juego.");
                MostrarPuntaje(); // Muestra el puntaje al final del juego.
            }
            else
            {
                MostrarPuntaje(); // Muestra el puntaje después de cada disparo.
            }
        }

        // Método que muestra el puntaje del jugador en un mensaje.
        private void MostrarPuntaje()
        {
            string tabla = $"Puntaje: {disparar.Puntaje}"; // Formatea el puntaje.
            MessageBox.Show(tabla); // Muestra el puntaje en una ventana de mensaje.
        }
    }

}


