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
        string mail = Page.Request.Form["mail"].ToString();

        E_admin ps = new DAO_User().getAdminCheck(user_name);

        if (ps == null)
        {
            if (string.IsNullOrEmpty(user_name))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ingrse un usuario');window.open('admin_new.aspx','_self');", true);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un usuario');</script>");
            }
            else if(string.IsNullOrEmpty(mail))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ingrese un correo');window.open('admin_new.aspx','_self');", true);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un correo');</script>");
            }
            else
            {
                E_admin euser = new E_admin();
                Random r = new Random();

                euser.User_name_admin = user_name;
                euser.User_code_admin = r.Next(10000, 99999).ToString();

                new DAO_User().save_admin(euser);
                new mail().enviarCorreoAdmin(mail, euser.User_code_admin);                
            }
        }
        else if (ps.User_name_admin == user_name)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Es usuario ya existe');window.open('admin_new.aspx','_self');", true);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un usuario');</script>");
            //Response.Redirect("~/View/admin_new.aspx");
        }
    }

    protected void salirButton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
}