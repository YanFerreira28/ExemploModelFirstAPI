using ModelAPI.Contracts;
using ModelAPI.Data;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ModelAPI.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {

        public IRepositoryProduto _repositoryProd;

        public ProdutoController(IRepositoryProduto repositoryProduto)
        {
            _repositoryProd = repositoryProduto;
        }

        // GET: api/Produto
        [Route()]
        public IHttpActionResult Get()
        {
            var prod = _repositoryProd.GetAll();
            return Ok(prod);
        }

        // GET: api/Produto/5
        [Route()]
        public IHttpActionResult Get(int id)
        {
            var prod = _repositoryProd.GetById(id);
            return Ok(prod);
        }

        // POST: api/Produto
        [HttpPost]
        [Route()]
        public IHttpActionResult Post(Produto obj)
        {
            _repositoryProd.Insert(obj);
            _repositoryProd.Commit();

            return Created(new Uri(Request.RequestUri.AbsoluteUri), obj);
        }

        // PUT: api/Produto/5
        [HttpPut]
        [Route()]
        public IHttpActionResult Put(Produto obj)
        {
            _repositoryProd.Update(obj);
            _repositoryProd.Commit();
            return Ok(obj);
        }

        // DELETE: api/Produto/5
        [HttpDelete]
        [Route()]
        public IHttpActionResult Delete(int id)
        {
            _repositoryProd.Delete(id);
            _repositoryProd.Commit();
            return Ok();
        }
    }
}
