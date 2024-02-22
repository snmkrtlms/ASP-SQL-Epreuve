CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@Id_Produit INT,
	@Nom NVARCHAR(64),
	@Description NVARCHAR(max),
	@Prix DECIMAL,
	@CritereEco NVARCHAR(64),
	@Categorie NVARCHAR(64)
AS
	UPDATE [Produit] 
			SET [Nom] = @Nom,
				[Description] = @Description,
				[Prix] = @Prix,
				[CritereEco] = @CritereEco,
				[Categorie] = @Categorie
			WHERE [Id_Produit] = @Id_Produit