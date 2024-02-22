CREATE PROCEDURE [dbo].[SP_Panier_GetById]
	@Id_Panier INT
AS
	SELECT *
	FROM [Panier]
	WHERE [Id_Panier] = @Id_Panier