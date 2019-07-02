CREATE VIEW CoalBasic As(
	Select ID, CoalName, Amount, Price From CoalTypes 
	JOIN Stock ON CoalTypes.ID = Stock.CoalID
)