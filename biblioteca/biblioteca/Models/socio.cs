using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace biblioteca.Models
{
    public class socio
    {
        capaconexion objcapaconexion = new capaconexion();
        public int idsocio { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int fiable { get; set; }
        public static DataTable tblsocio { get; set; }

        public DataSet consultasocio(int id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection("Data Source=proyectop5.database.windows.net;Initial Catalog=biblioteca;Persist Security Info=True;User ID=ccqp5;Password=Zaq12wsx");
                con.Open();
                SqlCommand sql = new SqlCommand(" Select * from socios where idsocio = @idsocio ", con);
                sql.Parameters.Add("@idsocio", SqlDbType.Int).Value = id;
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Error en la consulta");
            }
        }

        //public DataTable consultasocio(int id)
        //{
        //    StringBuilder sqlQuery = new StringBuilder();
        //    SqlCommand comando = new SqlCommand();
        //    DataTable tablasocio = new DataTable();
        //    try
        //    {
        //        sqlQuery.Append(" Select * from socios where idsocio = @idsocio ");
        //        if (id > 0)
        //        {
        //            comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = id;
        //            tablasocio = objcapaconexion.EjecutarConsulta(sqlQuery, comando);
        //        }
        //        return tablasocio;
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Error en la consulta");
        //    }
        //}

        public void insertarsocio(string nombre, string direccion, int fiable)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            try
            {
                sqlQuery.Append(" insert into socios values(@nombre, @direccion, @fiable) ");
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                comando.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
                comando.Parameters.Add("@fiable", SqlDbType.Int).Value = fiable;
                objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {

                throw new Exception("Error al insertar socio");
            }
        }

        public void borrarsocio(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            try
            {
                sqlQuery.Append(" delete from socios where idsocio = @idsocio ");
                comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = id;
                objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {

                throw new Exception("Error al borrar socio");
            }
        }

        public void updatesocio(int id, string nombre, string direccion, int fiable)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            try
            {
                sqlQuery.Append(" update socios set nombre=@nombre, direccion=@direccion, fiable=@fiable where idsocio=@idsocio ");
                comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = idsocio;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                comando.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
                comando.Parameters.Add("@fiable", SqlDbType.Int).Value = fiable;
                objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {

                throw new Exception("Error al actualizar socio");
            }
        }
    }
}