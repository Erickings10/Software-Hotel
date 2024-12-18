using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datUsers
    {
        #region sigleton
        private static readonly datUsers _instancia = new datUsers();
        public static datUsers Instancia
        {
            get
            {
                return datUsers._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entUsers> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entUsers> lista = new List<entUsers>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsers u = new entUsers();
                    u.UsersID = Convert.ToInt32(dr["UsersID"]);
                    u.LoginName = Convert.ToString(dr["LoginName"]);
                    u.Contraseña = Convert.ToString(dr["Contraseña"]);
                    u.Nombre = Convert.ToString(dr["Nombre"]);
                    u.Apellido = Convert.ToString(dr["Apellido"]);
                    u.Posicion = Convert.ToString(dr["Posicion"]);
                    u.Email = Convert.ToString(dr["Email"]);
                    lista.Add(u);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarUsuarios(entUsers u)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoginName", u.LoginName);
                cmd.Parameters.AddWithValue("@Contraseña", u.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", u.Apellido);
                cmd.Parameters.AddWithValue("@Posicion", u.Posicion);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean ModificarUsuarios(entUsers u)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsersID", u.UsersID);
                cmd.Parameters.AddWithValue("@LoginName", u.LoginName);
                cmd.Parameters.AddWithValue("@Contraseña", u.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", u.Apellido);
                cmd.Parameters.AddWithValue("@Posicion", u.Posicion);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean EliminarUsuario(int usersID)
        {
            SqlCommand cmd = null;
            Boolean eliminado = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsersID", usersID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return eliminado;
        }

        #endregion metodos
    }
}
