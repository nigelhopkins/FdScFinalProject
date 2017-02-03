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
<script src="js/cookie.js"></script>
<script type="text/javascript">

<script type="text/javascript">
if ($.cookie('cookies_enable')) {
  //code
}
</script>


</head>
<body>
	</div>
	<div id="top-bar">	
			<?php include"parts/Nav.html" ?>
	</div>
	<div id="container">
		<div id="content">
			<div id="Title">
				<h1>WebSite Development</h1>
				<div style="clear:both;"> &nbsp </div>
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
			
								<?php include"parts/slider.html" ?>
			
			<div class="large-panel">
				<hr>
				<h3>Bespoke :</h3>
				<span>As well as using templates to create your website, we will help you create a truly unique website that will give your company or organisation the right look. 
				<br>
				<br>
				From start to finish you would be involved in every step of the construction </span>
				<div class="clear"> &nbsp </div>
				<hr>
			</div>
			<div class="panel-container">
					<ul>
						<li>
							<ul>
								<?php $sqlProduct_Name = $mysqli->query("SELECT product_name FROM products WHERE id =81")->fetch_object()->product_name;
									$sqlProduct_Desc = $mysqli->query("SELECT product_desc FROM products WHERE id =81")->fetch_object()->product_desc;
									$sqlPrice = $mysqli->query("SELECT price FROM products WHERE id =81")->fetch_object()->price; ?>

								<li><?php echo $sqlProduct_Name ?></li>
								<li><span><?php echo $sqlProduct_Desc ?></span></li>
								<li>Price &pound<?php echo $sqlPrice ?> </li>
							</ul>
						</li>
						<li>
							<ul>
							<?php $sqlProduct_Name = $mysqli->query("SELECT product_name FROM products WHERE id =79")->fetch_object()->product_name;
									$sqlProduct_Desc = $mysqli->query("SELECT product_desc FROM products WHERE id =79")->fetch_object()->product_desc;
									$sqlPrice = $mysqli->query("SELECT price FROM products WHERE id =79")->fetch_object()->price; ?>
								<li><?php echo $sqlProduct_Name ?></li>
								<li><span><?php echo $sqlProduct_Desc ?></span></li>
								<li>Price &pound<?php echo $sqlPrice ?> </li>
							</ul>
						</li>
						<li>
							<ul>
							<?php $sqlProduct_Name = $mysqli->query("SELECT product_name FROM products WHERE id =77")->fetch_object()->product_name;
									$sqlProduct_Desc = $mysqli->query("SELECT product_desc FROM products WHERE id =77")->fetch_object()->product_desc;
									$sqlPrice = $mysqli->query("SELECT price FROM products WHERE id =77")->fetch_object()->price; ?>
								<li><?php echo $sqlProduct_Name ?></li>
								<li><span><?php echo $sqlProduct_Desc ?></span></li>
								<li>Price &pound<?php echo $sqlPrice ?> </li>
							</ul>
						</li>
						<div class="clear"> </div>
					</ul>
			</div>
			<div class="large-panel">
			<hr>
			<h3>SEO :</h3>
				<span>

				SEO (Search Engine Optimization) is a process in which you optimize the visibility off your website in a search engine's results. 
				In general, the higher up the search list your website appears in the search results, the more visitors will use their website. 
				
				<br><br>SEO targets many different kinds of search , including images,local,video and academic searches to insure that you website is ranked as high as possible
				on the search results list.
					
				</span>
			<div class="clear"></div>
			<hr>
			</div>
			
			<div class="large-panel">
			</div>	
			<div class="clear"></div>
		</div>
	</div>
	<div id="footer" data-bottombar role="footer">
		<?php include "parts/Footer.html" ?>
	</div>
</body>
</html>