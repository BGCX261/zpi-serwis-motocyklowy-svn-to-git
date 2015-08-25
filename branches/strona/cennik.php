<?php header('Content-Type: text/html; charset=utf-8'); ?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
	<link rel="Stylesheet" type="text/css" href="src/styl.css" >
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<title>System zarz¹dzania serwisem motocyklowym</title>
</head>
<body>
	<div id="headerarea">
	<div align="center" id="header">
		<div id="logo">
		<img src="src/logo.png" width="1000" height="140" border="0" alt="POD">
		</a>
		</div>
	</div>
</div>
</br>
</br>
<div id="blok">
<div class="tekst">
</br></br></br>
	<?PHP
		error_reporting(E_ERROR | E_WARNING | E_PARSE );
		if (isset($_POST['cennik']))
		{
			header('location:cennik.php');
		}
		$connection = mysql_connect("localhost", "root");
		mysql_set_charset('utf8',$connection);
		if ($connection and mysql_select_db("baza")) { 
		$VIN = $_POST['VIN'];
		$wynik = mysql_query("SELECT ID, nazwa, cena FROM cennik") or die("B³¹d w zapytaniu!"); 
		}
		else echo "Nie mo¿na po³¹czyæ siê z baz¹ danych."; 
echo "<table border='1' cellpadding='5' rules='all' id='tabela'>
<tr>
<th>Id</th>
<th>Nazwa</th>
<th>Cena</th>
</tr>";

while($row = mysql_fetch_array($wynik))
  {
	echo "<tr>";
	echo "<td>" . $row['ID'] . "</td>";
	echo "<td>" . $row['nazwa'] . "</td>";
	echo "<td>" . $row['cena'] . "</td>";
	echo "</tr>";
  }
echo "</table>";
echo "<br>";

?>
</div>
</div>
</body>