using Shared_Epreuve_ASP_SQL.Repositories;
using BLL = BLL_Epreuve_ASP_SQL;
using DAL = DAL_Epreuve_ASP_SQL;

namespace ASP_Epreuve_ASP_SQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Services Produit
            builder.Services.AddScoped<IProduitRepository<BLL.Entities.Produit>, BLL.Services.ProduitService>();
            builder.Services.AddScoped<IProduitRepository<DAL.Entities.Produit>, DAL.Services.ProduitService>();
            #endregion

            #region Service CritereEco
            builder.Services.AddScoped<ICritereEcoRepository<BLL.Entities.CritereEco>, BLL.Services.CritereEcoService>();
            builder.Services.AddScoped<ICritereEcoRepository<DAL.Entities.CritereEco>, DAL.Services.CritereEcoService>();
            #endregion

            #region Service Categorie
            builder.Services.AddScoped<ICategorieRepository<BLL.Entities.Categorie>, BLL.Services.CategorieService>();
            builder.Services.AddScoped<ICategorieRepository<DAL.Entities.Categorie>, DAL.Services.CategorieService>();
            #endregion

            #region Service Media
            builder.Services.AddScoped<IMediaRepository<BLL.Entities.Media>, BLL.Services.MediaService>();
            builder.Services.AddScoped<IMediaRepository<DAL.Entities.Media>, DAL.Services.MediaService>();
            #endregion 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}