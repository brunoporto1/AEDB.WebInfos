using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebInfos.Model;

namespace WebInfos.View.Controllers
{
    public class NoticiaController : Controller
    {
        // Contexto
        InfosContext odb;
        public NoticiaController()
        {
            odb = new InfosContext();
        }

        // GET: NoticiaController
        public ActionResult Index()
        {
            List<TbNoticia> oNot = odb.TbNoticia.ToList();
            return View(oNot);
        }

        // GET: NoticiaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoticiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoticiaController/Create
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

        // GET: NoticiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoticiaController/Edit/5
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

        // GET: NoticiaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoticiaController/Delete/5
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
