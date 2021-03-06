﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/escru_mostrar.aspx.cs" Inherits="View_escru_mostrar" %>

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
            <h1 align="center">Escrutinio</h1>
        </div>
        <div>
            <asp:GridView ID="datagrid" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODS_Votatantes" Width="100%">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="Partido" HeaderText="Partido" SortExpression="Partido" />
                    <asp:BoundField DataField="N_votos" HeaderText="Numero de votos " SortExpression="N_votos" />
                </Columns>
                <HeaderStyle CssClass="header"></HeaderStyle>

                <PagerStyle CssClass="pager"></PagerStyle>

                <RowStyle CssClass="rows"></RowStyle>
            </asp:GridView>
            <asp:ObjectDataSource ID="ODS_Votatantes" runat="server" SelectMethod="GetEscrutinio" TypeName="DAO_User"></asp:ObjectDataSource>
        </div>
        <div align="center" style="margin-top: 15px" class="wrap-contact100-form-btn">
            <div class="contact100-form-bgbtn"></div>
            <button runat="server" onserverclick="button_salir" class="btncss">
                <span>Salir								
                </span>
            </button>
            <asp:Button ID="Expo" runat="server" OnClick="Expo_Click" Text="Exportar" class="btncss" />
        </div>
    </form>
</body>
</html>
