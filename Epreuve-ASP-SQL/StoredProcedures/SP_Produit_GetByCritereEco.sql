CREATE PROCEDURE [dbo].[SP_Produit_GetByCritereEco]
	@CritereEco NVARCHAR(64)
AS
	SELECT *
	FROM Produit
	WHERE CritereEco = @CritereEco