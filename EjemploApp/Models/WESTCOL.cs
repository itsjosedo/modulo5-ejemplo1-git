// Ruta sugerida: Models/Resultados.cs

namespace TuProyecto.Models
{
    public class WESTCOL
    {
        // Propiedades de ejemplo
        public int Id { get; set; }
        public string NombreParticipante { get; set; }
        public double Puntaje { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor opcional
        public WESTCOL(int id, string nombre, double puntaje, DateTime fecha)
        {
            Id = id;
            NombreParticipante = nombre;
            Puntaje = puntaje;
            Fecha = fecha;
        }

        // Método para mostrar los resultados como cadena
        public string MostrarResultado()
        {
            return $"[{Fecha.ToShortDateString()}] {NombreParticipante} obtuvo {Puntaje} puntos.";
        }
    }
}
