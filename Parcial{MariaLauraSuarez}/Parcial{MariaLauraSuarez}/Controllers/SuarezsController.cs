﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Parcial_MariaLauraSuarez_.Models;

namespace Parcial_MariaLauraSuarez_.Controllers
{
    public class SuarezsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Suarezs
        public IQueryable<Suarez> GetSuarezs()
        {
            return db.Suarezs;
        }

        // GET: api/Suarezs/5
        [ResponseType(typeof(Suarez))]
        public IHttpActionResult GetSuarez(string id)
        {
            Suarez suarez = db.Suarezs.Find(id);
            if (suarez == null)
            {
                return NotFound();
            }

            return Ok(suarez);
        }

        // PUT: api/Suarezs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSuarez(string id, Suarez suarez)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != suarez.name)
            {
                return BadRequest();
            }

            db.Entry(suarez).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuarezExists(id))
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

        // POST: api/Suarezs
        [ResponseType(typeof(Suarez))]
        public IHttpActionResult PostSuarez(Suarez suarez)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Suarezs.Add(suarez);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SuarezExists(suarez.name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = suarez.name }, suarez);
        }

        // DELETE: api/Suarezs/5
        [ResponseType(typeof(Suarez))]
        public IHttpActionResult DeleteSuarez(string id)
        {
            Suarez suarez = db.Suarezs.Find(id);
            if (suarez == null)
            {
                return NotFound();
            }

            db.Suarezs.Remove(suarez);
            db.SaveChanges();

            return Ok(suarez);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SuarezExists(string id)
        {
            return db.Suarezs.Count(e => e.name == id) > 0;
        }
    }
}