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
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration) : base(configuration, "Epreuve-ASP-SQL")
        { }

        //Supprimer un produit à l'aide de son id
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Delete";
                    command.Parameters.AddWithValue("Id_Produit", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0) throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                }
            }
        }

        //Récupérer tous les produits
        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        //Récupérer le produit grâce à son id
        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetById";
                    command.Parameters.AddWithValue("Id_Produit", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} ne correspond à aucune valeur");
                    }
                }
            }
        }

        //Récupérer tous les produits d'une catégorie spécifiée
        public IEnumerable<Produit> GetByCategorie(string categorie)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByCategorie";
                    command.Parameters.AddWithValue("Categorie", categorie);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        //Récupérer tous les produits d'un critère spécifié
        public IEnumerable<Produit> GetByCritereEco(string critereEco)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByCritereEco";
                    command.Parameters.AddWithValue("CritereEco", critereEco);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        //Récupérer tous les produits du même nom (identiques au 3 premières lettres)
        public IEnumerable<Produit> GetByNom(string nomProduit)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByNom";
                    command.Parameters.AddWithValue("nomProduit", nomProduit);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        //Récupérer tous les produits populaires depuis Panier et Produit en fct de la somme totale de la quantité de chaque produit vendu
        //les résultats sont regroupés par produit et triés par la quantité totale vendue en ordre décroissant
        public IEnumerable<Produit> GetPopulaires()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Populaire";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        //Insérer le produit créé
        public int Insert(Produit entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Description", entity.Description);
                    command.Parameters.AddWithValue("Prix", entity.Prix);
                    command.Parameters.AddWithValue("CritereEco", entity.CritereEco);
                    command.Parameters.AddWithValue("Categorie", entity.Categorie);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        //Mettre à jour le produit
        public void Update(Produit entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.Parameters.AddWithValue("Id_Produit", entity.Id_Produit);
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Description", entity.Description);
                    command.Parameters.AddWithValue("Prix", entity.Prix);
                    command.Parameters.AddWithValue("CritereEco", entity.CritereEco);
                    command.Parameters.AddWithValue("Categorie", entity.Categorie);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0) throw new ArgumentOutOfRangeException(nameof(entity.Id_Produit), $"L'identifiant {entity.Id_Produit} ne correspond à aucune valeur");
                }
            }
        }


    }
}
