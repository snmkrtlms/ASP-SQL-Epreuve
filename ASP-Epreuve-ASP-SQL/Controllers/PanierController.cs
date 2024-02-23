using ASP_Epreuve_ASP_SQL.Handlers;
using ASP_Epreuve_ASP_SQL.Models;
using BLL_Epreuve_ASP_SQL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve_ASP_SQL.Repositories;

namespace ASP_Epreuve_ASP_SQL.Controllers
{
    public class PanierController : Controller
    {
        private readonly IPanierRepository<Panier> _panierRepository;
        
        public PanierController(IPanierRepository<Panier> panierRepository)
        {
            _panierRepository = panierRepository;
        }

        // GET: PanierController
        //public ActionResult Index()
        //{
        //    IEnumerable<PanierListItemViewModel> model = _panierRepository.Get().Select(d => d.ToListItem());
        //    return View(model);
        //}

        // GET: PanierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PanierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PanierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PanierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PanierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PanierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PanierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
