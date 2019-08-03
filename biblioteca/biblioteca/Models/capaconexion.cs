using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace biblioteca.Models
{
    public class capaconexion
    {
        static string cadenaconexion = "Data Source=proyectop5.database.windows.net;Initial Catalog=biblioteca;Persist Security Info=True;User ID=ccqp5;Password=Zaq12wsx";
        static SqlConnection conexion = new SqlConnection(cadenaconexion);
        public DataTable EjecutarConsulta(StringBuilder query, SqlCommand comando = null)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                if (comando == null)
                {
                    comando = new SqlCommand();
                }

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = query.ToString();
                SqlDataReader lector = comando.ExecuteReader();
                tabla.Load(lector);
                conexion.Close();

                return tabla;
            }
            catch (Exception ex)
            {
                conexion.Close();
                throw new Exception("Error en Capa de Conexion" + ex.Message);
            }
        }

        public int Insertar(StringBuilder query, SqlCommand comando)
        {
            int resultado = 0;
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = query.ToString();
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                conexion.Close();
                throw new Exception("Error en Capa de Conexion" + ex.Message);
            }
        }
    }
}
}