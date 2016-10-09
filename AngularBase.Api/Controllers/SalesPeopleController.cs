using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngularBase.Data.AdventureWorks;
using Newtonsoft.Json;

namespace AngularBase.Api.Controllers
{
	public class SalesPeopleController : ApiController
	{
		private AdventureWorks db = new AdventureWorks();

		// GET: api/SalesPeople
		public IQueryable<SalesPerson> GetSalesPersons()
		{
			return db.SalesPersons;
		}

		// GET: api/SalesPeople/5
		[ResponseType(typeof(SalesPerson))]
		public IHttpActionResult GetSalesPerson(int id)
		{
			SalesPerson salesPerson = db.SalesPersons.Find(id);
			if (salesPerson == null)
			{
				return NotFound();
			}

			return Ok(salesPerson);
		}

		// PUT: api/SalesPeople/5
		[ResponseType(typeof(void))]
		public IHttpActionResult PutSalesPerson(int id, SalesPerson salesPerson)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != salesPerson.BusinessEntityID)
			{
				return BadRequest();
			}

			db.Entry(salesPerson).State = EntityState.Modified;

			try
			{
				db.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SalesPersonExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/SalesPeople
		[ResponseType(typeof(SalesPerson))]
		public IHttpActionResult PostSalesPerson(SalesPerson salesPerson)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			db.SalesPersons.Add(salesPerson);

			try
			{
				db.SaveChanges();
			}
			catch (DbUpdateException)
			{
				if (SalesPersonExists(salesPerson.BusinessEntityID))
				{
					return Conflict();
				}
				else
				{
					throw;
				}
			}

			return CreatedAtRoute("DefaultApi", new { id = salesPerson.BusinessEntityID }, salesPerson);
		}

		// DELETE: api/SalesPeople/5
		[ResponseType(typeof(SalesPerson))]
		public IHttpActionResult DeleteSalesPerson(int id)
		{
			SalesPerson salesPerson = db.SalesPersons.Find(id);
			if (salesPerson == null)
			{
				return NotFound();
			}

			db.SalesPersons.Remove(salesPerson);
			db.SaveChanges();

			return Ok(salesPerson);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}

		private bool SalesPersonExists(int id)
		{
			return db.SalesPersons.Count(e => e.BusinessEntityID == id) > 0;
		}
	}
}