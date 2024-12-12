using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datUsuario : datConexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spValidarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            entUsuario.IdUser = reader.GetInt32(0);
                            entUsuario.FirstName = reader.GetString(3);
                            entUsuario.LastName = reader.GetString(4);
                            entUsuario.Position = reader.GetString(5);
                            entUsuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new SistemaSoporteEmail(); 
                        mailService.sendMail(
                          subject: "SYSTEM: Solicitud de recuperación de contraseña",
                          body: "Hola, " + userName + "\nHa solicitado recuperar su contraseña.\n" +
                          "su contraseña actual es: " + accountPassword +
                          "\nNo obstante, le pedimos que cambie su contraseña después de entrar en el sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nHas solicitado recuperar tu contraseña\n" +
                          "Por favor, compruebe su correo: " + userMail +
                          "\nNo obstante, le rogamos que cambie su contraseña inmediatamente después de entrar en el sistema.";
                    }
                    else
                        return "Lo sentimos, usted no tiene una cuenta con ese correo o nombre de usuario.";
                }
            }
        }
    }
}
