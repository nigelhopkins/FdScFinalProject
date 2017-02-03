<?php
include_once 'sqlConnection/psl-config.php';
include_once 'sqlConnection/functions.php';

$db_handle = mysql_connect(HOST,USER,PASSWORD,DATABASE);
$db_found = mysql_select_db(DATABASE, $mysqli );

if ($db_found) {

$SQL = "SELECT * FROM members WHERE username=".$_SESSION['username'];
$result = mysql_query($SQL);

while ( $db_field = mysql_fetch_assoc($result) ) {

echo $db_field['ID'] . "<BR>";
echo $db_field['username'] . "<BR>";
echo $db_field['email'] . "<BR>";
echo $db_field['password'] . "<BR>";

}

mysql_close($db_handle);

}
else {

echo "Database NOT Found ";
mysql_close($db_handle);

}
?>