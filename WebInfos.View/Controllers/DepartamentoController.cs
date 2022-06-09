using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebInfos.Model;
namespace WebInfos.View.Controllers
{
    public class DepartamentoController : Controller
    {
        // Contexto
        InfosContext odb;
        public DepartamentoController()
        {
            odb = new InfosContext();
        }

        // GET: Controller
        public ActionResult Index()
        {
            List<TbDepartamento> oDep = odb.TbDepartamento.ToList();
            return View(oDep);
        }

        // GET: Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(TbDepartamento oDep)
        {
            odb.TbDepartamento.Add(oDep);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Editar
        public ActionResult Editar(int id)
        {
            TbDepartamento oDep = odb.TbDepartamento.Find(id);
            return View(oDep);
        }

        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, TbDepartamento oDep)
        {
            var oDepBanco = odb.TbDepartamento.Find(id);
            oDepBanco.Departamento = oDep.Departamento;
            odb.Entry(oDepBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Deletar
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deletar
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
