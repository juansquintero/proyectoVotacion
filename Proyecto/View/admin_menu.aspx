<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/admin_menu.aspx.cs" Inherits="View_admin_menu" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Menu Administrador</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
<!--===============================================================================================-->
	<link rel="icon" type="image/png" href="../App_Themes/Login/Login/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/css/util.css">
	<link rel="stylesheet" type="text/css" href="../App_Themes/Login/Login/css/main.css">
<!--===============================================================================================-->
</head>
<body>
	
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<form id="form1" runat="server">
					<span class="login100-form-title p-b-26">
						Seleccione que desea añadir
					</span>	
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn">
					<span class="login100-form-title p-b-26">
						        <asp:Button ID="Button1" runat="server" Text="Button" Visible="False" />
					</span></div>
							<button id="boton_votacion" runat="server"  onserverclick="votantesBoton" class="login100-form-btn" type="button">
								Votantes</button></div>
                        </div>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>	
                            <div>
                            <button id="Button2" runat="server"  onserverclick="votantesBotonAdd" class="login100-form-btn" type="button">
								Añadir - Votantes</button></div>
						
					</div></div>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<button id="boton_consulta" runat="server" onserverclick="candidatosBoton" class="login100-form-btn" type="button">
								Candidatos</button></div>
						</div>					
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>							
                            <button id="boton_consulta2" runat="server" onserverclick="candidatosBotonAdd" class="login100-form-btn" type="button">
								Añadir - Candidatos</button>
						</div></div>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>							
                            <button id="Button5" runat="server" onserverclick="escrutinio" class="login100-form-btn" type="button">
								Escrutinio</button>
						</div></div>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>							
                            <button id="Button4" runat="server" onserverclick="vaciar_tablas" class="login100-form-btn" type="button">
								Nueva Votacion</button>
						</div></div>                    
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>							
                            <button id="Button3" runat="server" onserverclick="salir_click" class="login100-form-btn" type="button">
								Salir</button>
						</div></div>


                    
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/bootstrap/js/popper.js"></script>
	<script src="../App_Themes/Login/Login/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/daterangepicker/moment.min.js"></script>
	<script src="../App_Themes/Login/Login/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Login/Login/js/main.js"></script>

</body>
</html>