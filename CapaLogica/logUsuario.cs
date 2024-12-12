using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logUsuario
    {
        datUsuario userDao = new datUsuario();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }   
    }
}
