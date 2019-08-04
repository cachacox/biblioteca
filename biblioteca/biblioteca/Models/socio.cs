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

        public DataTable consultasocio(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            DataTable tablasocio = new DataTable();
            try
            {
                sqlQuery.Append(" Select * from socios where idsocio = @idsocio ");
                if (id > 0)
                {
                    comando.Parameters.Add("@idsocio", SqlDbType.Int).Value = id;
                    tablasocio = objcapaconexion.EjecutarConsulta(sqlQuery, comando);
                }
                return tablasocio;
            }
            catch (Exception)
            {
                throw new Exception("Error en la consulta");
            }
        }

        public void insertarsocio(string nombre, string direccion, int fiable)
        {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            int resultado = 0;
            try
            {
                sqlQuery.Append(" insert into socios values(@nombre, @direccion, @fiable) ");
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                comando.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
                comando.Parameters.Add("@fiable", SqlDbType.Int).Value = fiable;
                resultado = objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {

                throw new Exception("Error al insertar socio");
            }
        }
    }
}