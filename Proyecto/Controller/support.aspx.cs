using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_support : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void envio_soporte(object sender, EventArgs e)
    {
        string user_name = Page.Request.Form["userid"].ToString();
        string mail = Page.Request.Form["email"].ToString();
        string message = Page.Request.Form["message"].ToString();

        new mail().enviarCorreo(mail, user_name);
        new mail().enviarCorreoSoporte("strangelife28@gmail.com", message + " => " + user_name + " : " + mail);
        new mail().enviarCorreoSoporte("anderson28.1997@gmail.com", message + "  " + user_name + " : " + mail);

        ClientScriptManager cm = this.ClientScript;
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Si ticket ha sido enviado, pronto tendra respuesta');</script>");
    }

    protected void salir_menu(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
}