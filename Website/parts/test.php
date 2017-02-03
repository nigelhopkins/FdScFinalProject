<?php
// Create connection
$conn = $mysqli = new mysqli(HOST, USER, PASSWORD, DATABASE);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$sql = "SELECT id, username, email, CompanyName, FirstName, LastName, PhoneNumber, BuildingNumber, StreetName, City, County, PostalCode  FROM members WHERE FirstName='Nigel'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    
    // output data of each row
    while($row = $result->fetch_assoc()) {
		
		$id = $row['id'];
		$username = $row['username'];
		$email = $row['email'];
		$CompanyName = $row['CompanyName'];
		$FirstName = $row['FirstName'];
		$LastName = $row['LastName'];
		$PhoneNumber = $row['PhoneNumber'];
		$BuildingNumber = $row['BuildingNumber'];
		$StreetName = $row['StreetName'];
		$City = $row['City'];
		$County = $row['County'];
		$PostalCode = $row['PostalCode'];
    }
    
} else {
    echo "0 results";
}
$conn->close();
?>
