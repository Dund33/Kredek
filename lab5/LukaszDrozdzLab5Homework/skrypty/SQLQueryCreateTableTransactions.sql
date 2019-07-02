Create Table Transactions (
	ID int PRIMARY KEY IDENTITY,
	PESEL nvarchar(31) NOT NULL,
	CoalID int NOT NULL,
	AmountOfCoal float NOT NULL,
	Cost money NOT NULL,
	Tax money NOT NULL,
	DocumentID int NOT NULL
)