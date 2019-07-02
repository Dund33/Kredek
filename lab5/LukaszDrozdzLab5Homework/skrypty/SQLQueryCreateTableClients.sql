CREATE TABLE Clients (
	ID int IDENTITY PRIMARY KEY NOT NULL,
	FirstName nvarchar(63) NOT NULL,
	LastName nvarchar(63) NOT NULL,
	Address nvarchar(127) NOT NULL,
	PESEL nvarchar(31) NOT NULL
)