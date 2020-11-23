<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/support.aspx.cs" Inherits="View_support" %>

<!DOCTYPE html>

<html>
<head>
<title>Soporte</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Marvelous Contact Form Widget Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- font files -->
<link href='//fonts.googleapis.com/css?family=Noto+Sans:400,700' rel='stylesheet' type='text/css'>
<link href='//fonts.googleapis.com/css?family=Nunito:400,700,300' rel='stylesheet' type='text/css'>
<!-- /font files -->
<!-- css files -->
<link href="../App_Themes/Support/css/style.css" rel='stylesheet' type='text/css' media="all" />
<!-- /css files -->
</head>
<body>
<h1>Soporte</h1>
<div class="content-w3ls">
	<form id="form1" runat="server">
		<div class="form-w3ls">
			<h2>Contactenos</h2>
			<button type="submit" class="sign-in" value="Sign In"><img src="../App_Themes/Support/images/mail2.png" alt="w3layouts"></button>
			<div class="clear"></div>
		</div>
		<input type="text" name="userid" value="Nombre" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'NOMBRE';}">
		<input type="email" name="email" value="Correo" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'CORREO@CORREO.COM';}">
		<textarea type="message" name="message" value="Su mensaje" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'SU MENSAJE';}">Su mensaje</textarea>
		<input type="submit" class="sign-in" runat="server" onserverclick="envio_soporte" value="Enviar">
        <input type="submit" class="sign-in" runat="server" onserverclick="salir_menu" value="Salir">
	</form>
</div>
    <p>
			<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
			</p>

</body>
</html>