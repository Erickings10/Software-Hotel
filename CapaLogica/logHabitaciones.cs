using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logHabitaciones
    {
        #region sigleton
        private static readonly logHabitaciones _instancia = new logHabitaciones();
        public static logHabitaciones Instancia
        {
            get
            {
                return logHabitaciones._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entHabitaciones> ListarHabitaciones()
        {
            return datHabitaciones.Instancia.ListarHabitaciones();

        }
        public void InsertaHabitaciones(entHabitaciones h)
        {
            datHabitaciones.Instancia.InsertarHabitaciones(h);
        }

        public void ModificarHabitaciones(entHabitaciones h)
        {
            datHabitaciones.Instancia.ModificarHabitaciones(h);
        }

        public void DeshabilitarHabitaciones(entHabitaciones h)
        {
            datHabitaciones.Instancia.DeshabilitaHabitaciones(h);
        }

        #endregion metodos
    }
}
