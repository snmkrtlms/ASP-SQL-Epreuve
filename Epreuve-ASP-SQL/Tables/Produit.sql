CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Nom] NVARCHAR(64) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Prix] DECIMAL(10, 2) NOT NULL, 
    [CritereEco] NVARCHAR(64) NOT NULL, 
    [Categorie] NVARCHAR(64) NOT NULL,

    CONSTRAINT [FK_Produit_CritereEco] FOREIGN KEY ([CritereEco]) REFERENCES [CritereEco]([Nom]),
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Categorie]) REFERENCES [Categorie]([Nom]),
    
    CONSTRAINT [CK_Produit_Prix] CHECK ([Prix] > 0)
)
