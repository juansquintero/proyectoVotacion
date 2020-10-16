<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/admin.aspx.cs" Inherits="View_admin" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Administrador</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="../App_Themes/AdminLogin/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/css/util.css">
	<link rel="stylesheet" type="text/css" href="../App_Themes/AdminLogin/css/main.css">
<!--===============================================================================================-->
</head>
<body>
	
	<form id="form1" runat="server">
	
	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-t-85 p-b-20">
					<span class="login100-form-title p-b-70">
						Administrador
					</span>
					<span class="login100-form-avatar">
						<img src="images/avatar-01.jpg" alt="AVATAR">
					</span>

					<div class="wrap-input100 validate-input m-t-85 m-b-35" data-validate = "Ingrese su numero de cedula">
						<input class="input100" type="text" name="username">
						<span class="focus-input100" data-placeholder="Usuario"></span>
					</div>

					<div class="wrap-input100 validate-input m-b-50" data-validate="Ingrese su codigo">
						<input class="input100" type="password" name="pass">
						<span class="focus-input100" data-placeholder="Codigo"></span>
					</div>

					<div class="container-login100-form-btn">
						<button runat="server" onserverclick="loginButton" class="login100-form-btn">
							Login
						</button>
                        <button style="margin-top:15px" runat="server" onserverclick="salirButton" class="login100-form-btn">
							Salir
						</button>
					</div>

					<ul class="login-more p-t-190">
						<li class="m-b-8">
							<span class="txt1">
								Olvido
							</span>

							<a href="#" class="txt2">
								¿Usuario / Codigo?
							</a>
						</li>

						<li>
							<span class="txt1">
								Nuevo usuario
							</span>

							<a href="admin_new.aspx" class="txt2">
								Registro
							</a>
						</li>

                        <li>
							<span class="txt1">
								¿Necesita ayuda?
							</span>

							<a href="support.aspx" class="txt2">
								Contacto
							</a>
						</li>
					</ul>
				<asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/bootstrap/js/popper.js"></script>
	<script src="../App_Themes/AdminLogin/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/daterangepicker/moment.min.js"></script>
	<script src="../App_Themes/AdminLogin/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/AdminLogin/js/main.js"></script>

    </form>

</body>
</html>
