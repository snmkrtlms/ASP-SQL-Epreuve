CREATE PROCEDURE [dbo].[SP_Produit_GetByNom]
	@NomProduit NVARCHAR(64)
AS
	SELECT *
	FROM Produit
	 WHERE Nom LIKE LEFT(@NomProduit, 3) + '%'
