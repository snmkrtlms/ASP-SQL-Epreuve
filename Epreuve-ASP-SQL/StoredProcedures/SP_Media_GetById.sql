CREATE PROCEDURE [dbo].[SP_Media_GetById]
	@Id_Produit INT
AS
	SELECT *
	FROM [Media]
	WHERE [Id_Produit] = @Id_Produit
