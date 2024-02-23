CREATE PROCEDURE [dbo].[SP_Media_Delete]
	@Id_Produit INT
AS
	DELETE FROM [Media]
	WHERE [Id_Produit] = @Id_Produit
