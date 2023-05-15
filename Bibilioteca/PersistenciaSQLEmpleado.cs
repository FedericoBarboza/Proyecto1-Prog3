using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Proyecto1_Prog3
{
    public class PersistenciaSQLEmpleado:PersistenciaEmpleado
    {
        private SqlConnection crearConexion()
        {
            SqlConnection conexion = new SqlConnection("Server=LAPTOP-T7BHNSJA\\SQLEXPRESS; Database=CORRECCIONPractico1; Integrated Security=SSPI;");
            conexion.Open();
            return conexion;
        }
        public Empleado buscar(int id)
        {
            SqlConnection conexion = crearConexion();
            SqlCommand comando = new SqlCommand("select * from EMPLEADO (nolock) where Nro_Doc=" + id, conexion);
            SqlDataReader reader;
            Empleado emp = null;

            reader = comando.ExecuteReader();

            if (reader.Read())
            {  //avanzamos al primer registro y comprobamos si hay datos
                emp = new Empleado();
                emp.Nro_doc = id;
                emp.nombre = reader.GetString(reader.GetOrdinal("Nom_Emp"));
                emp.dir_emp = reader.GetString(reader.GetOrdinal("Direccion"));
                emp.salario = Convert.ToInt32(reader.GetString(reader.GetOrdinal("Salario")));
                emp.sexo = reader.GetString(reader.GetOrdinal("Sexo"));
                emp.Cod_depto = Convert.ToInt32(reader.GetString(reader.GetOrdinal("cod_depto")));
            }

            return emp;
        }

        public int eliminar(int id)
        {
            SqlConnection conexion = crearConexion();
            SqlCommand comando = new SqlCommand("delete from EMPLEADO where Nro_Doc=" + id, conexion);
            int cont = comando.ExecuteNonQuery();
            return cont;
        }

        public int guardar(Empleado emp)
        {
            int cont = 0;
            SqlTransaction transaccion = null;

            try
            {
                SqlConnection conexion = crearConexion();
                SqlCommand comando = new SqlCommand("update EMPLEADO set Nom_emp=@NOM,Direccion=@DIR,Salario=@SAL,Sexo=@SEX,cod_depto=@DEPTO  where Nro_Doc=@ID", conexion);
                comando.Parameters.AddWithValue("@NOM", emp.nombre);
                comando.Parameters.AddWithValue("@DIR", emp.dir_emp);
                comando.Parameters.AddWithValue("@SAL", emp.salario);
                comando.Parameters.AddWithValue("@SEX", emp.sexo);
                comando.Parameters.AddWithValue("@DEPTO", emp.Cod_depto);
                comando.Parameters.AddWithValue("@ID", emp.Nro_doc);

                cont = comando.ExecuteNonQuery();

                if (cont == 0)
                {

                    comando = new SqlCommand("insert into EMPLEADO (Nro_Doc, Nom_emp , Direccion, Salario, Sexo, cod_depto) values (@ID, @NOM, @DIR, @SAL, @DEPTO)", conexion);
                    comando.Parameters.AddWithValue("@NOM", emp.nombre);
                    comando.Parameters.AddWithValue("@ID", emp.Nro_doc);
                    comando.Parameters.AddWithValue("@DIR", emp.dir_emp);
                    comando.Parameters.AddWithValue("@SEX", emp.sexo);
                    comando.Parameters.AddWithValue("@SAL", emp.salario);
                    comando.Parameters.AddWithValue("@DEPTO", emp.dir_emp);
                    cont = comando.ExecuteNonQuery();
                }
                //confirmar transaccion en la base de datos
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }

            return cont;
        }

        public List<Empleado> lista()
        {
            List<Empleado> lista = new List<Empleado>();
            Empleado empleado = null;
            SqlConnection conexion = crearConexion();
            SqlCommand sentencia = new SqlCommand("select * from EMPLEADO (nolock)", crearConexion());
            SqlDataReader reader = sentencia.ExecuteReader();

            while (reader.Read())
            {
                empleado = new Empleado();
                empleado.Cod_depto = (int)reader["Nro_Doc"];
                empleado.nombre = reader["Nom_emp"].ToString();
                empleado.dir_emp = reader["Direccion"].ToString();
                empleado.salario = (int)reader["Salario"];
                empleado.sexo = reader["Sexo"].ToString();
                empleado.Cod_depto = (int)reader["cod_depto"];

                lista.Add(empleado);
            }
            return lista;
        }
    }
}