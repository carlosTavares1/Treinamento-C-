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
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecoesController : ApiController
    {
        private EnderecoContext db = new EnderecoContext();

        // GET: api/Enderecoes
        public IQueryable<Endereco> GetGetEnderecos()
        {
            return db.GetEnderecos;
        }

        // GET: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.GetEnderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        [HttpGet]
        [Route("api/Enderecoes/{cep}/Info")]
        public IQueryable<Endereco> EnderecosPorCep (string cep)
        {
            return db.GetEnderecos.Where(x => x.Cep == cep);
        }

        [HttpGet]
        [Route("api/Enderecoes/{bairro}/InfoByBairro")]
        public IQueryable<Endereco> EnderecosPorBairro(string bairro)
        {
            return db.GetEnderecos.Where(x => x.Bairro == bairro);
        }

        [HttpGet]
        [Route("api/Enderecoes/{logradouro}/InfoByLogradouro")]
        public IQueryable<Endereco> EnderecosPorLogradouro(string logradouro)
        {
            return db.GetEnderecos.Where(x => x.Logradouro == logradouro);
        }

        [HttpGet]
        [Route("api/Enderecoes/{uf}/InfoByUf")]
        public IQueryable<Endereco> EnderecosPorUf(string uf)
        {
            return db.GetEnderecos.Where(x => x.Uf == uf);
        }

        [HttpGet]
        [Route("api/Enderecoes/{municipio}/InfoByMunicipio")]
        public IQueryable<Endereco> EnderecosPorMunicipio(string municipio)
        {
            return db.GetEnderecos.Where(x => x.Municipio == municipio);
        }

        [HttpGet]
        [Route("api/Enderecoes/{complemento}/InfoByComplemento")]
        public IQueryable<Endereco> EnderecosPorComplemento(string complemento)
        {
            return db.GetEnderecos.Where(x => x.Complemento == complemento);
        }

        // PUT: api/Enderecoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Alteração realizada com sucesso");
            //HttpStatusCode.NoContent
        }

        // POST: api/Enderecoes
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GetEnderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.GetEnderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.GetEnderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.GetEnderecos.Count(e => e.Id == id) > 0;
        }
    }
}