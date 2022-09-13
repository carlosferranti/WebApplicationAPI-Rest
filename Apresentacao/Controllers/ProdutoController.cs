using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]   //[Route("api/[controller]")]    
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

		// GET api/values
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        public ActionResult<IEnumerable<Produto>> Get()
        {
            //return new string[] { "value1", "value2", "value3" };

            //return _repository.Queryable();

            return null; // _db.GetProdutos();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
    }
}
