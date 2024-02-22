CREATE PROCEDURE [dbo].[SP_Media_Update]
	@ID_Media INT,
	@Url NVARCHAR(256),
	@Id_Produit INT
AS
	UPDATE [Media]
		SET [Url] = @Url,
			[Id_Produit] = @Id_Produit
		WHERE [Id_Media] = @Id_Media