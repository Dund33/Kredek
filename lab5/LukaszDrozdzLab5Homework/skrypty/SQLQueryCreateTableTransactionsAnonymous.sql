CREATE TABLE Transactions (
	ID int NOT NULL PRIMARY KEY IDENTITY,
	DocumentID nvarchar(63) NOT NULL,
	PESEL nvarchar(15) NOT NULL,
	CoalID int NOT NULL,
	AmountOfCoal float NOT NULL,
	Cost money NOT NULL,
	Tax money NOT NULL
	)