<?php 

include_once "sqlConnection/db_connect.php";
include_once "sqlConnection/functions.php"; 
$Name = $_SESSION['user_id'];
include_once "parts/test.php";

// Include database connection and functions here.  See 3.1. 
?>
<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Secure Login: Protected Page</title>
        <link rel="stylesheet" href="CSS/LoggedIn.css" />
    </head>
    <body>
			
			<div id="Welcome">
            <p>Welcome <?php echo $FirstName. " " . $LastName; ?>!</p>
			</div>
			<div id="MemberAreaNav">
				<form>
					<ul>
						<li><button type="button" onclick="window.location.href='Login.php?p=WebsitePreview'">Website Preview</button></a></li>
						<li><button type="button" onclick="window.location.href='Login.php?p=Upload'">Upload Files</button></a></li>
						<li><button type="button" onclick="window.location.href='Login.php?p=MyAccount'">My Account</button></a></li>
						<li><button type="button" onclick="window.location.href='sqlConnection/logout.php'">Logout</button></li>
					</ul>
				</form>
				
			</div>
			<div id="Container">
				
				<div id="area">
					<div id="area">	
						<?php
			if (isset($_GET['p']))
				{
				switch($_GET['p']) { //switch is just like a bunch of if()s
					default: //default case
				case 'default': //default case
					include('parts/WebsitePreview.php'); //include page.html
					break; //break, witch means stop
				case 'Upload': // Viewcart, if changePage has the value of ViewCart
					include('parts/Upload.php'); //include view_cart.php
					break; //stop it
				case 'MyAccount' :
					include('parts/MyAccount.php');
					break;
				case 'Payment': // payments page
					include('parts/Payments.php');
					break;
				} //end the switch
				}
			else
				{
					include('parts/WebsitePreview.php');
				}
				?>
				
				<?php 
					
				?>
					</div>
				</div>
			
			</div>
    </body>
</html>
