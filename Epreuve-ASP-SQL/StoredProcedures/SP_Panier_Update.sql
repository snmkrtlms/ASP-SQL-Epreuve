CREATE PROCEDURE [dbo].[SP_Panier_Update]
	@Id_Panier INT,
	@Quantite INT,
	@Id_Commande INT,
	@Id_Produit INT
AS
	UPDATE [Panier]
		SET [Quantite] = @Quantite,
			[Id_Commande] = @Id_Commande,
			[Id_Produit] = @Id_Produit
		WHERE [Id_Panier] = @Id_Panier