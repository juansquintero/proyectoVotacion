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
        var Logged = Session["validUser"];
        if (Logged == null)
        {
            Response.Redirect("Login.aspx");
        }
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

    protected void escrutinio(object sender, EventArgs e)
    {
        Response.Redirect("~/View/escru_mostrar.aspx");
    }

    protected void vaciar_tablas(object sender, EventArgs e)
    {
        new DAO_User().truncateTables();
        ClientScriptManager cm = this.ClientScript;
        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Se ha borrado la base de datos');</script>");
        Response.Write("<script>alert('Datos eliminados')</script>");
    }

    protected void salir_click(object sender, EventArgs e)
    {
        Session["validUser"] = null;
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/View/index.aspx");
    }
}