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
        //Response.Redirect("~/View/Form.aspx");
    }

    protected void candidatosBoton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/candidatos_admin.aspx");
    }

    protected void candidatosBotonAdd(object sender, EventArgs e)
    {
        Response.Redirect("~/View/candidatos_admin.aspx");
    }

    protected void votantesBotonAdd(object sender, EventArgs e)
    {
        Response.Redirect("~/View/add_votante.aspx");
    }
}