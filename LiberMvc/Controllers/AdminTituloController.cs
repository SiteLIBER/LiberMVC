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
		[Auth(Roles = "Editor")]
    public class AdminTituloController : Controller
    {
        private LiberDB db = new LiberDB();

        //
        // GET: /AdminTitulo/

        public ViewResult Index()
        {
            return View(db.Titulos.ToList());
        }

        //
        // GET: /AdminTitulo/Details/5

        public ViewResult Details(int id)
        {
            Titulo titulo = db.Titulos.Find(id);
            return View(titulo);
        }

        //
        // GET: /AdminTitulo/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AdminTitulo/Create

        [HttpPost]
        public ActionResult Create(Titulo titulo)
        {
            if (ModelState.IsValid)
            {
                db.Titulos.Add(titulo);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(titulo);
        }
        
        //
        // GET: /AdminTitulo/Edit/5
 
        public ActionResult Edit(int id)
        {
            Titulo titulo = db.Titulos.Find(id);
            return View(titulo);
        }

        //
        // POST: /AdminTitulo/Edit/5

        [HttpPost]
        public ActionResult Edit(Titulo titulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titulo);
        }

        //
        // GET: /AdminTitulo/Delete/5
 
        public ActionResult Delete(int id)
        {
            Titulo titulo = db.Titulos.Find(id);
            return View(titulo);
        }

        //
        // POST: /AdminTitulo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Titulo titulo = db.Titulos.Find(id);
            db.Titulos.Remove(titulo);
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