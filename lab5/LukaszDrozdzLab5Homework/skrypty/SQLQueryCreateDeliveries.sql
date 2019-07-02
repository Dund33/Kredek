CREATE TABLE Deliveries(
	ID int PRIMARY KEY IDENTITY NOT NULL,
	CoalID int NOT NULL,
	AmountOfCoal float NOT NULL,
	Cost money NOT NULL,
	Tax money NOT NULL,
	DocumentID nvarchar(63) NOT NULL,
	Date date NOT NULL
)