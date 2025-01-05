using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datVehiculos
    {
        #region sigleton
        private static readonly datVehiculos _instancia = new datVehiculos();
        public static datVehiculos Instancia
        {
            get
            {
                return datVehiculos._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entVehiculos> ListarVehiculos()
        {
            SqlCommand cmd = null;
            List<entVehiculos> lista = new List<entVehiculos>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVehiculos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVehiculos v = new entVehiculos();
                    v.VehiculoID = Convert.ToInt32(dr["VehiculoID"]);
                    v.TipoVehiculo = Convert.ToString(dr["TipoVehiculo"]);
                    v.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(v);
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
        public Boolean InsertarVehiculos(entVehiculos v)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVehiculos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoVehiculo", v.TipoVehiculo);
                cmd.Parameters.AddWithValue("@Estado", v.Estado);
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
        public Boolean ModificarVehiculos(entVehiculos v)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VehiculoID", v.VehiculoID);
                cmd.Parameters.AddWithValue("@TipoVehiculo", v.TipoVehiculo);
                cmd.Parameters.AddWithValue("@Estado", v.Estado);
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
        public Boolean DeshabilitaVehiculos(entVehiculos v)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarVehiculo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VehiculoID", v.VehiculoID);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
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
            return deshabilita;
        }
        #endregion metodos
    }
}
