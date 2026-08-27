using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Jugador
    {
        // Campos
        private string nombre;
        private char simbolo;
        private ConsoleColor color;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public char Simbolo { get => simbolo; set => simbolo = value; }
        public ConsoleColor Color { get => color; set => color = value; }

        // Constructor que inicializa a un jugador con nombre, símbolo y color
        public Jugador(string nombre, char simbolo, ConsoleColor colorInicial)
        {
            Nombre = nombre;
            Simbolo = simbolo;
            Color = colorInicial;
        }

        // Métodos

        // Cambia el color del jugador. La validación del color la hace quien llama.
        public void CambiarColor(ConsoleColor nuevoColor)
        {
            Color = nuevoColor;
        }

        // Invalida a ToString para mostrar una cadena con la info del jugador
        public override string ToString()
        {
            return $"{Nombre} ({Simbolo})";
        }

    }
}
