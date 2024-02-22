using DAL_Epreuve_ASP_SQL.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve_ASP_SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DAL_Epreuve_ASP_SQL.Mappers;

namespace DAL_Epreuve_ASP_SQL.Services
{
    public class CritereEcoService : BaseService, ICritereEcoRepository<CritereEco>
    {
        public CritereEcoService(IConfiguration configuration) : base(configuration, "Epreuve-ASP-SQL")
        { }

        public IEnumerable<CritereEco> Get()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [CritereEco]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCritereEco();
                        }
                    }
                }
            }
        }
    }
}
