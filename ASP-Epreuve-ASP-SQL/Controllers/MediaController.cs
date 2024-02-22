using ASP_Epreuve_ASP_SQL.Handlers;
using ASP_Epreuve_ASP_SQL.Models;
using BLL_Epreuve_ASP_SQL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve_ASP_SQL.Repositories;

namespace ASP_Epreuve_ASP_SQL.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaRepository<Media> _mediaRepository;
        public MediaController(IMediaRepository<Media> mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }
        // GET: MediaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MediaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MediaCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                int id = _mediaRepository.Insert(form.ToBLL());
                await form.Url.SaveFile();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaController/Edit/5
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

        // GET: MediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaController/Delete/5
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
