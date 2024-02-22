CREATE PROCEDURE [dbo].[SP_Produit_GetById]
	@Id_Produit INT
AS
	SELECT *
	FROM [Produit]
	WHERE [Id_Produit] = @Id_Produit
