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
        public void CualquierMetodo() 
        {
            if (entUsuario.Position == entPosiciones.Administrador) 
            {
                //code
            }
            if (entUsuario.Position == entPosiciones.Recepcionista) 
            {
                //code
            }
        }
    }
}
