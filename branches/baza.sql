CREATE DATABASE baza CHARACTER SET utf8;

USE baza;

CREATE TABLE klienci(ID int, PRIMARY KEY(ID), imie varchar(15), nazwisko varchar(50), numer_kontakt int(10), adres varchar(50)) ENGINE=INNODB;

CREATE TABLE pracownicy(ID int, PRIMARY KEY(ID), login varchar(15), haslo varchar(15), imie varchar(15), nazwisko varchar(50), data_zatrudnienia date, data_zwolnienia date, posada int) ENGINE=INNODB;

CREATE TABLE naprawy(ID int, PRIMARY KEY(ID), VIN varchar(17), marka varchar(15), model varchar(30), rocznik int(4), termin_bad date,
termin_OC date, data_zgloszenia date,  czas_zgloszenia time, data_zakonczenia date, opis varchar(100), czas_pr int(10), ID_klienta int, FOREIGN KEY(ID_klienta) REFERENCES klienci(ID),
 ID_serwisanta int, FOREIGN KEY(ID_serwisanta) REFERENCES pracownicy(ID), cena int) ENGINE=INNODB;
 
 CREATE TABLE cennik(ID int, PRIMARY KEY(ID), nazwa varchar(100), cena int) ENGINE=INNODB;
 
 INSERT INTO klienci VALUES(1, "Jan", "Klient", "123456789", "ul.Przykladowa 1/1");
 
 INSERT INTO pracownicy VALUES(1, "serwisant1", "serwisant1", "Piotr", "Serwisant", '2010-02-15', null, 1);
 INSERT INTO pracownicy VALUES(2, "serwisant2", "serwisant2", "Jan", "Kowalski", '2010-02-15', null, 1);
 INSERT INTO pracownicy VALUES(3, "serwisant3", "serwisant3", "Krzysztof", "Poznañski", '2010-02-15', null, 1);
 INSERT INTO pracownicy VALUES(4, "kierownik", "kierownik", "Mateusz", "Kierownik", '2010-02-15', null, 0);
 
 INSERT INTO naprawy VALUES(1, "12345678901234567", "Suzuki", "DL 1000 V-Strom", "2003", '2012-03-20', '2012-11-20', '2012-03-20', '16:00', '2012-03-21', "Zosta³ wykonany przegl¹d techniczny", 5, 1, 1, 100);
 INSERT INTO naprawy VALUES(2, "12345678901234567", "Suzuki", "DL 1000 V-Strom", "2003", '2012-08-05', '2012-11-20', '2012-08-05', '17:00', '2012-08-08', "Zosta³ wwymieniony olej, klocki hamulcowe i filtr powietrza", 10, 1, 1, 140);
 INSERT INTO naprawy VALUES(3, "12345678901234567", "Suzuki", "DL 1000 V-Strom", "2003", '2012-03-20', '2012-11-20', '2012-03-20', '15:00', '2012-07-20', "Zosta³ wykonany przegl¹d techniczny", 5, 1, 2, 100);
 INSERT INTO naprawy VALUES(4, "12345678901234567", "Suzuki", "DL 1000 V-Strom", "2003", '2012-03-20', '2012-11-20', '2012-03-20', '17:00', '2012-10-25', "Zosta³ wykonany przegl¹d techniczny", 5, 1, 3, 100);
 
 INSERT INTO cennik VALUES(1, "Przegl¹d techniczny", 100); 
 INSERT INTO cennik VALUES(2, "GaŸniki: czyszczenie, regulacja, synchronizacja", 100); 
 INSERT INTO cennik VALUES(3, "Wymiana oleju z filtrem", 30); 
 INSERT INTO cennik VALUES(4, "Wymiana klocków hamulcowych", 70); 
 INSERT INTO cennik VALUES(5, "Wymiana filtra powietrza", 40); 