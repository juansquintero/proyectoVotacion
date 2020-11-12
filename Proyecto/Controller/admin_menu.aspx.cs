using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_admin_menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void votantesBoton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/votantes_admin.aspx");
    }

    protected void candidatosBoton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/candidatos_admin.aspx");
    }

    protected void candidatosBotonAdd(object sender, EventArgs e)
    {
        Response.Redirect("~/View/add_candidato.aspx");
    }

    protected void votantesBotonAdd(object sender, EventArgs e)
    {
        Response.Redirect("~/View/add_votante.aspx");
    }

    protected void salir_click(object sender, EventArgs e)
    {
        Session["validUser"] = null;
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/View/index.aspx");
    }
}