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
    public class datHabitaciones
    {
        #region sigleton
        private static readonly datHabitaciones _instancia = new datHabitaciones();
        public static datHabitaciones Instancia
        {
            get
            {
                return datHabitaciones._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entHabitaciones> ListarHabitaciones()
        {
            SqlCommand cmd = null;
            List<entHabitaciones> lista = new List<entHabitaciones>();
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarHabitaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitaciones v = new entHabitaciones();
                    v.HabitacionesID = Convert.ToInt32(dr["HabitacionesID"]);
                    v.NumHabitacion = Convert.ToString(dr["NumHabitacion"]);
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

        public Boolean InsertarHabitaciones(entHabitaciones h)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarHabitaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumHabitacion", h.NumHabitacion);
                cmd.Parameters.AddWithValue("@Estado", h.Estado);
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

        public Boolean ModificarHabitaciones(entHabitaciones h)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarHabitaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HabitacionesID", h.HabitacionesID);
                cmd.Parameters.AddWithValue("@NumHabitacion", h.NumHabitacion);
                cmd.Parameters.AddWithValue("@Estado", h.Estado);
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

        public Boolean DeshabilitaHabitaciones(entHabitaciones h)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection con = datConexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarHabitaciones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HabitacionesID", h.HabitacionesID);
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
