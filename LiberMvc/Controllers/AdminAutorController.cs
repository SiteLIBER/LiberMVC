using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.IO;

namespace LiberMvc.Controllers
{ 
	[Auth(Roles="Editor")]
    public class AdminAutorController : Controller
    {
        private LiberDB db = new LiberDB();

        //
        // GET: /AdminAutor/

        public ViewResult Index()
        {
            var autores = db.Autores.Include(a => a.Pessoa);
            return View(autores.ToList());
        }

        //
        // GET: /AdminAutor/Details/5

        public ViewResult Details(int id)
        {
            Autor autor = db.Autores.Find(id);
            return View(autor);
        }

        //
        // GET: /AdminAutor/Create

        public ActionResult Create()
        {
            ViewBag.PessoaID = new SelectList(db.Pessoas, "PessoaID", "Nome");
            return View();
        } 

        //
        // POST: /AdminAutor/Create

        [HttpPost]
        public ActionResult Create(Autor autor)
        {
            if (ModelState.IsValid)
            {
                string foto = UploadFiles();
                if (foto != null)
                {
                    autor.Foto = foto;
                }
                db.Autores.Add(autor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PessoaID = new SelectList(db.Pessoas, "PessoaID", "Nome", autor.PessoaID);
            return View(autor);
        }
        
        //
        // GET: /AdminAutor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Autor autor = db.Autores.Find(id);
            ViewBag.PessoaID = new SelectList(db.Pessoas, "PessoaID", "Nome", autor.PessoaID);
            return View(autor);
        }

        //
        // POST: /AdminAutor/Edit/5

        [HttpPost]
        public ActionResult Edit(Autor autor)
        {
            if (ModelState.IsValid)
            {
                string foto = UploadFiles();
                if (foto != null)
                {
                    autor.Foto = foto;
                }
                db.Entry(autor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PessoaID = new SelectList(db.Pessoas, "PessoaID", "Nome", autor.PessoaID);
            return View(autor);
        }

        //
        // GET: /AdminAutor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Autor autor = db.Autores.Find(id);
            return View(autor);
        }

        //
        // POST: /AdminAutor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Autor autor = db.Autores.Find(id);
            db.Autores.Remove(autor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        private string UploadFiles()
        {
            if (Request.Files != null)
            {
                foreach (string requestFile in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[requestFile];
                    if (file.ContentLength > 0)
                    {
                        string fileName = Path.GetFileName(file.FileName);
                        string directory = Server.MapPath("~/App_Data/uploads/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        string path = Path.Combine(directory, fileName);
                        file.SaveAs(path);
                        return path;
                    }
                }
            }
            return null;
        }



        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}