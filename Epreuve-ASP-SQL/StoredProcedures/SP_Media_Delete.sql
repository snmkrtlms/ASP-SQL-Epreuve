CREATE PROCEDURE [dbo].[SP_Media_Delete]
	@Id_Media INT
AS
	DELETE FROM [Media]
	WHERE [Id_Media] = @Id_Media
