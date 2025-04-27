using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz1._2.Models;

namespace Interfaz1._2
{
    internal class Disparar
    {
        /// <summary>
        /// Referencia al campo de juego en el que se realizarán los disparos.
        /// </summary>
        private Campo campo;

        /// <summary>
        /// Puntaje del jugador, que aumenta cada vez que se hunde un barco.
        /// </summary>
        private int puntaje;

        /// <summary>
        /// Constructor de la clase <see cref="Disparar"/>. Inicializa el campo de juego y establece el puntaje en 0.
        /// </summary>
        /// <param name="campo">El campo de juego en el que se realizarán los disparos.</param>
        public Disparar(Campo campo)
        {
            // Inicializa la referencia al campo y el puntaje.
            this.campo = campo;
            this.puntaje = 0;
        }

        /// <summary>
        /// Obtiene el puntaje actual del jugador.
        /// </summary>
        public int Puntaje
        {
            get { return puntaje; }
        }

        /// <summary>
        /// Realiza un disparo en las coordenadas dadas.
        /// </summary>
        /// <param name="fila">La fila del campo en la que se realizará el disparo.</param>
        /// <param name="columna">La columna del campo en la que se realizará el disparo.</param>
        /// <returns>Devuelve <c>true</c> si el disparo fue exitoso (se hundió un barco), o <c>false</c> en caso contrario.</returns>
        public bool RealizarDisparo(int fila, int columna)
        {
            // Verificar si las coordenadas están dentro del campo
            if (fila >= 0 && fila < campo.filas && columna >= 0 && columna < campo.columnas)
            {
                // Si es un barco, hundirlo y aumentar el puntaje
                if (campo.Matriz[fila][columna] == "🚤" || campo.Matriz[fila][columna] == "🛥️")
                {
                    campo.Matriz[fila][columna] = "_";  // Hundir el barco
                    puntaje++;  // Aumentar el puntaje
                    System.Media.SystemSounds.Beep.Play();  // Sonido de impacto
                    return true;
                }
                else
                {
                    return false;  // Fallaste el disparo
                }
            }
            else
            {
                return false;  // Coordenadas fuera del campo
            }
        }

        /// <summary>
        /// Verifica si aún quedan barcos en el campo de juego.
        /// </summary>
        /// <returns>Devuelve <c>true</c> si hay barcos restantes en el campo, o <c>false</c> si no quedan barcos.</returns>
        public bool QuedanBarcos()
        {
            // Verificar si quedan barcos en el campo
            foreach (var fila in campo.Matriz)
            {
                if (fila.Contains("🚤") || fila.Contains("🛥️"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
