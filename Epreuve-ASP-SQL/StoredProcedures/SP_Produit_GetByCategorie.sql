CREATE PROCEDURE [dbo].[SP_Produit_GetByCategorie]
	@Categorie NVARCHAR(64)
AS
	SELECT * 
	FROM Produit
	WHERE Categorie = @Categorie
