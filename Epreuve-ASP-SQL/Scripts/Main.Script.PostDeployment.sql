/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


INSERT INTO [CritereEco]
        VALUES ('Réutilisable'),
               ('Recyclable'),
               ('Local'),
               ('Durable'),
               ('Sans plastique')
GO

INSERT INTO [Categorie]
        VALUES ('Soins & Beauté'),
               ('Papeterie'),
               ('Maison & Entretien'),
               ('Accesoires')
GO

EXEC SP_Produit_Insert 'Savon lait de chèvre & Avocat', 'Notre Savon au lait de chèvre BIO provient d’une fabrication traditionnelle belge', 5, 'Local', 'Soins & Beauté';
EXEC SP_Produit_Insert 'Masque Peeling doux', 'Exfoliez, hydratez et illuminez votre peau avec le Masque peeling doux ',15, 'Local', 'Soins & Beauté';
EXEC SP_Produit_Insert 'Brosse à vaiselle', 'Sans plastique et zéro-déchet, la brosse vaisselle en bois est l’alternative éco-responsable aux brosses en plastique et aux éponges jetables', 5, 'Durable', 'Maison & Entretien';


EXEC SP_Media_Insert 'savon.jpg',1;
EXEC SP_Media_Insert 'masque.jpg',2;
EXEC SP_Media_Insert 'vaisselle.jpg',3;