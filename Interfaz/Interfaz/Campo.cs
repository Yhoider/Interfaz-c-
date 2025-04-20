using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Campo
{
    public int Filas { get; }
    public int Columnas { get; }
    public List<List<string>> Matriz { get; }
    private readonly string[] nave = { "_", "🚤", "🛥️" };

    public Campo(int filas, int columnas)
    {
        Filas = filas;
        Columnas = columnas;
        Matriz = new List<List<string>>();
    }

    public List<List<string>> GenerarCampo()
    {
        Random rd = new Random();
        for (int i = 0; i < Filas; i++)
        {
            List<string> fila = new List<string>();
            for (int j = 0; j < Columnas; j++)
            {
                fila.Add(nave[rd.Next(nave.Length)]);
            }
            Matriz.Add(fila);
        }
        return Matriz;
    }
}
