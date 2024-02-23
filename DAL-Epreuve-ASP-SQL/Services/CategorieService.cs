using DAL_Epreuve_ASP_SQL.Entities;
using DAL_Epreuve_ASP_SQL.Mappers;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve_ASP_SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_Epreuve_ASP_SQL.Services
{
    public class CategorieService : BaseService, ICategorieRepository<Categorie>
    {
        public CategorieService(IConfiguration configuration) : base(configuration, "Epreuve-ASP-SQL")
        { }

        //Récupérer toutes les catégories
        public IEnumerable<Categorie> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Categorie]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategorie();
                        }
                    }
                }
            }
        }
    }
}
