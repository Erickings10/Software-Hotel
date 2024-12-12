using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class SistemaSoporteEmail : MasterMailServer
    {
        public SistemaSoporteEmail()
        {
            senderMail = "usuarioexample787@gmail.com";
            password = "dgctvbd123789456";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
