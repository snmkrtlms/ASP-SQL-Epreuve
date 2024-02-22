CREATE TABLE [dbo].[Panier]
(
	[Id_Panier] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Quantite] INT NOT NULL,
    [Id_Commande] INT NOT NULL,
    [Id_Produit] INT NOT NULL

    CONSTRAINT [FK_Panier_Commande] FOREIGN KEY ([Id_Commande]) REFERENCES [Commande]([Id_Commande]),
    CONSTRAINT [FK_Panier_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit]),
    CONSTRAINT [CK_Panier_Quantite] CHECK ([Quantite] >= 0)
)
