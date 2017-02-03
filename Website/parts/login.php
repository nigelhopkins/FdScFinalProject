<?php
include_once 'sqlConnection/db_connect.php';
include_once 'sqlConnection/functions.php'; 
 
if (login_check($mysqli) == true) {
    $logged = 'in';
} else {
    $logged = 'out';
}
?>

<!DOCTYPE html>
<html>
	<head>
		<title>MiniCart</title>
		<link rel="stylesheet" type="text/css" href="CSS/login.css" >
		<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
		<script type="text/JavaScript" src="js/sha512.js"></script> 
        <script type="text/JavaScript" src="js/forms.js"></script> 
	</head>
	<body>       
		<div id="Login">
			<div class="LoginError">
				<?php
					if (isset($_GET['error'])) {
					echo '<p class="error">Error Logging In! &nbsp </p>';
					}
				?> 
			</div>
		<form action="sqlConnection/process_login.php" method="post" name="login_form">                      
            <ul>
			<li><label>Email: </label></li>
			<li><input type="text" name="email" id="email" class="input" /></li>
            <li><label>Password: </label></li>
			<li><input type="password" 
                             name="password" 
                             id="password" class="input" /></li>
            <li><input type="button" 
                   value="Login" 
				   class="login"
                   onclick="formhash(this.form, this.form.password);" /> </li>
			</ul>
		</form>
		</div>   
	</body>
</html>