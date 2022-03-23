using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmPublishers : System.Web.UI.Page
    {
        //Acceder al servicio web
        srPublishers.wsPublishersSoapClient servicio = new srPublishers.wsPublishersSoapClient();

        //listar Publishers
        private void Listar()
        {
            gvPublishers.DataSource = servicio.ListarPublishers().Tables[0];
            gvPublishers.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Linea de codigo para que solo cargue una sola vez
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar Publishers
            string[] msj = servicio.AgregarPublishers(txtId.Text, txtName.Text, txtCity.Text, txtState.Text, txtCountry.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar Publisher
            string[] msj = servicio.EliminarPublishers(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar Publisher
            string[] msj = servicio.ActualizarPublishers(txtId.Text, txtName.Text, txtCity.Text, txtState.Text, txtCountry.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar Publisher
            gvPublishers.DataSource = servicio.BuscarPublishers(txtId.Text, txtName.Text).Tables[0];
            gvPublishers.DataBind();
        }
    }
}