using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz1._2.Models
{
    internal class Campo
    {
        /// <summary>
        /// Número de filas de la matriz.
        /// </summary>
        public int filas;

        /// <summary>
        /// Número de columnas de la matriz.
        /// </summary>
        public int columnas;

        /// <summary>
        /// Matriz que representa el campo de juego, donde cada celda puede contener un símbolo
        /// que representa el mar o diferentes tipos de barcos.
        /// </summary>
        public List<List<string>> Matriz { get; private set; }

        /// <summary>
        /// Lista que contiene los símbolos posibles para representar los elementos en la matriz:
        /// el mar ("_"), un bote pequeño ("🚤") y un bote grande ("🛥️").
        /// </summary>
        private List<string> nave;

        /// <summary>
        /// Constructor de la clase <see cref="Campo"/>. Inicializa el campo con las dimensiones
        /// dadas en términos de filas y columnas, y configura la lista de barcos.
        /// </summary>
        /// <param name="fila">El número de filas del campo de juego.</param>
        /// <param name="columna">El número de columnas del campo de juego.</param>
        public Campo(int fila, int columna)
        {
            // Inicializa el campo con el tamaño dado.
            this.filas = fila;
            this.columnas = columna;

            // Inicializa la matriz que representará el campo.
            this.Matriz = new List<List<string>>();

            // Lista de símbolos posibles para representar el mar y los barcos.
            this.nave = new List<string> { "_", "🚤", "🛥️" };
        }

        /// <summary>
        /// Genera el campo de juego llenando la matriz con símbolos aleatorios,
        /// donde cada celda representa el mar o un barco.
        /// </summary>
        public void GenerarCampo()
        {
            // Instancia un objeto de la clase Random para generar números aleatorios.
            Random rd = new Random();

            // Itera sobre las filas de la matriz.
            for (int i = 0; i < filas; i++)
            {
                // Crea una nueva fila para la matriz.
                List<string> fila = new List<string>();

                // Itera sobre las columnas de la matriz.
                for (int j = 0; j < columnas; j++)
                {
                    // Agrega un símbolo aleatorio a la fila.
                    fila.Add(nave[rd.Next(nave.Count)]);
                }

                // Agrega la fila completa a la matriz.
                Matriz.Add(fila);
            }

        }
    }
}
