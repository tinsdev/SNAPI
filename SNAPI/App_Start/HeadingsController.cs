using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using SNAPI.Models;

namespace SNAPI.App_Start
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HeadingsController : ApiController
    {
        private SNAPIContext db = new SNAPIContext();

        // GET: api/Headings
        public IQueryable<Heading> GetHeadings()
        {
            return db.Headings;
        }

        // GET: api/Headings/5
        [ResponseType(typeof(Heading))]
        public async Task<IHttpActionResult> GetHeading(int id)
        {
            Heading heading = await db.Headings.FindAsync(id);
            if (heading == null)
            {
                return NotFound();
            }

            return Ok(heading);
        }

        // PUT: api/Headings/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHeading(int id, Heading heading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != heading.Id)
            {
                return BadRequest();
            }

            db.Entry(heading).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeadingExists(id))
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

        // POST: api/Headings
        [ResponseType(typeof(Heading))]
        public async Task<IHttpActionResult> PostHeading(Heading heading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Headings.Add(heading);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = heading.Id }, heading);
        }

        // DELETE: api/Headings/5
        [ResponseType(typeof(Heading))]
        public async Task<IHttpActionResult> DeleteHeading(int id)
        {
            Heading heading = await db.Headings.FindAsync(id);
            if (heading == null)
            {
                return NotFound();
            }

            db.Headings.Remove(heading);
            await db.SaveChangesAsync();

            return Ok(heading);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HeadingExists(int id)
        {
            return db.Headings.Count(e => e.Id == id) > 0;
        }
    }
}