﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace biblioteca.Models
{
    public class libro
    {
        capaconexion objcapaconexion = new capaconexion();
        public int idlibro { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int disponible { get; set; }
        public string localizacion { get; set; }
        public string signatura { get; set; }

        public DataTable consultalibro(int id) {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            DataTable tablalibro = new DataTable();
            try
            {
                sqlQuery.Append(" Select * from libros where idlibro = @idlibro ");
                if (id > 0)
                {
                    comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = id;
                    tablalibro = objcapaconexion.EjecutarConsulta(sqlQuery, comando);
                }
                return tablalibro;
            }
            catch (Exception)
            {
                throw new Exception("Error en la consulta");
            }
        }

        public void insertarlibro(string titulo, string autor, int disp, string localizacion, string signatura) {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand comando = new SqlCommand();
            int resultado = 0;
            try
            {
                sqlQuery.Append(" insert into libros values(@titulo, @autor, @disp, @localizacion, @signatura) ");
                comando.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = titulo;
                comando.Parameters.Add("@autor", SqlDbType.NVarChar).Value = autor;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = disp;
                comando.Parameters.Add("@localizacion", SqlDbType.NVarChar).Value = localizacion;
                comando.Parameters.Add("@signatura", SqlDbType.NVarChar).Value = signatura;
                resultado = objcapaconexion.Insertar(sqlQuery, comando);
            }
            catch (Exception)
            {
                throw new Exception("Error al insertar libro");
            }
        }
    }
}