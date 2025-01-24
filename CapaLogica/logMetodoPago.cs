using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region sigleton
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();

        }
        public void InsertarMetodoPago(entMetodoPago m)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(m);
        }

        public void ModificarMetodoPago(entMetodoPago m)
        {
            datMetodoPago.Instancia.ModificarMetodoPago(m);
        }

        public void DeshabilitaMetodoPago(entMetodoPago m)
        {
            datMetodoPago.Instancia.DeshabilitaMetodoPago(m);
        }

        #endregion metodos
    }
}
