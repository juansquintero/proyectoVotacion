using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_admin_new : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void registerButton(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string user_name = Page.Request.Form["username"].ToString();

        E_admin ps = new DAO_User().getAdminCheck(user_name);

        if (ps == null)
        {
            if (string.IsNullOrEmpty(user_name))
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un usuario');</script>");
            }
            else
            {
                E_admin euser = new E_admin();
                Random r = new Random();

                euser.User_name_admin = user_name;
                euser.User_code_admin = r.Next(10000, 99999).ToString();

                new DAO_User().save_admin(euser);
                //Pendiente correo para confirmar contraseña de admin
            }
        }
        else if (ps.User_name_admin == user_name)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un usuario');</script>");
            Response.Redirect("~/View/admin_new.aspx");
        }
    }

    protected void salirButton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
}