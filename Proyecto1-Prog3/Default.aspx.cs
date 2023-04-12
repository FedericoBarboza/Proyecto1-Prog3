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
            PersistenciaDepartamento persistencia = Global.fabricaPersistencia.ObtenerPersistenciaDepartamento();
            gridDepto.DataSource = persistencia.lista();
            gridDepto.DataBind();
        }

        protected void buscar_Click(object sender, EventArgs e)
        {

        }
    }
}