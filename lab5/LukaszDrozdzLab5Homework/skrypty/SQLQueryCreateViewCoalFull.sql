CREATE VIEW CoalFull As(
	SELECT ID, CoalName, Amount, Price ,Wex, Wa, Wtr, Ar, Ad, Str, Std, Vdaf, Ri, Qir FROM CoalTypes JOIN CoalCertificates ON
	CoalTypes.ID = CoalCertificates.CoalID JOIN Stock ON Stock.CoalID = CoalTypes.ID
)
