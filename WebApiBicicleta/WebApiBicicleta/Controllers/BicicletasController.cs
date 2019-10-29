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
using WebApiBicicleta.Models;

namespace WebApiBicicleta.Controllers
{
    public class BicicletasController : ApiController
    {
        private BicicletaContext db = new BicicletaContext();

        // GET: api/Bicicletas
        public IQueryable<Bicicletas> GetBicicletas()
        {
            return db.Bicicletas;
        }

        // GET: api/Bicicletas/5
        [ResponseType(typeof(Bicicletas))]
        public IHttpActionResult GetBicicletas(int id)
        {
            Bicicletas bicicletas = db.Bicicletas.Find(id);
            if (bicicletas == null)
            {
                return NotFound();
            }

            return Ok(bicicletas);
        }

        // PUT: api/Bicicletas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBicicletas(int id, Bicicletas bicicletas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bicicletas.Id)
            {
                return BadRequest();
            }

            db.Entry(bicicletas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BicicletasExists(id))
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

        // POST: api/Bicicletas
        [ResponseType(typeof(Bicicletas))]
        public IHttpActionResult PostBicicletas(Bicicletas bicicletas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bicicletas.Add(bicicletas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bicicletas.Id }, bicicletas);
        }

        // DELETE: api/Bicicletas/5
        [ResponseType(typeof(Bicicletas))]
        public IHttpActionResult DeleteBicicletas(int id)
        {
            Bicicletas bicicletas = db.Bicicletas.Find(id);
            if (bicicletas == null)
            {
                return NotFound();
            }

            db.Bicicletas.Remove(bicicletas);
            db.SaveChanges();

            return Ok(bicicletas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BicicletasExists(int id)
        {
            return db.Bicicletas.Count(e => e.Id == id) > 0;
        }
    }
}