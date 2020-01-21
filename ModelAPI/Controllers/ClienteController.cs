using ModelAPI.Contracts;
using ModelAPI.Data;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ModelFirstApplication.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        public IRepositoryCliente _repository;

        public ClienteController(IRepositoryCliente repository)
        {
            _repository = repository;
        }

        // GET: api/Cliente
        [Route()]
        public IHttpActionResult Get()
        {
            var x = _repository.GetAll();
            return Ok(x);
        }

        // GET: api/Cliente/5
        public IHttpActionResult Get(int id)
        {
            var client = _repository.GetById(id);
            return Ok(client);
        }

        // POST: api/Cliente
        [HttpPost]
        [Route()]
        public IHttpActionResult Post(Cliente obj)
        {
            _repository.Insert(obj);
            _repository.Commit();
            return Created(new Uri(Request.RequestUri.AbsoluteUri), obj);
        }

        // PUT: api/Cliente/5
        [HttpPut]
        [Route()]
        public IHttpActionResult Put(Cliente obj)
        {
            _repository.Update(obj);
            _repository.Commit();

            return Ok(obj);
        }

        // DELETE: api/Cliente/5
        [HttpDelete]
        [Route()]
        public IHttpActionResult Delete(int id)
        {
            _repository.Delete(id);
            _repository.Commit();
            return Ok();
        }
    }
}
