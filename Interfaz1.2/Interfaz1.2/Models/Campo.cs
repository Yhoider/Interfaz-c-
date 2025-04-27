using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1._2.Models
{
    internal class Campo
    {
        public int filas;
        public int columnas;
        public List<List<string>> Matriz { get; private set; }  

        private List<string> nave;

        public Campo(int fila, int columna)
        {
            // Inicializa el campo con el tamaño dado.
            this.filas = fila;
            this.columnas = columna;
            this.Matriz = new List<List<string>>();
            this.nave = new List<string> { "_", "🚤", "🛥️" };
        }

        public void GenerarCampo()
        {
            // Llena la matriz con símbolos aleatorios representando el mar y barcos.
            Random rd = new Random();
            for (int i = 0; i < filas; i++)
            {
                List<string> fila = new List<string>();
                for (int j = 0; j < columnas; j++)
                {
                    fila.Add(nave[rd.Next(nave.Count)]);
                }
                Matriz.Add(fila);
            }
        }

    }
}
