﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_add_votante : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void button_enviar(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        E_user user = new E_user();

        string cedula = Page.Request.Form["cedula"].ToString();
        int largoCedula = cedula.Length;
        int validate_cedula = 0;
        if (largoCedula <6 || largoCedula>10)
        {
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('el tamaño de la cédula es inconsistente');</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('El tamaño de la cédula es inconsistente');window.open('add_votante.aspx','_self');", true);
            //Response.Redirect("~/View/add_votante.aspx");
        }
        else
        {
            bool comprobation = int.TryParse(cedula, out validate_cedula);
            if (comprobation == true)
            {
                E_user checkUser = new DAO_User().GetVotanteCheck(cedula);
                if (checkUser == null)
                {
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
                    string user_mail = Page.Request.Form["email"].ToString();
                    if (string.IsNullOrEmpty(user_mail))
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su email');</script>");
                    }
                    else
                    {
                        user.Mail = user_mail;
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

                        if (day <= 0)
                        {
                            year--;
                        }
                    }
                    if (year < 18)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ingrese su fecha de nacimiento');window.open('add_votante.aspx','_self');", true);
                        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese su fecha de nacimiento');</script>");
                        //Response.Redirect("~/View/add_votante.aspx");
                    }
                    else
                    {
                        user.Nacimiento = date_nac;
                    }
                    //De la linea 71 a 96 se valida la edad por medio de una operación matemática

                    string date_exp = Page.Request.Form["date_e"].ToString();
                    if (string.IsNullOrEmpty(date_exp))
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese la fecha de expedicion de su documento');</script>");
                    }
                    DateTime date_nac2 = Convert.ToDateTime(date_nac);
                    DateTime pruebaMeste2 = Convert.ToDateTime(date_exp);
                    year = pruebaMeste2.Year - date_nac2.Year;
                    month = pruebaMeste2.Month - date_nac2.Month;
                    day = pruebaMeste2.Day - date_nac2.Day;
                    if (month < 0)
                    {
                        year--;
                    }
                    else if (month == 0)
                    {

                        if (day <= 0)
                        {
                            year--;
                        }
                    }
                    if (year < 18)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ingrese su fecha de nacimiento');window.open('add_votante.aspx','_self');", true);
                        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese su fecha de nacimiento');</script>");
                        //Response.Redirect("~/View/add_votante.aspx");
                    }
                    else if (year == 18 && month < 1)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ingrese su fecha de nacimiento');window.open('add_votante.aspx','_self');", true);
                        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese su fecha de nacimiento');</script>");
                        //Response.Redirect("~/View/add_votante.aspx");
                    }
                    else
                    {
                        user.Expe = date_exp;
                    }

                    user.Cedula = cedula;
                    user.Voto = false;
                    new DAO_User().save_votantes(user);
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Ha sido registrado');window.open('admin_menu.aspx','_self');", true);
                    //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ha funcionado');</script>");
                    //Response.Redirect("~/View/admin_menu.aspx");
                }
                else if (checkUser.Cedula == cedula)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Cedula ya Registrada');</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Digite su cedula');window.open('add_votante.aspx','_self');", true);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su cedula');</script>");
                //Response.Redirect("~/View/admin_menu.aspx");
            }
        }
        
    }
    protected void button_salir(object sender, EventArgs e)
    {
        Session["validUser"] = null;
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/View/admin_menu.aspx");
    }
}