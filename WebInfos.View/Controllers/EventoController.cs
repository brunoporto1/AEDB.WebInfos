using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebInfos.Model;
namespace WebInfos.View.Controllers
{
    public class EventoController : Controller
    {
        // Contexto
        InfosContext odb;
        public EventoController()
        {
            odb = new InfosContext();
        }

        // GET: NoticiaController
        public ActionResult Index()
        {
            List<TbEvento> oEve = odb.TbEvento.ToList();
            return View(oEve);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
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

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventoController/Edit/5
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

        // GET: EventoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventoController/Delete/5
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
