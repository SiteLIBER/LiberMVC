using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;

namespace LiberMvc.Controllers
{ 
    public class AdminPostagemController : Controller
    {
        private LiberDB db = new LiberDB();

        //
        // GET: /AdminPostagem/

        public ViewResult Index()
        {
            var postagens = db.Postagens.Include(p => p.TipoPostagem);
            return View(postagens.ToList());
        }

        //
        // GET: /AdminPostagem/Details/5

        public ViewResult Details(int id)
        {
            Postagem postagem = db.Postagens.Find(id);
            return View(postagem);
        }

        //
        // GET: /AdminPostagem/Create

        public ActionResult Create()
        {
            ViewBag.TipoPostagemID = new SelectList(db.TiposPostagem, "TipoPostagemID", "Descricao");
            return View();
        } 

        //
        // POST: /AdminPostagem/Create

        [HttpPost]
        public ActionResult Create(Postagem postagem)
        {
            if (ModelState.IsValid)
            {
                db.Postagens.Add(postagem);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.TipoPostagemID = new SelectList(db.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
            return View(postagem);
        }
        
        //
        // GET: /AdminPostagem/Edit/5
 
        public ActionResult Edit(int id)
        {
            Postagem postagem = db.Postagens.Find(id);
            ViewBag.TipoPostagemID = new SelectList(db.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
            return View(postagem);
        }

        //
        // POST: /AdminPostagem/Edit/5

        [HttpPost]
        public ActionResult Edit(Postagem postagem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postagem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoPostagemID = new SelectList(db.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
            return View(postagem);
        }

        //
        // GET: /AdminPostagem/Delete/5
 
        public ActionResult Delete(int id)
        {
            Postagem postagem = db.Postagens.Find(id);
            return View(postagem);
        }

        //
        // POST: /AdminPostagem/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Postagem postagem = db.Postagens.Find(id);
            db.Postagens.Remove(postagem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}