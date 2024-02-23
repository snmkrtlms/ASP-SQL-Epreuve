using ASP_Epreuve_ASP_SQL.Handlers;
using ASP_Epreuve_ASP_SQL.Models;
using BLL_Epreuve_ASP_SQL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve_ASP_SQL.Repositories;
using System.Reflection;

namespace ASP_Epreuve_ASP_SQL.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;
        private readonly ICategorieRepository<Categorie> _categorieRepository;
        private readonly IMediaRepository<Media> _mediaRepository;

        public ProduitController(IProduitRepository<Produit> produitRepository, ICategorieRepository<Categorie> categorieRepository, IMediaRepository<Media> mediaRepository)
        {
            _produitRepository = produitRepository;
            _categorieRepository = categorieRepository;
            _mediaRepository = mediaRepository;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            //Pas encore crée de commandes pour afficher la liste des produits populaires
            //IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetPopulaires().Select(d => d.ToListItem());
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());

            return View(model);
        }

        public ActionResult FiltreCategorie(string[] categoriesSelectionnees)
        {
            IEnumerable<ProduitListItemViewModel> model;

            if (categoriesSelectionnees != null && categoriesSelectionnees.Any())
            {
                // Filtre les produits par chaque catégorie sélectionnée
                var produitsFiltres = new List<ProduitListItemViewModel>();
                foreach (var nomCategorie in categoriesSelectionnees)
                {
                    var produitsCategorie = _produitRepository.GetByCategorie(nomCategorie);
                    produitsFiltres.AddRange(produitsCategorie.Select(p => p.ToListItem()));
                }
                model = produitsFiltres;
            }
            else
            {
                // Si aucune catégorie n'est sélectionnée, afficher tous les produits
                model = _produitRepository.Get().Select(p => p.ToListItem());
            }

            return View(model);
        }

        public ActionResult FiltreCritereEco(string[] criteresSelectionnes)
        {
            IEnumerable<ProduitListItemViewModel> model;

            if (criteresSelectionnes != null && criteresSelectionnes.Any())
            {
                // Filtre les produits par chaque critere sélectionné
                var critereFiltres = new List<ProduitListItemViewModel>();
                foreach (var nomCriteres in criteresSelectionnes)
                {
                    var produitsCriteresEco = _produitRepository.GetByCritereEco(nomCriteres);
                    critereFiltres.AddRange(produitsCriteresEco.Select(p => p.ToListItem()));
                }
                model = critereFiltres;
            }
            else
            {
                // Si aucun critere n'est sélectionné, afficher tous les produits
                model = _produitRepository.Get().Select(p => p.ToListItem());
            }

            return View(model);
        }

        public ActionResult FiltreNomProduit(string rechercheNom)
        {
            if (!string.IsNullOrEmpty(rechercheNom))
            {
                IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetByNom(rechercheNom).Select(d => d.ToListItem());
                return View(model);
            }
            else
            {
                // Si aucun terme de recherche n'est spécifié, afficher tous les produits
                IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
                return View(model);
            }
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            ProduitDetailsViewModel model = _produitRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProduitCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                int id = _produitRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            ProduitEditForm model = _produitRepository.Get(id).ToEditForm();
            return View(model);
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProduitEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                _produitRepository.Update(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
           ProduitDeleteViewModel model = _produitRepository.Get(id).ToDelete();
            if (model is null) throw new Exception();
            return View(model);
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProduitDeleteViewModel model)
        {
            try
            {
                _mediaRepository.Delete(id);
                _produitRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
