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
        E_user user = new E_user();
        

        string user_name = Page.Request.Form["name"].ToString();
        if (string.IsNullOrEmpty(user_name))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el nombre');</script>");
        }
        else
        {
            user.User_name = user_name;
        }

        string user_lastname = Page.Request.Form["lastname"].ToString();
        if (string.IsNullOrEmpty(user_lastname))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el apellido');</script>");
        }
        else
        {
            user.User_lastname = user_lastname;
        }

        string cedula = Page.Request.Form["cedula"].ToString();
        int validate_cedula = 0;
        bool comprobation = int.TryParse(cedula, out validate_cedula);
        if (comprobation == true)
        {
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Funciona perro');</script>");
            user.Cedula = cedula;
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Digite su cedula');window.open('Form.aspx','_self');", true);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su cedula');</script>");
            //Response.Redirect("~/View/admin_menu.aspx");
        }

        string date_nac = Page.Request.Form["date_nac"].ToString();
        if (string.IsNullOrEmpty(date_nac))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese su fecha de nacimiento');</script>");
        }
        else
        {
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
            if (year < 18)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Menor de edad');</script>");
            }
            else
            {
                user.Nacimiento = date_nac;
            }
        }

        string date_exp = Page.Request.Form["date_e"].ToString();
        if (string.IsNullOrEmpty(date_exp))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Menor de Edad');</script>");
        }
        else
        {
            user.Expe = date_exp;
        }

        Session["validUser"] = user;        
        user = new DAO_User().compareUser(user);

        E_user pa = new DAO_User().getCandidatoVoto(cedula);

        if (user == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Esta persona no existe o no puede votar');</script>");
        }
        else if (user.Cedula != cedula)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Esa cedula no existe');</script>");
        }
        else if(pa.Voto == true)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Usted ya realizo la votacion');window.open('index.aspx','_self');", true);
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Bienvenido, por favor vote a conciencia');window.open('selection_candidate.aspx','_self');", true);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Bienvenido');</script>");
            //Response.Redirect("~/View/selection_candidate.aspx");
        }
    }

    protected void button_salir(object sender, EventArgs e)
    {
        Response.Redirect("~/View/index.aspx");
    }

}