CREATE PROCEDURE [dbo].[SP_Produit_Populaire]

AS
	SELECT p.*, SUM(pan.Quantite) AS Quantite_totale
	FROM Panier pan
	JOIN Produit p ON pan.Id_Produit = p.Id_Produit
	GROUP BY p.Id_Produit, p.Nom, p.[Description], p.Prix, p.CritereEco, p.Categorie
	ORDER BY SUM(pan.Quantite) DESC
