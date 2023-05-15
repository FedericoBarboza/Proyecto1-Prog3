using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1_Prog3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lista_Click(object sender, EventArgs e)
        {
            PersistenciaDepartamento persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            gridDepto.DataSource = persistencia.lista();
            gridDepto.DataBind();
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(ID.Text);
            Departamento depto = new Departamento();

            PersistenciaDepartamento persistenciaSQLDepto = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            depto = persistenciaSQLDepto.buscar(Id);
            if (depto != null)
            {
                Nombre.Text = depto.Nombre;
            }
        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(ID.Text);

            PersistenciaDepartamento persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            persistencia.eliminar(Id);
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            Departamento depto=new Departamento();
            depto.Codigo = Convert.ToInt32(ID.Text);
            depto.Nombre = Convert.ToString(Nombre.Text);

            PersistenciaDepartamento persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            persistencia.guardar(depto);
        }

        protected void Emp_Click(object sender, EventArgs e)
        {
            Empresa emp = Empresa.getInstancia();

            ContadorPorDepto cont = new ContadorPorDepto(Convert.ToInt32(txtDepto.Text));

            emp.procesarEmpleados(cont);


            int result = cont.resultado;

            Label3.Text = result.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PersistenciaEmpleado persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaEmpleado();
            empGrid.DataSource = persistencia.lista();
            empGrid.DataBind();
        }

        protected void deptoCap_Click(object sender, EventArgs e)
        {
            PersistenciaDepartamento persistencia = Sistema.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            IteradorDepto it = new IteradorDepto();

            while (it.hayMas())
            {
                Departamento d = it.siguiente();
                //procesar d
                d.Nombre = d.Nombre.ToUpper();
                persistencia.guardar(d);
            }
        }
    }
}