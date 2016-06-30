using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CodingCraft_02.Models;

namespace CodingCraft_02.Controllers
{
    public class ProdutosController : Controller
    {
        private CodingCraft02Context context = new CodingCraft02Context();

        //
        // GET: /Produtos/

        public ViewResult Index()
        {
            return View(context.Produtos.ToList());
        }

        //
        // GET: /Produtos/Details/5

        public ViewResult Detalhes(long id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // GET: /Produtos/Create

        public ActionResult Criar()
        {
            return View();
        } 

        //
        // POST: /Produtos/Create

        [HttpPost]
        public ActionResult Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(produto);
        }
        
        //
        // GET: /Produtos/Edit/5
 
        public ActionResult Editar(long id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // POST: /Produtos/Edit/5

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Entry(produto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        //
        // GET: /Produtos/Delete/5
 
        public ActionResult Excluir(long id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // POST: /Produtos/Delete/5

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmed(long id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}