using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Clases
{
    public class Partida
    {
        private string iJugador;
        private DateTime iHoraFechaInicio, iHoraFechaFin;
        private TimeSpan iDuracion;
        private Boolean iGanador;
        //iDuracion.Minutes = (iHoraFechaFin - iHoraFechaInicio).Minutes;
        //iDuracion.Seconds = (iHoraFechaFin - iHoraFechaInicio).Seconds;

        public Partida(string pJugador, DateTime pHoraFechaInicio)
        {
            this.iJugador = pJugador;
            this.iHoraFechaInicio = pHoraFechaInicio;
        }

        public string Jugador
        {
            get { return this.iJugador; }
            set { this.iJugador = value; }
        }

        public DateTime HoraFechaInicio
        {
            get { return this.iHoraFechaInicio; }
            set { this.iHoraFechaInicio = value; }
        }

        public DateTime HoraFechaFin
        {
            get { return this.iHoraFechaFin; }
            set { this.iHoraFechaFin = value; }
        }

        public TimeSpan Duracion
        {
            get { return this.iDuracion; }
            set { this.iDuracion = value; }
        }

        public Boolean Ganador
        {
            get { return this.iGanador; }
            set { this.iGanador = value; }
        }
    }
}
