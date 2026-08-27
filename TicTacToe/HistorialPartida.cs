using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    struct HistorialPartida
    {
        // Campos
        public string nombreGanador; // “Jugador 1”, “Jugador 2”, o “Empate”
        public int turnosJugados;
        public DateTime fechaHora;

        // Constructor que se encarga de inicializar los 3 campos con los parámetros recibidos desde la instancia
        public HistorialPartida(string nombreGanador, int turnosJugados)
        {
            this.nombreGanador = nombreGanador;
            this.turnosJugados = turnosJugados;
            fechaHora = DateTime.Now;
        }

        // Método que se encarga de convertir el estado actual de la partida (nombre, turnos y fecha) en texto con formato, invalidando el ToString
        public override string ToString()
        {
            return $"{fechaHora: dd - MM - yyyy HH: mm} | Ganador: {nombreGanador} | Turnos: {turnosJugados}";
        }
    }
}
