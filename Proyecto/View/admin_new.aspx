<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/admin_new.aspx.cs" Inherits="View_admin_new" %>

<!DOCTYPE html>
<html lang="es">
<head>
	<title>Registro</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="../App_Themes/AdminNew/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/css/util.css">
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminNew/css/main.css">
<!--===============================================================================================-->
</head>
<body>
	
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<form id="form1" runat="server">
					<span class="login100-form-title">
						Nuevo usuario
					</span>

					<div class="wrap-input100 validate-input m-b-16" data-validate="Por favor ingrese un usuario">
						<input class="input100" type="text" name="username" placeholder="Usuario">
						<span class="focus-input100"></span>
					</div>
                    <div class="wrap-input100 validate-input m-b-16" data-validate="Ingrese su correo">
						<input class="input100" type="text" name="mail" placeholder="Correo">
						<span class="focus-input100"></span>
					</div>

					<div class="container-login100-form-btn">
						<button style="margin-top:25px" runat="server" onserverclick="registerButton" class="login100-form-btn">
							Registrar
						</button>
                        <button style="margin-top:15px" runat="server" onserverclick="salirButton" class="login100-form-btn">
							Salir
						</button>
					</div>

					<div class="flex-col-c p-t-170 p-b-40">
						<span class="txt1 p-b-9">
							¿Necesita ayuda?
						</span>

						<a href="support.aspx" class="txt3">
							Contacto
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	
	
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/bootstrap/js/popper.js"></script>
	<script src="../App_Themes/AdminNew/vendor/bootstrap/js/popper.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/daterangepicker/moment.min.js"></script>
	<script src="../App_Themes/AdminNew/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminNew/js/main.js"></script>

    <p>

						<a href="support.aspx" class="txt3">
							<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
						</a>
					</p>

</body>
</html>
