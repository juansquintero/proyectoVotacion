using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_selection_candidate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
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
                Label1.Text = datagrid.Rows[i].Cells[1].Text;
            }
        }

        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ahhhhhh me vine');</script>");
    }
}