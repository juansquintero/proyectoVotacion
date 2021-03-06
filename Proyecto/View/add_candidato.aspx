﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/add_candidato.aspx.cs" Inherits="View_add_candidato" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Añadir candidato</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->
	<link rel="icon" type="image/png" href="../App_Themes/Form/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" href="https://formden.com/static/cdn/bootstrap-iso.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/animate/animate.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/css/util.css">
	<link rel="stylesheet" type="text/css" href="../App_Themes/Form/css/main.css">
<!--===============================================================================================-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"/>
<!--===============================================================================================-->

</head>
<body>


    	<div class="container-contact100">
		<div class="wrap-contact100">
			<form id="form1" runat="server">
				<span class="contact100-form-title">
					Registro
				<asp:TextBox ID="TextBox1" runat="server" Height="1%" Visible="False" Width="1%"></asp:TextBox>
				</span>

				<div class="wrap-input100 validate-input" data-validate="Nombre es requerido">
					<span class="label-input100">Nombre</span>
					<input class="input100" type="text" name="name" id="name" placeholder="Nombre" required>
                    
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate="Apellido es requerido">
					<span class="label-input100">Apellido</span>
					<input class="input100" type="text" name="lastname" id="lastname" placeholder="Apellido" required>
                    
					<span class="focus-input100"></span>
				</div>

				<div class="wrap-input100 validate-input" data-validate="Identificacion">
					<span class="label-input100">Cedula</span>
					<input class="input100" type="text" name="cedula" id="cedula" title="Cedula de ciudadania" pattern="[0-9]{6,10}" required>
                   
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate="El partido es requerido">
					<span class="label-input100">Partido</span>
					<input class="input100" type="text" name="partido" id="partido" placeholder="Partido" required>
                    
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input">
					<span class="label-input100">Foto del candidao</span><br />
                        <asp:FileUpload ID="Foto_Candidato" runat="server" />
					<span class="focus-input100"></span>
				</div>

				<div class="container-contact100-form-btn">
					<div class="wrap-contact100-form-btn">
						<div class="contact100-form-bgbtn"></div>
						<button runat="server" onserverclick="button_enviar" CausesValidation="true" class="contact100-form-btn">
							<span>
								Enviar							
							</span>
						</button>
					</div>
                    <div></div>
                   <div style="margin-top:15px" class="wrap-contact100-form-btn">
						<div class="contact100-form-bgbtn"></div>
						<button runat="server" onserverclick="button_salir" class="contact100-form-btn">
							<span>
								Salir								
							</span>
						</button>
					</div>
				</div>
			</form>
		</div>
	</div>



	<div id="dropDownSelect1"></div>

<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/bootstrap/js/popper.js"></script>
	<script src="../App_Themes/Form/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/select2/select2.min.js"></script>
	<script>
		$(".selection-2").select2({
			minimumResultsForSearch: 20,
			dropdownParent: $('#dropDownSelect1')
		});
	</script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/daterangepicker/moment.js"></script>
	<script src="../App_Themes/Form/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
    <script>
    $(document).ready(function(){
      var date_input=$('input[name="date_nac"]');
      var date_input2=$('input[name="date_e"]');  //our date input has the name "date"
      var container=$('.bootstrap-iso form').length>0 ? $('.bootstrap-iso form').parent() : "body";
      var options={
        format: 'dd/mm/yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
      };
        date_input.datepicker(options);
        date_input2.datepicker(options);
    })
    </script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="../App_Themes/Form/js/main.js"></script>

	<!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-23581568-13"></script>
    <script>
       window.dataLayer = window.dataLayer || [];
       function gtag(){dataLayer.push(arguments);}
       gtag('js', new Date());

        gtag('config', 'UA-23581568-13');
    </script>
<!--===============================================================================================-->

<!--===============================================================================================-->
</body>
</html>

