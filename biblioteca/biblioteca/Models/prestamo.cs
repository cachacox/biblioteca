using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace biblioteca.Models
{
    public class prestamo
    {
        capaconexion objcapaconexion = new capaconexion();
        public int idlibro { get; set; }
        public int idsocio { get; set; }
        public DateTime fecha { get; set; }

        public DataTable consultaprestamo(int? id, int? idsocio)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            DataTable tablaprestamo = new DataTable();
            try
            {
                if (id == null && idsocio == null)
                {
                    sqlQuery.Append(" Select * from prestamos ");
                }
                else if (id != null && idsocio == null)
                {
                    sqlQuery.Append(" Select * from prestamos where idlibro = @idlibro ");
                    comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = id;
                }
                else if (id == null && idsocio != null)
                {
                    sqlQuery.Append(" Select * from prestamos where idsocio = @idsocio ");
                    comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = idsocio;
                }
                else if (id != null && idsocio != null)
                {
                    sqlQuery.Append(" Select * from prestamos where idlibro = @idlibro and idsocio = @idsocio ");
                    comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = id;
                    comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = idsocio;
                }
                    tablaprestamo = objcapaconexion.EjecutarConsulta(sqlQuery, comando);
                    return tablaprestamo;
            }
            catch (Exception)
            {
                throw new Exception("Error en la consulta");
            }
        }

        public void insertarprestamo(int id, int socio, DateTime fecha)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            try
            {
                sqlQuery.Append(" insert into prestamos values(@id, @socio, @fecha) ");
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Parameters.Add("@socio", SqlDbType.Int).Value = socio;
                comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {
                throw new Exception("Error al insertar prestamo");
            }
        }

        public void borrarprestamo(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            try
            {
                sqlQuery.Append(" delete from prestamos where idlibro = @idlibro ");
                comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = id;
                objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {

                throw new Exception("Error al borrar prestamo");
            }
        }
    }
}