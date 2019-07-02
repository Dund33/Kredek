Create View TransactionFull As(
	Select CoalName, FirstName, LastName, Clients.PESEL ,AmountOfCoal, Cost, Tax, DocumentID
	FROM 
	Transactions 
	JOIN CoalBasic ON Transactions.CoalID = CoalBasic.ID 
	JOIN Clients ON Clients.PESEL = Transactions.PESEL
)