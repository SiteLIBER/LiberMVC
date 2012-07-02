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
    public class AgendaController : Controller
    {
        private LiberDB db = new LiberDB();

        #region Repository
		private AgendaRepository rep;

		public AgendaController()
		{
			rep = new AgendaRepository();

		}
		#endregion 

        //
        // GET: /Agenda/

        public ViewResult Index()
        {
            return View(db.Agendas.ToList());
        }

        //
        // GET: /Agenda/Details/5

        public ViewResult Details(int id)
        {
            Agenda agenda = db.Agendas.Find(id);
            return View(agenda);
        }

        //
        // GET: /Agenda/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Agenda/Create

        [HttpPost]
        public ActionResult Create(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Agendas.Add(agenda);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(agenda);
        }
        
        //
        // GET: /Agenda/Edit/5
 
        public ActionResult Edit(int id)
        {
            Agenda agenda = db.Agendas.Find(id);
            return View(agenda);
        }

        //
        // POST: /Agenda/Edit/5

        [HttpPost]
        public ActionResult Edit(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agenda);
        }

        //
        // GET: /Agenda/Delete/5
 
        public ActionResult Delete(int id)
        {
            Agenda agenda = db.Agendas.Find(id);
            return View(agenda);
        }

        //
        // POST: /Agenda/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Agenda agenda = db.Agendas.Find(id);
            db.Agendas.Remove(agenda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        #region GET: /Agenda/AgendaHome
        public PartialViewResult AgendaHome()
        {
            var agendas = new PaginatedList<Agenda>(rep.AgendasPublicadas, 0, 7);
            //rep.Dispose();
            return PartialView("_AgendaHome", agendas);
        }
        #endregion


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}