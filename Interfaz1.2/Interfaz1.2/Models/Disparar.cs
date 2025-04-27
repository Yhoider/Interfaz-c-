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
        private Campo campo;
        private int puntaje;

        public Disparar(Campo campo)
        {
            this.campo = campo;
            this.puntaje = 0;
        }

        public int Puntaje
        {
            get { return puntaje; }
        }

        public bool RealizarDisparo(int fila, int columna)
        {
            // Verificar si las coordenadas están dentro del campo
            if (fila >= 0 && fila < campo.filas && columna >= 0 && columna < campo.columnas)
            {
                // Si es un barco, hundirlo y aumentar el puntaje
                if (campo.Matriz[fila][columna] == "🚤" || campo.Matriz[fila][columna] == "🛥️")
                {
                    campo.Matriz[fila][columna] = "_";  // Hundir el barco
                    puntaje++;
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
