using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Form.aspx");
    }

    protected void consultaBoton(object sender, EventArgs e)
    {
        Response.Redirect("~/View/support.aspx");
    }
}