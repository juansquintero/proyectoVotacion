<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/candidatos_admin.aspx.cs" Inherits="View_candidatos_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Untitled Page</title>
    <link href="../App_Themes/DataGridCandidates/dataGrid.css" rel="Stylesheet" type="text/css" />
</head>
<body>
 <form id="form1" runat="server">
 <div>
     <h1 align="center">Candidatos</h1>
 </div>
 <div>
 <asp:GridView ID="datagrid" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="ODS_Candidato" Width="100%">
     <Columns>
         <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
         <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
         <asp:BoundField DataField="Cc" HeaderText="Cedula" SortExpression="Cc" />
         <asp:BoundField DataField="Partido" HeaderText="Partido" SortExpression="Partido" />
     </Columns>
<HeaderStyle CssClass="header"></HeaderStyle>

<PagerStyle CssClass="pager"></PagerStyle>

<RowStyle CssClass="rows"></RowStyle>
 </asp:GridView>
     <asp:ObjectDataSource ID="ODS_Candidato" runat="server" SelectMethod="GetCandidato" TypeName="DAO_User"></asp:ObjectDataSource>
 </div>
 </form>
</body>
</html>
