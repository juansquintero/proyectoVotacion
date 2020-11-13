using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
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

        E_candidato user = new E_candidato();
        E_conteo user2 = new E_conteo();
        //-//
        string cedula = Page.Request.Form["cedula"].ToString();
        //-//
        

        int validate_cedula = 0;
        bool comprobation = int.TryParse(cedula, out validate_cedula);
        if (comprobation == true)
        {
            
            E_candidato checkCandidato = new DAO_User().GetCandidatoCheck(cedula);
            if (checkCandidato == null)
            {
                //ClientScriptManager cm = this.ClientScript;
                //E_candidato user = new E_candidato();
                //E_conteo user2 = new E_conteo();
                //string cedula = Page.Request.Form["cedula"].ToString();

                string fileName = System.IO.Path.GetFileName(Foto_Candidato.PostedFile.FileName);
                string extension = System.IO.Path.GetExtension(Foto_Candidato.PostedFile.FileName);
                string saveLocation = "~/Util_Support/Perfil_Fotos/" + DateTime.Now.ToFileTime().ToString() + extension;
                //Foto_Candidato.PostedFile.SaveAs(Server.MapPath(saveLocation));

                string user_name = Page.Request.Form["name"].ToString();
                if (string.IsNullOrEmpty(user_name))
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el nombre');</script>");
                }
                else
                {
                    user.Nombre = user_name;
                    user2.Nombre = user_name;
                }

                string user_lastname = Page.Request.Form["lastname"].ToString();
                if (string.IsNullOrEmpty(user_lastname))
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese el apellido');</script>");
                }
                else
                {
                    user.Apellido = user_lastname;
                    user2.Apellido = user_lastname;
                }

                string user_partido = Page.Request.Form["partido"].ToString();
                if (string.IsNullOrEmpty(user_partido))
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su email');</script>");
                }
                else
                {
                    user.Partido = user_partido;
                    user2.Partido = user_partido;
                }

                if (!(extension.Equals(".jpg") || extension.Equals(".jpeg") || extension.Equals(".png")))
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido o no subio archivo');</script>");
                    return;
                } 

                if (System.IO.File.Exists(saveLocation))
                {
                    File.Delete(saveLocation);
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
                    return;
                }

                try
                {
                    Foto_Candidato.PostedFile.SaveAs(Server.MapPath(saveLocation));
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");
                    user.Foto = saveLocation;
                }
                catch (Exception exc)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
                    return;
                }

                try
                {
                    if (user.Foto == " ")
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No ha subido ninguna foto');</script>");
                        user.Foto = Server.MapPath("~\\Util_Support\\Perfil_Fotos\\default_profile.jpg");
                        return;
                    }
                }
                catch (NullReferenceException)
                {

                }

                user.Cc = cedula;
                user2.N_votos = 0;

                new DAO_User().save_candidatos(user);
                new DAO_User().conteo_add(user2);

                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ha funcionado');</script>");

                Response.Redirect("~/View/admin_menu.aspx");
            }
            else if (checkCandidato.Cc == cedula)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Es candidato ya existe');</script>");
            }
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Digite su cedula');</script>");
            Response.Redirect("~/View/admin_menu.aspx");
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