using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
                        //while (reader.Read())
                        //{
                        //    UserCache.IdUser = reader.GetInt32(0);
                        //    UserCache.LoginName = reader.GetString(1);
                        //    UserCache.Password = reader.GetString(2);
                        //    UserCache.FirstName = reader.GetString(3);
                        //    UserCache.LastName = reader.GetString(4);
                        //    UserCache.Position = reader.GetString(5);
                        //    UserCache.Email = reader.GetString(6);
                        //}
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
