CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@Nom NVARCHAR(64),
	@Description NVARCHAR(max),
	@Prix DECIMAL,
	@CritereEco NVARCHAR(64),
	@Categorie NVARCHAR(64)
AS
	INSERT INTO [Produit] ([Nom], [Description], [Prix], [CritereEco], [Categorie])
			OUTPUT [inserted].[Id_Produit]
	VALUES (@Nom, @Description, @Prix, @CritereEco, @Categorie)
