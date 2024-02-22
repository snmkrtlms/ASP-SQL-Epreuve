CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@Url NVARCHAR(256),
	@Id_Produit INT
AS
	INSERT INTO [Media] ([Url], [Id_Produit])
			OUTPUT [inserted].[Id_Media]
	VALUES (@Url, @Id_Produit)