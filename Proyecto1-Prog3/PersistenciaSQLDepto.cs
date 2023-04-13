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
            SqlConnection conexion = new SqlConnection("Server=LAPTOP-T7BHNSJA\\SQLEXPRESS; Database=CORRECCIONPractico1; Integrated Security=SSPI;");
            conexion.Open();
            return conexion;
        }
        public Departamento buscar(int id)
        {
            SqlConnection conexion = crearConexion();
            SqlCommand comando = new SqlCommand("select Cod_Depto,nombre from DEPARTAMENTO where Cod_Depto=" + id, conexion);
            SqlDataReader reader;
            Departamento depto = null;

            reader = comando.ExecuteReader();

            if (reader.Read())
            {  //avanzamos al primer registro y comprobamos si hay datos
                depto = new Departamento();
                depto.Codigo = id;
                depto.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
            }

            return depto;
        }

        public int eliminar(int id)
        {
            SqlConnection conexion = crearConexion();
            SqlCommand comando = new SqlCommand("delete from DEPARTAMENTO where Cod_Depto=" + id, conexion);
            int cont = comando.ExecuteNonQuery();
            return cont;
        }

        public int guardar(Departamento depto)
        {
            int cont = 0;
            SqlTransaction transaccion=null;

            try {
                SqlConnection conexion = crearConexion();
                SqlCommand comando = new SqlCommand("update DEPARTAMENTO set nombre=@NOM  where Cod_Depto=@ID", conexion);
                comando.Parameters.AddWithValue("@NOM", depto.Nombre);
                comando.Parameters.AddWithValue("@ID", depto.Codigo);

                cont = comando.ExecuteNonQuery();

                if (cont == 0)
                {

                    comando = new SqlCommand("insert into DEPARTAMENTO (Nombre , Cod_depto) values (@NOM, @ID)", conexion);
                    comando.Parameters.AddWithValue("@NOM", depto.Nombre);
                    comando.Parameters.AddWithValue("@ID", depto.Codigo);
                    cont = comando.ExecuteNonQuery();
                }
                //confirmar transaccion en la base de datos
                transaccion.Commit();
            }
            catch(Exception ex){
                if (transaccion != null) 
                {
                    transaccion.Rollback();
                }
            }

            return cont;
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