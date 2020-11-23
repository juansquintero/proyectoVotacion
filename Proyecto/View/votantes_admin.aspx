<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/votantes_admin.aspx.cs" Inherits="View_votantes_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Votantes admin</title>
    <link href="../App_Themes/DataGridCandidates/dataGrid.css" rel="Stylesheet" type="text/css" />
    <link href="../App_Themes/Button/btncss.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center">Votantes</h1>
        </div>
        <div>
            <asp:GridView ID="datagrid" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODS_Votatantes" Width="100%" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="User_name" HeaderText="Nombre" SortExpression="User_name" />
                    <asp:BoundField DataField="User_lastname" HeaderText="Apellido" SortExpression="User_lastname" />
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula" />
                    <asp:BoundField DataField="Expe" HeaderText="Fecha de Expedición" SortExpression="Expe" />
                    <asp:BoundField DataField="Nacimiento" HeaderText="Fecha de nacimiento" SortExpression="Nacimiento" />
                    <asp:BoundField DataField="Mail" HeaderText="Correo" SortExpression="Mail" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <HeaderStyle CssClass="header"></HeaderStyle>

                <PagerStyle CssClass="pager"></PagerStyle>

                <RowStyle CssClass="rows"></RowStyle>
            </asp:GridView>
            <asp:ObjectDataSource ID="ODS_Votatantes" runat="server" SelectMethod="GetVotantes" TypeName="DAO_User" DataObjectTypeName="E_user" DeleteMethod="deleteUser" UpdateMethod="editUser"></asp:ObjectDataSource>
        </div>
        <div style="margin-top: 15px" class="wrap-contact100-form-btn">
            <div class="contact100-form-bgbtn"></div>
            <button runat="server" onserverclick="button_salir" class="btncss">
                <span>Salir								
                </span>
            </button>
        </div>
    </form>
</body>
</html>

