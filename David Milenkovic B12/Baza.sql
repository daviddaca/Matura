CREATE TABLE TipKartice(
	TipKarticeID int PRIMARY KEY NOT NULL,
	Tip nvarchar(30) NOT NULL,
	Opis nvarchar(40) NOT NULL
);

CREATE TABLE Kartica(
	BrojKartice nchar(20) PRIMARY KEY NOT NULL,
	VaziDo date NOT NULL,
	TipID int FOREIGN KEY REFERENCES TipKartice(TipKarticeID)
);

ALTER TABLE PRETPLATNIK ADD BrojKartice nchar(20) FOREIGN KEY REFERENCES Kartica(BrojKartice) NOT NULL;

