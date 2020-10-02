<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Form.aspx.cs" Inherits="View_Form" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Formulario</title>
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
			<form class="contact100-form validate-form">
				<span class="contact100-form-title">
					Registro
				</span>

				<div class="wrap-input100 validate-input" data-validate="Nombre es requerido">
					<span class="label-input100">Nombre</span>
					<input class="input100" type="text" name="name" placeholder="Nombre">
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate="Apellido es requerido">
					<span class="label-input100">Apellido</span>
					<input class="input100" type="text" name="name" placeholder="Apellido">
					<span class="focus-input100"></span>
				</div>

				<div class="wrap-input100 validate-input" data-validate="Identificacion">
					<span class="label-input100">Cedula</span>
					<input class="input100" type="number" name="number">
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate = "Un correo valido es necesario: ex@abc.xyz">
					<span class="label-input100">Correo</span>
					<input class="input100" type="text" name="email" placeholder="Ingrese su correo">
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate="Nacimiento">
					<span class="label-input100">Fecha de nacimiento</span>
                       <div class="form-group"> <!-- Date input -->
                            <input class="form-control" id="date" name="date" placeholder="Dia-Mes-Año" type="text"/>
                       </div>                  
					<span class="focus-input100"></span>
				</div>

                <div class="wrap-input100 validate-input" data-validate="Expedicion">
					<span class="label-input100">Fecha de expedicion</span>
                       <div class="form-group"> <!-- Date input -->
                            <input class="form-control" id="date2" name="date" placeholder="Dia-Mes-Año" type="text"/>
                       </div>                  
					<span class="focus-input100"></span>
				</div>

				<div class="container-contact100-form-btn">
					<div class="wrap-contact100-form-btn">
						<div class="contact100-form-bgbtn"></div>
						<button class="contact100-form-btn">
							<span>
								Enviar							
							</span>
						</button>
					</div>
                    <div></div>
                   <div style="margin-top:15px" class="wrap-contact100-form-btn">
						<div class="contact100-form-bgbtn"></div>
						<button class="contact100-form-btn">
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
      var date_input=$('input[name="date"]');
      var date_input2=$('input[name="date2"]');  //our date input has the name "date"
      var container=$('.bootstrap-iso form').length>0 ? $('.bootstrap-iso form').parent() : "body";
      var options={
        format: 'dd/mm/yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
      };
        date_input.datepicker(options);
        date_input2.datepicker=$(options);
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

</body>
</html>

