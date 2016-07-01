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
        // GET: /Produtos/Detalhes/5

        public ViewResult Detalhes(System.Guid id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // GET: /Produtos/Criar

        public ActionResult Criar()
        {
            ViewBag.PossibleCategoriaProdutos = context.CategoriaProdutos;
            ViewBag.PossibleGrupoProdutos = context.GrupoProdutos;
            return View();
        } 

        //
        // POST: /Produtos/Criar

        [HttpPost]
        public ActionResult Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produto.ProdutoId = Guid.NewGuid();
                context.Produtos.Add(produto);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleCategoriaProdutos = context.CategoriaProdutos;
            ViewBag.PossibleGrupoProdutos = context.GrupoProdutos;
            return View(produto);
        }
        
        //
        // GET: /Produtos/Editar/5
 
        public ActionResult Editar(System.Guid id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            ViewBag.PossibleCategoriaProdutos = context.CategoriaProdutos;
            ViewBag.PossibleGrupoProdutos = context.GrupoProdutos;
            return View(produto);
        }

        //
        // POST: /Produtos/Editar/5

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Entry(produto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleCategoriaProdutos = context.CategoriaProdutos;
            ViewBag.PossibleGrupoProdutos = context.GrupoProdutos;
            return View(produto);
        }

        //
        // GET: /Produtos/Excluir/5
 
        public ActionResult Excluir(System.Guid id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // POST: /Produtos/Excluir/5

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmed(System.Guid id)
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