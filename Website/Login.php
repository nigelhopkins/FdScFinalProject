<?php 

include_once "sqlConnection/db_connect.php";
include_once "sqlConnection/functions.php";

sec_session_start();
if (login_check($mysqli) == true) {
    $logged = 'in';
} else {
    $logged = 'out';
}
?>
<!DOCTYPE html>
<html>
<head>
	<!----- TITLE FOR THE WEB SITE  ---->
	<title>NH Hopkins Website</title>
	<!----- START OF STYLE SHEETS  ---->
	<link rel="stylesheet" type="text/css" href="CSS/default.css" >
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

				<?php
							if(login_check($mysqli) == true) {
							include"parts/LoginLandingPage.php";
							} else { 
						    include"parts/login.php";
							}

						?>
	
			
		</div>
	</div>
	<div id="footer" data-bottombar role="footer">
		<?php include "parts/Footer.html" ?>
	</div>
</body>
</html>