using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUsers
    {
        #region sigleton
        private static readonly logUsers _instancia = new logUsers();
        public static logUsers Instancia
        {
            get
            {
                return logUsers._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entUsers> ListarUsuarios()
        {
            return datUsers.Instancia.ListarUsuarios();

        }
        public void InsertarUsuarios(entUsers u)
        {
            datUsers.Instancia.InsertarUsuarios(u);
        }

        public void ModificarUsuarios(entUsers u)
        {
            datUsers.Instancia.ModificarUsuarios(u);
        }

        public void EliminarUsuario(int usersID)
        {
            datUsers.Instancia.EliminarUsuario(usersID);
        }

        #endregion metodos
    }
}
