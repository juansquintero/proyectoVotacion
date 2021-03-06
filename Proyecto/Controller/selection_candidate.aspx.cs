﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_selection_candidate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        E_user pa = new DAO_User().getCandidatoVoto(((E_user)Session["validUser"]).Cedula);
        if (pa.Voto == true)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Usted ya realizo la votacion');window.open('index.aspx','_self');", true);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usted ya ha votado');</script>");
        }

        var can = new DAO_User().GetCandidato();
        if (can.Count == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('No hay candidatos disponibles');window.open('index.aspx','_self');", true);
            //Response.Redirect("~/View/index.aspx");
        }
    }

    protected void datagrid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        for (int i = 0; i < datagrid.Rows.Count; i++)
        {
            RadioButton rb = (datagrid.Rows[i].FindControl("rdbauthid")) as RadioButton;
            if (rb.Checked == true)
            {
                E_conteo user2 = new E_conteo();

                //Validacion para confirmar que el usurio no ha votado

                E_user pa = new DAO_User().getCandidatoVoto(((E_user)Session["validUser"]).Cedula);

                if (pa == null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Hubo un error haciendo la busqueda del votante');window.open('index.aspx','_self');", true);
                }

                var name = ((E_user)Session["validUser"]).User_name;
                pa.Voto = true;
                var mail = pa.Mail;
                new mail().enviarCorreoVotado(mail, name);

                new DAO_User().save_votado(pa);
                var idcan = int.Parse(datagrid.Rows[i].Cells[0].Text);
                E_conteo ps = new DAO_User().getNoVotos(idcan);

                if (ps == null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Discrepancia de candidato con conteo, reporte esto con un administrador');window.open('index.aspx','_self');", true);
                }
             
                user2.Id = ps.Id;
                user2.N_votos = ps.N_votos + 1;

                new DAO_User().anadir_voto(user2);

                Session["validUser"] = null;
                Session.Abandon();
                Session.Clear();

                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Gracias por ejercer su derecho al voto');window.open('index.aspx','_self');", true);


            }
            
        }


    }
}