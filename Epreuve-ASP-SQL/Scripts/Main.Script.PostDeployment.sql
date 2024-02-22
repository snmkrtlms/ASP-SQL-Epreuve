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
