<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/selection_candidate.aspx.cs" Inherits="View_selection_candidate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Votacion</title>
    <link href="../App_Themes/DataGridCandidates/dataGrid.css" rel="Stylesheet" type="text/css" />
    <link href="../App_Themes/Button/btncss.css" rel="Stylesheet" type="text/css" />

    <script type="text/javascript">  
            function CheckOtherIsCheckedByGVID(spanChk) {  
                var IsChecked = spanChk.checked;  
                if (IsChecked) {                   
                    spanChk.parentElement.parentElement.style.backgroundColor = '#228b22';  
                    spanChk.parentElement.parentElement.style.color = 'white';  
                }  
                var CurrentRdbID = spanChk.id;  
                var Chk = spanChk;  
                Parent = document.getElementById("<%=datagrid.ClientID%>");  
                var items = Parent.getElementsByTagName('input');  
                for (i = 0; i < items.length; i++) {  
                    if (items[i].id != CurrentRdbID && items[i].type == "radio") {  
                        if (items[i].checked) {  
                            items[i].checked = false;
                            items[i].parentElement.parentElement.style.backgroundColor = 'white'   
                            items[i].parentElement.parentElement.style.color = 'black';  
                        }  
                    }  
                }  
            }  
    </script>  

</head>
<body>
 <form id="form1" runat="server">
 <div>
     <h1 align="center">Candidatos A Votar</h1>
 </div>
 <div>
 <asp:GridView ID="datagrid" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="False" Width="100%" DataKeyNames="Id" DataSourceID="ObjectDataSource1">

     <Columns>
         <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
         <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
         <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
         <asp:BoundField DataField="Partido" HeaderText="Partido" SortExpression="Partido" />
         <asp:ImageField DataImageUrlField="Foto" ControlStyle-Width="100" ControlStyle-Height="100" HeaderText="Foto" />
         <asp:TemplateField>
            <ItemTemplate>
                <asp:RadioButton ID="rdbauthid" runat="server" onclick="javascript:CheckOtherIsCheckedByGVID(this);" /> 
            </ItemTemplate>
         </asp:TemplateField>
     </Columns>

<HeaderStyle CssClass="header"></HeaderStyle>

<PagerStyle CssClass="pager"></PagerStyle>

<RowStyle CssClass="rows"></RowStyle>
 </asp:GridView>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCandidato" TypeName="DAO_User"></asp:ObjectDataSource>
 </div>
     <div align="center" id="50px">

         <asp:Button ID="Button1" runat="server" Text="VOTAR!!" OnClick="Button1_Click1" class="btncss" Width="180px" Height="60px" />

         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

     </div>
 </form>
</body>
</html>