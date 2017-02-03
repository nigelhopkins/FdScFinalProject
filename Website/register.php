<?php 
include_once "sqlConnection/register.inc.php";
include_once "sqlConnection/functions.php";
include_once "sqlConnection/db_connect.php";
?>
<!DOCTYPE html>
<html>
<head>
	<!----- TITLE FOR THE WEB SITE  ---->
	<title>NH Hopkins Website</title>
	<!----- START OF STYLE SHEETS  ---->
	<link rel="stylesheet" type="text/css" href="CSS/default.css" >
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
								<a href="https://www.facebook.com/nigel.hopkins.355" target="_new"><img style="border:0px;" alt="Facebook" src="img/SocialMediaIcons/Facebook.png" class="facebook" /></a>
								<a href="https://www.linkedin.com/hp/?dnr=FgyjRUh34LGprRqNFgvCRj8MNLGYTu4_674Z" target="_new"><img style="border:0px;" alt="LinkedIn" src="img/SocialMediaIcons/LinkedIn.png" class="LinkedIn" /></a>
								<a href="https://www.youtube.com/channel/UCQPlVS4KZQBoCJXymVr9bPw" target="_new"><img style="border:0px;" alt="YouTube" src="img/SocialMediaIcons/YouTube.png" class="YouTube" /></a>														
						</li>
					</ul>
				</div>
			</div> 
				<div id="Login">
					<form action="<?php echo esc_url($_SERVER['PHP_SELF']); ?>" method="post" name="registration_form">
						<ul>
							<li><label>Email: </label><input type="email" name="email" id="email" class="input"/></li>
							<li><label>Pin: </label><input type="text" name="pin" id="pin" class="input"/></li>
							<li><label>Password: </label><input type="password" name="password" id="password" class="input"/></li>
							<li><label>Confirm: </label><input type="password" name="confirmpwd" id="confirmpwd" class="input"/></li>
							<li><input id="Register" type="button" value="Set Password" 
									onclick="return regformhash(this.form,
													this.form.email,
													this.form.pin,
													this.form.password,
													this.form.confirmpwd);" class="login" /> </li>
							<li> &nbsp </li>
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