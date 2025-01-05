using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logVehiculo
    {
        #region sigleton
        private static readonly logVehiculo _instancia = new logVehiculo();
        public static logVehiculo Instancia
        {
            get
            {
                return logVehiculo._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entVehiculos> ListarVehiculos()
        {
            return datVehiculos.Instancia.ListarVehiculos();

        }
        public void InsertaVehiculos(entVehiculos v)
        {
            datVehiculos.Instancia.InsertarVehiculos(v);
        }

        public void ModificarVehiculos(entVehiculos v)
        {
            datVehiculos.Instancia.ModificarVehiculos(v);
        }

        public void DeshabilitarVehiculos(entVehiculos v)
        {
            datVehiculos.Instancia.DeshabilitaVehiculos(v);
        }

        #endregion metodos
    }
}
