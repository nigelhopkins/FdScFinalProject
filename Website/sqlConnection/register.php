<?php 
include_once "sqlConnection/register.inc.php";
include_once "sqlConnection/functions.php";
?>
<!DOCTYPE html>
<html>
<head>
	<!----- TITLE FOR THE WEB SITE  ---->
	<title>NH Hopkins Website</title>
	<!----- START OF STYLE SHEETS  ---->
	
	<link rel="stylesheet" type="text/css" href="CSS/login.css" >
	<script type="text/JavaScript" src="js/sha512.js"></script> 
    <script type="text/JavaScript" src="js/forms.js"></script>
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
	<!----- END OF STYLE SHEETS  ---->
	<!----- GOOGLE FONTS  ---->
	<link href='http://fonts.googleapis.com/css?family=Tangerine:400,700' rel='stylesheet' type='text/css'>
	

	<!----- END GOOGLE FONTS  ---->
	<!----- START OF META TAGS  ---->
	<meta charset="UTF-8">
	<meta name="description" content=""><!----- add the description for the website in here this is the description that will be displayed on search engines  ---->
	<meta name="keywords" content=""><!----- add the keywords you would like users to use when searching for the website on search engines  ---->
	<meta name="author" content=""><!----- add the name of the author of the website.  ---->  
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!----- END OF META TAGS  ---->
	<!----- JAVASCRIPT LINKS ---->
</head>
<body>
	<div id="top-bar">	
			<?php include"parts/Nav.html" ?>
	</div>
	<div id="container">
		<div id="content">
			<div id="Title">
				<h1>WebSite Development</h1>
				<div id="SocialMediaBar">
					<ul>
						<li class="SocialMedia">			
								<a href="www.facebook.com" target="_new"><img src="img/SocialMediaIcons/Facebook.png" class="facebook" /></a>
								<a href="www.linkedin.com" target="_new"><img src="img/SocialMediaIcons/LinkedIn.png" class="LinkedIn" /></a>
								<a href="www.youtube.com" target="_new"><img src="img/SocialMediaIcons/YouTube.png" class="YouTube" /></a>							
						</li>
					</ul>
				</div>
			</div> 
				<div id="Login">
					<form action="<?php echo esc_url($_SERVER['PHP_SELF']); ?>" method="post" name="registration_form">
						<ul>
							<li><label>Password: </label><input type="password" name="password" id="password" class="input"/></li>
							<li><label>Confirm password: </label><input type="password" name="confirmpwd" id="confirmpwd" class="input"/></li>
							<li><label> &nbsp </label><input id="Register" type="button" value="Register" 
									onclick="return regformhash(this.form,
													this.form.password,
													this.form.confirmpwd);" class="login" /> </li>
						</ul>
				</form>	
			</div>
		</div>
	</div>
	<div id="footer" data-bottombar role="footer">
		<?php include "parts/Footer.html" ?>
	</div>
</body>
</html>