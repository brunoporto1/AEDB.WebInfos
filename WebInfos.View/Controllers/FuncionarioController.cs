using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebInfos.Model;

namespace WebInfos.View.Controllers
{
    public class FuncionarioController : Controller
    {
        // Contexto
        InfosContext odb;
        public FuncionarioController()
        {
            odb = new InfosContext();
        }

        // GET: NoticiaController
        public ActionResult Index()
        {
            List<TbFuncionario> oFunc = odb.TbFuncionario.ToList();
            return View(oFunc);
        }

        // GET: FuncionarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuncionarioController/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: FuncionarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(TbFuncionario ooFunc)
        {
            odb.TbFuncionario.Add(ooFunc);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: FuncionarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FuncionarioController/Edit/5
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

        // GET: FuncionarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FuncionarioController/Delete/5
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
