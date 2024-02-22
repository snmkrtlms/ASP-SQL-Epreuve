CREATE PROCEDURE [dbo].[SP_Panier_Insert]
	@Quantite INT,
	@Id_Commande INT,
	@Id_Produit INT
AS
	INSERT INTO [Panier] ([Quantite], [Id_Commande], [Id_Produit])
			OUTPUT [inserted].[Id_Panier]
	VALUES (@Quantite, @Id_Produit, @Id_Commande)