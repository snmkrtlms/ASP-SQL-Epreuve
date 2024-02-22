CREATE PROCEDURE [dbo].[SP_Panier_Delete]
	@Id_Panier INT
AS
	DELETE FROM [Panier]
			WHERE [Id_Panier] = @Id_Panier