using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingCraft_02.Models;

namespace CodingCraft_02.Controllers
{   
    public class CategoriaProdutosController : Controller
    {
        private CodingCraft02Context context = new CodingCraft02Context();

        //
        // GET: /CategoriaProdutos/

        public ViewResult Index()
        {
            return View(context.CategoriaProdutos.Include(categoriaproduto => categoriaproduto.Produto).ToList());
        }

        //
        // GET: /CategoriaProdutos/Detalhes/5

        public ViewResult Detalhes(System.Guid id)
        {
            CategoriaProduto categoriaproduto = context.CategoriaProdutos.Single(x => x.CategoriaProdutoId == id);
            return View(categoriaproduto);
        }

        //
        // GET: /CategoriaProdutos/Criar

        public ActionResult Criar()
        {
            return View();
        } 

        //
        // POST: /CategoriaProdutos/Criar

        [HttpPost]
        public ActionResult Criar(CategoriaProduto categoriaproduto)
        {
            if (ModelState.IsValid)
            {
                categoriaproduto.CategoriaProdutoId = Guid.NewGuid();
                context.CategoriaProdutos.Add(categoriaproduto);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(categoriaproduto);
        }
        
        //
        // GET: /CategoriaProdutos/Editar/5
 
        public ActionResult Editar(System.Guid id)
        {
            CategoriaProduto categoriaproduto = context.CategoriaProdutos.Single(x => x.CategoriaProdutoId == id);
            return View(categoriaproduto);
        }

        //
        // POST: /CategoriaProdutos/Editar/5

        [HttpPost]
        public ActionResult Editar(CategoriaProduto categoriaproduto)
        {
            if (ModelState.IsValid)
            {
                context.Entry(categoriaproduto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaproduto);
        }

        //
        // GET: /CategoriaProdutos/Excluir/5
 
        public ActionResult Excluir(System.Guid id)
        {
            CategoriaProduto categoriaproduto = context.CategoriaProdutos.Single(x => x.CategoriaProdutoId == id);
            return View(categoriaproduto);
        }

        //
        // POST: /CategoriaProdutos/Excluir/5

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmed(System.Guid id)
        {
            CategoriaProduto categoriaproduto = context.CategoriaProdutos.Single(x => x.CategoriaProdutoId == id);
            context.CategoriaProdutos.Remove(categoriaproduto);
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