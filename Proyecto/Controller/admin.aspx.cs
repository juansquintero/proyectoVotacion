using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton(object sender, EventArgs e)
    {
        E_admin euser = new E_admin();
        ClientScriptManager cm = this.ClientScript;
        euser.User_name_admin = Page.Request.Form["username"].ToString();
        euser.User_code_admin = Page.Request.Form["pass"].ToString();

        euser = new DAO_User().login(euser);

        if (euser == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El usuario es incorrecto');</script>");
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Funciona');</script>");
            Response.Redirect("admin_menu.aspx");
        }
    }

    protected void salirButton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
}