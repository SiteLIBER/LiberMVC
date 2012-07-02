using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.Entity;

namespace LiberMvc.Models
{
	public class AgendaRepository
	{

		#region Database

		public LiberDB db;
		public AgendaRepository() : this(new LiberDB()) { }
        public AgendaRepository(LiberDB context)
		{ 
		  db = context;
		}

		#endregion

		#region Agenda
		public IQueryable<Agenda> Agendas
		{
			get
			{
				return db.Agendas;
			}
		}
		public IQueryable<Agenda> AgendasPublicadas
		{
			get { return Agendas
                    .OrderByDescending(a => a.DataInicio);
                }
		}

		public Agenda GetPostagem(int id)
		{
			return db.Agendas.SingleOrDefault(a => a.AgendaID == id);
		}

		#endregion

		#region Insert/Edit/Delete Methods

		public void Add(Agenda agenda)
		{
			db.Agendas.Add(agenda);
		}

		public void Edit(Agenda agenda)
		{
			db.Entry(agenda).State = EntityState.Modified;
		}

		public void Delete(Agenda agenda)
		{
			db.Agendas.Remove(agenda);
		}


		#endregion

		#region Persistence

		public void Save()
		{
			db.SaveChanges();
		}

		#endregion

		#region Free Memory

		public void Dispose()
		{ 
			if (db != null)
				db.Dispose();
		}

		#endregion

	}
}