using ASP_Epreuve_ASP_SQL.Handlers;
using ASP_Epreuve_ASP_SQL.Models;
using BLL_Epreuve_ASP_SQL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve_ASP_SQL.Repositories;

namespace ASP_Epreuve_ASP_SQL.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;
        private readonly IMediaRepository<Media> _mediaRepository;
        private readonly ICategorieRepository<Categorie> _categorieRepository;

        public ProduitController(IProduitRepository<Produit> produitRepository, IMediaRepository<Media> mediaRepository, ICategorieRepository<Categorie> categorieRepository)
        {
            _produitRepository = produitRepository;
            _mediaRepository = mediaRepository;
            _categorieRepository = categorieRepository;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());

            return View(model);
        }

        //Get Filtre Catégorie
        public ActionResult FiltreCategorie(string id)
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetByCategorie(id).Select(d => d.ToListItem());
            return View(model);
        }

        public ActionResult FiltreCritereEco(string id)
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetByCritereEco(id).Select(d => d.ToListItem());
            return View(model);
        }

        public ActionResult FiltreNomProduit(string id)
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.GetByNom(id).Select(d => d.ToListItem());
            return View(model);
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
        public async Task<ActionResult> Create(ProduitCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                int id = _produitRepository.Insert(form.ToBLL());
                await form.Medias.SaveFile();
                //Media media = Mapper.ToBLL(imagePath, id);
                //_mediaRepository.Insert(media);
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
        public async Task<ActionResult> Edit(int id, ProduitEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                _produitRepository.Update(form.ToBLL());
                await form.Medias.SaveFile();
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
