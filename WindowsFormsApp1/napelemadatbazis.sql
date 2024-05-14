DROP DATABASE IF EXISTS napelem;
CREATE DATABASE napelem;

DROP TABLE IF EXISTS Folyamatok;
DROP TABLE IF EXISTS Alkatreszek;
DROP TABLE IF EXISTS Projekt;
DROP TABLE IF EXISTS ProjektRaktar;
DROP TABLE IF EXISTS Raktar;
DROP TABLE IF EXISTS Megrendelo;
DROP TABLE IF EXISTS Felhasznalok;
DROP TABLE IF EXISTS Hianyzoalkatreszek;
DROP TABLE IF EXISTS Arkalkulacio;


CREATE TABLE Folyamatok
(
	Folyamat	VARCHAR(255) PRIMARY KEY,
	Leiras		TEXT NOT NULL
);

INSERT INTO Folyamatok(Folyamat, Leiras) VALUES
('New','A projekt létrehozásra került, de még nem történt meg a helyszíni felmérés.'),
('Draft','A helyszíni felmérés folyamatban van, a terv még nem került véglegesítésre'),
('Wait','A helyszíni felmérés megtörtént, de az árkalkulációt nem lehetett befejezni, mert volt olyan alkatrész, amely nincs a raktárban, így az ára nem ismert.'),
('Scheduled','Az árkalkuláció elkészült, a projekt a megvalósításra várakozik'),
('InProgress','A projekt megvalósítása megkezdődött, amelynek első lépése az alkatrészekraktárból való kivételezése.'),
('Completed','A projekt sikeresen megvalósult'),
('Failed','A projekt megvalósítása nem sikerült');

CREATE TABLE Felhasznalok
(
	FelhasznaloID	INT 		PRIMARY KEY 	AUTO_INCREMENT,
	Felhasznalonev	VARCHAR(255) 	UNIQUE 		NOT NULL,
	Jelszo		VARCHAR(255) 	NOT NULL,
	Beosztas	VARCHAR(255) 	NOT NULL
);

INSERT INTO Felhasznalok VALUES
(null, 'sfanni', '67ed8e80ce399188b15e9128b9777790ca6b6d1a63cb32d95a35f2a20d3ca00c', 'raktárvezető'),
(null, 'kbazsi', '564770c2311d2a4b7ebde018ccda04cc6a8310abb20af40847a72ae281bb954b', 'raktáros'),
(null, 'mbalint', '609773b69a4b62da915995a932d6cbe44fde7ff524f7cc707624c1c836638bb0', 'szakember'),
(null, 'tpeter', '9756d95070cf9904a1aec181975aab296d12928297f3d513c681a9e94f19c793', 'admin');

CREATE TABLE Alkatreszek 
(
	ANev		VARCHAR(255) 	PRIMARY KEY,
	Maxdb		FLOAT 		NOT NULL,
	Ar			FLOAT		NOT NULL,
	Statusz 	VARCHAR(50) 
);

CREATE TABLE Projekt
(
	ProjektKod	VARCHAR(255) 	PRIMARY KEY 	NOT NULL,
	Helyszin	VARCHAR(255) 	NOT NULL,
	Leiras		TEXT 		NOT NULL,
	Statusz		VARCHAR(255) 	NOT NULL
);

CREATE TABLE ProjektRaktar
(
	ProjektKod	VARCHAR(255),
	ANev		VARCHAR(255),
	SzDarab		FLOAT,

	FOREIGN KEY(ProjektKod) REFERENCES Projekt(ProjektKod),
	FOREIGN KEY(ANev) 	REFERENCES Alkatreszek(ANev),

	PRIMARY KEY (ProjektKod, ANev)
);

CREATE TABLE Raktar
(
	Rekesz		INT PRIMARY KEY,
	Sor		INT(255),
	Oszlop		INT(255),
	Polc		INT(255),
	Alkatresz	VARCHAR(255),
	Darab		FLOAT
);

CREATE TABLE Megrendelo
(
	MegrendeloID	VARCHAR(255) NOT NULL,
	ProjektKod	VARCHAR(255) NOT NULL, 
	MegrendeloNev	VARCHAR(255) NOT NULL,
	MegrendeloEmail	VARCHAR(255) NOT NULL,

	FOREIGN KEY(ProjektKod) REFERENCES Projekt(ProjektKod),
	
	PRIMARY KEY (ProjektKod, MegrendeloID)
);

CREATE TABLE Hianyzoalkatreszek
(
	hiany_nev 	VARCHAR(255) 		NOT NULL,
	hiany_db 	INT 			NOT NULL,
	hiany_ar 	INT 			NOT NULL,
	hiany_statusz 	VARCHAR(255) 		NOT NULL,
	FOREIGN KEY(hiany_nev) REFERENCES Alkatreszek(ANev)
);

CREATE TABLE Arkalkulacio(
	ProjectID VARCHAR(50) NOT NULL,
	Munkaora INT(255),
	Munkadij INT(255),
	NettoAr FLOAT(10, 2),
	
	FOREIGN KEY(ProjectID) REFERENCES Projekt(ProjektKod),
	PRIMARY KEY(ProjectID)
);

ALTER TABLE Hianyzoalkatreszek AUTO_INCREMENT = 1000;

ALTER TABLE projekt ADD FOREIGN KEY(Statusz) REFERENCES folyamatok(Folyamat);

ALTER TABLE raktar CHANGE Rekesz Rekesz INT AUTO_INCREMENT;
