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

        // Index
        public ActionResult Index()
        {
            List<TbFuncionario> oFunc = odb.TbFuncionario.ToList();
            return View(oFunc);
        }

        // GET: Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(TbFuncionario ooFunc)
        {
            odb.TbFuncionario.Add(ooFunc);
            odb.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Editar
        public ActionResult Editar(int id)
        {
            TbFuncionario ooFunc = odb.TbFuncionario.Find(id);
            return View(ooFunc);
        }

        // POST: Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, TbFuncionario ooFunc)
        {
            var oFuncBanco = odb.TbFuncionario.Find(id);
            oFuncBanco.Nome = ooFunc.Nome;
            oFuncBanco.Departamento = ooFunc.Departamento;
            oFuncBanco.Email = ooFunc.Email;
            oFuncBanco.Telefone = ooFunc.Telefone;
            odb.Entry(oFuncBanco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
