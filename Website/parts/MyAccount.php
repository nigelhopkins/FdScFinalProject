<?php  

include_once "Cart/CartConfig.php";
include_once "sqlConnection/functions.php";

?>


<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Secure Login: Protected Page</title>
        <link rel="stylesheet" href="css/LoggedIn.css" />
    </head>
    <body>
			<div id="Container">
				
				<div id="area">
					<div id="area">
						<h1>My Account</h1>
						
							<?php 
								  echo '<table>';
								  echo '<th>Details</th>';
								  echo '<tr><td>Company Name :</td><td>'.$CompanyName.'</td></tr>';
								  echo '<tr><td>First Name :</td><td>'.$FirstName.'</td></tr>';
								  echo '<tr><td>Last Name :</td><td>'.$LastName.'</td></tr>';
								  echo '<tr><td> &nbsp </td><td> &nbsp </td></tr>';
								  echo '<tr><th>Contact Details </th><td> &nbsp </td></tr>';
								  echo '<tr><td>Phone Number :</td><td>'.$PhoneNumber.'</td></tr>';
								  echo '<tr><td>Email Address :</td><td>'.$email.'</td></tr>';
								  echo '<tr><td> &nbsp </td><td></td></tr>';
								  echo '<tr><th>Address</th><td></td></tr>';
								  echo '<tr><td>Building Number :</td><td>'.$BuildingNumber.'</td></tr>';
								  echo '<tr><td>Street Name :</td><td>'.$StreetName.'</td></tr>';
								  echo '<tr><td>City :</td><td>'.$City.'</td></tr>';
								  echo '<tr><td>County :</td><td>'.$County.'</td></tr>';
								  echo '<tr><td>Post Code :</td><td>'.$PostalCode.'</td></tr>';
								  echo '</table>';
							
							?>
						
						
					</div>
				</div>
			
			</div>
    </body>
</html>