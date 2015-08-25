<?php header('Content-Type: text/html; charset=utf-8'); ?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
	<link rel="Stylesheet" type="text/css" href="src/styl.css" >
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<title>System zarządzania serwisem motocyklowym</title>
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
</br>
<a href="cennik.php"></a>
</br>
<form method="POST" action="index.php" align="center">
	<div id="nawigacja">
		<input type="submit" name="cennik" value="Cennik" />
	</div>
</br><a>Podaj numer VIN pojazdu:  </a>
<INPUT TYPE = "Text" NAME = "VIN">
<input type="submit" name="Submit1" value="Zatwierdź" />
</form>
</br>
</br>
<div>
	<?PHP
		error_reporting(E_ERROR | E_WARNING | E_PARSE );
		if (isset($_POST['cennik']))
		{
			header('location:cennik.php');
		}
		if (isset($_POST['Submit1'])) {
		$connection = mysql_connect("localhost", "root");
		mysql_set_charset('utf8',$connection);
		if ($connection and mysql_select_db("baza")) { 
		$VIN = $_POST['VIN'];
		$wynik = mysql_query("SELECT ID, data_zgloszenia, czas_zgloszenia, opis, czas_pr FROM naprawy WHERE VIN='$VIN'") or die("Błąd w zapytaniu!"); 
		}
		else echo "Nie można połączyć się z bazą danych."; 
echo "<table border='1' cellpadding='5' rules='all' id='tabela'>
<tr>
<th>Id</th>
<th>Data</th>
<th>Godzina</th>
<th>Opis</th>
<th>Czas pracy [min]</th>
</tr>";

while($row = mysql_fetch_array($wynik))
  {
	echo "<tr>";
	echo "<td>" . $row['ID'] . "</td>";
	echo "<td>" . $row['data_zgloszenia'] . "</td>";
	echo "<td>" . $row['czas_zgloszenia'] . "</td>";
	echo "<td>" . $row['opis'] . "</td>";
	echo "<td>" . $row['czas_pr'] . "</td>";
	echo "</tr>";
  }
echo "</table>";
echo "<br>";
    }
	else print("");

?>
</div>
</div>
</div>
</body>
</html>