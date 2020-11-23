using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_votantes_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var Logged = Session["validUser"];
        if (Logged == null)
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void button_salir(object sender, EventArgs e)
    {
        Response.Redirect("~/View/admin_menu.aspx");
    }
}