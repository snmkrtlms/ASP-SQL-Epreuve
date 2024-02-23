using Shared_Epreuve_ASP_SQL.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using ASP_Epreuve_ASP_SQL.Handlers;
using BLL = BLL_Epreuve_ASP_SQL;
using DAL = DAL_Epreuve_ASP_SQL;

namespace ASP_Epreuve_ASP_SQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                string[] supportedCultures = new string[]
                {
                    "en-Us",
                    "fr-Be"
                };
                string defaultCulture = supportedCultures[1];
                options.SetDefaultCulture(defaultCulture);
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Services Session
            builder.Services.AddHttpContextAccessor();  //Injection de dépendance du HttpContext dans le SessionManager (Handlers)
            builder.Services.AddScoped<CartSessionManager>();

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "AspNetMVC.Session";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromDays(1);
            });
            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;
            });
            #endregion
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

            app.UseSession(); 
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRequestLocalization();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}