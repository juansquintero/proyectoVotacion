using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_add_candidato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_enviar(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string user_name = Page.Request.Form["name"].ToString();
        if (string.IsNullOrEmpty(user_name))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el nombre');</script>");
        }
        string user_lastname = Page.Request.Form["lastname"].ToString();
        if (string.IsNullOrEmpty(user_lastname))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el apellido');</script>");
        }
        string cedula = Page.Request.Form["cedula"].ToString();
        if (string.IsNullOrEmpty(cedula))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su cedula');</script>");
        }
        else
        {
            if (!Regex.IsMatch(cedula, @"^\d+$"))
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No es un numero');</script>");
                Response.Redirect("~/View/add_votante.aspx");
            }
        }
        string user_partido = Page.Request.Form["partido"].ToString();
        if (string.IsNullOrEmpty(user_partido))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su email');</script>");
        }

        E_candidato user = new E_candidato();
        E_conteo user2 = new E_conteo();

        user.Nombre = user_name;
        user.Apellido = user_lastname;
        user.Cc = cedula;
        user.Partido = user_partido;

        user2.Nombre = user_name;
        user2.Apellido = user_lastname;
        user2.Partido = user_partido;
        user2.N_votos = 0;

        new DAO_User().save_candidatos(user);
        new DAO_User().conteo_add(user2);

        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ha funcionado');</script>");

        Response.Redirect("~/View/admin_menu.aspx");
    }

    protected void button_salir(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }
}