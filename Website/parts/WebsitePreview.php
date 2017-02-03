
<?php  
 
$file_html = "parts/UserArea/".$FirstName.$LastName."/index.html";
$file_php = "parts/UserArea/".$FirstName.$LastName."/index.php";
$file_htm = "parts/UserArea/".$FirstName.$LastName."/index.htm";


if (file_exists($file_html)) { 
    $file_x = $file_html;
} else if (file_exists($file_php)) { 
    $file_x = $file_php;
} else if (file_exists($file_htm)) { 
    $file_x = $file_htm;
}
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
						<iframe src="<?php echo $file_x ?>" width=100% height="500" ></iframe>
					</div>
				</div>
			
			</div>
    </body>
</html>