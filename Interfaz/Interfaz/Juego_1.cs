using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Juego
{
    public int Fila { get; }
    public int Columna { get; }
    public int Puntaje { get; private set; }
    public string User { get; }
    public Campo Campo { get; }

    public Juego(int fila, int columna, string user)
    {
        Fila = fila;
        Columna = columna;
        Puntaje = 0;
        User = user;
        Campo = new Campo(Fila, Columna);
    }

    public void IniciarJuego()
    {
        Campo.GenerarCampo();
        MessageBox.Show("Campo generado.");
    }

    public void Disparar(int fila, int columna)
    {
        if (fila >= 0 && fila < Fila && columna >= 0 && columna < Columna)
        {
            if (Campo.Matriz[fila][columna] == "🚤" || Campo.Matriz[fila][columna] == "🛥️")
            {
                Campo.Matriz[fila][columna] = "_";
                Puntaje++;
            }
            else
            {
                MessageBox.Show("Fallaste. Intenta de nuevo.");
            }
        }
        else
        {
            MessageBox.Show("Coordenadas fuera del campo.");
        }

        if (Campo.Matriz.TrueForAll(row => !row.Contains("🚤") && !row.Contains("🛥️")))
        {
            MessageBox.Show("¡Todos los barcos han sido hundidos! Fin del juego.");
        }
    }
}
