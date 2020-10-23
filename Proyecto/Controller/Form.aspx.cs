using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                Response.Redirect("~/View/Form.aspx");
            }
        }
        string user_mail = Page.Request.Form["email"].ToString();
        if (string.IsNullOrEmpty(user_mail))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su email');</script>");
        }
        string date_nac = Page.Request.Form["date_nac"].ToString();
        if (string.IsNullOrEmpty(date_nac))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese su fecha de nacimiento');</script>");
        }
        DateTime date_now = DateTime.Now;
        DateTime pruebaMeste = Convert.ToDateTime(date_nac);
        int year = date_now.Year - pruebaMeste.Year;
        int month = date_now.Month - pruebaMeste.Month;
        int day = date_now.Day - pruebaMeste.Day;
        if (month < 0)
        {
            year--;
        }
        else if (month == 0)
        {
            //day <= 0 ? year : year - 1;
            if (day <= 0)
            {
                year--;
            }
        }
        if(year<18)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Menor de edad');</script>");
        }

        string date_exp = Page.Request.Form["date_e"].ToString();
        if (string.IsNullOrEmpty(date_exp))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Menor de Edad');</script>");
        }

        E_user user = new E_user();

        user.User_name = user_name;
        user.User_lastname = user_lastname;
        user.Cedula = cedula;
        user.Nacimiento = date_nac;
        user.Expe = date_exp;
        Session["validUser"] = user;

        user = new DAO_User().compareUser(user);

        if (user == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Esta persona no existe o no puede votar');</script>");
        }
        else if (user.Cedula != cedula)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Esa cedula no existe');</script>");
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Bienvenido');</script>");
            Response.Redirect("~/View/selection_candidate.aspx");
        }

    }

    protected void button_salir(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }

}