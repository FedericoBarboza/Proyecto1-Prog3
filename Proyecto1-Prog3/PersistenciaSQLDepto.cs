using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto1_Prog3
{
    public class PersistenciaSQLDepto : PersistenciaDepartamento
    {
        private SqlConnection crearConexion()
        {
            SqlConnection conexion = new SqlConnection("Server=localhost; Database=practico1; Integrated Security=SSPI;");
            conexion.Open();
            return conexion;
        }
        public Departamento buscar(int id)
        {
            SqlConnection conexion = crearConexion();
            SqlCommand comando = new SqlCommand("select cod_depto,nombre_depto from departamento where cod_depto=" + id, conexion);
            SqlDataReader reader;
            Departamento depto = null;

            reader = comando.ExecuteReader();

            if (reader.Read())
            {  //avanzamos al primer registro y comprobamos si hay datos
                depto = new Departamento();
                depto.Codigo = id;
                depto.Nombre = reader.GetString(reader.GetOrdinal("nombre_depto"));
            }

            return depto;
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Departamento depto)
        {
            throw new NotImplementedException();
        }

        public List<Departamento> lista()
        {
            List<Departamento> lista = new List<Departamento>();
            Departamento departamento = null;
            SqlConnection conexion = crearConexion();
            SqlCommand sentencia = new SqlCommand("select * from DEPARTAMENTO", crearConexion());
            SqlDataReader reader = sentencia.ExecuteReader();

            while (reader.Read())
            {
                departamento=new Departamento();
                departamento.Codigo = (int)reader["Cod_Depto"];
                departamento.Nombre = reader["Nombre"].ToString();

                lista.Add(departamento);
            }
            return lista;
        }
    }
}