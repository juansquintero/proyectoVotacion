using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void button_enviar(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string user_name = Page.Request.Form["name"].ToString();
        string user_lastname = Page.Request.Form["lastname"].ToString();
        int cedula = Page.Request.Form["cedula"].FirstOrDefault();
        string user_mail = Page.Request.Form["email"].ToString();
        string date_nac = Page.Request.Form["date_nac"].ToString();
        string date_exp = Page.Request.Form["date_e"].ToString();

        E_user user = new E_user();

        user.User_name = user_name;
        user.User_lastname = user_lastname;
        user.Cedula = cedula;
        user.Mail = user_mail;
        user.Nacimiento = Convert.ToDateTime(date_nac);
        user.Expe = Convert.ToDateTime(date_exp);

        new DAO_User().save_votantes(user);

        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ha funcionado');</script>");
    }

    protected void button_salir(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
   
}