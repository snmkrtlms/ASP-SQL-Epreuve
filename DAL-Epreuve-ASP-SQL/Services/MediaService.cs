using DAL_Epreuve_ASP_SQL.Entities;
using DAL_Epreuve_ASP_SQL.Mappers;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve_ASP_SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_Epreuve_ASP_SQL.Services
{
    public class MediaService : BaseService, IMediaRepository<Media>
    {
        public MediaService(IConfiguration configuration) : base(configuration, "Epreuve-ASP-SQL")
        { }

        //Supprimer l'image qui correspond à l'Id_Produit
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Delete";
                    command.Parameters.AddWithValue("Id_Produit", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0) throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                }
            }
        }

        //Récupérer toutes les images
        public IEnumerable<Media> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Media]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMedia();
                        }
                    }
                }
            }

        }

        public Media Get(int id)
        {
            throw new NotImplementedException();
        }

        //Insérer une image dans produit
        public int Insert(Media entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Media_Insert";
                    command.Parameters.AddWithValue("Url", entity.Url);
                    command.Parameters.AddWithValue("Id_Produit", entity.Id_Produit);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Media entity)
        {
            throw new NotImplementedException();
        }
    }
}
