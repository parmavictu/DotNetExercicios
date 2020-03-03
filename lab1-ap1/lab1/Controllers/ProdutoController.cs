using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.Model;
using Lab1.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace lab1.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository){
            this._produtoRepository = produtoRepository;
        }

        [HttpGet]
        public  ActionResult<IEnumerable<Produto>> GetAllProducts()
        {
            IList<Produto> products= _produtoRepository.GetAll();
            if(products.Count < 1 ) return NotFound();
            
            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(Guid id)
        {
            
            Produto produto = _produtoRepository.Get(id);
            if(produto == null) return NotFound();
            
            return Ok(produto);
             
        }
        [HttpPost]
        public ActionResult<Produto> AddProduct([FromBody] Produto produto)
        {
                _produtoRepository.Add(produto);
                return Created($"https://localhost:5001/api/produtos/{produto.Id}",produto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct( Guid id, [FromBody] Produto produto)
        {
            if(_produtoRepository.Get(id) == null) return NotFound();

            produto.Id = id;
            _produtoRepository.Update(produto);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(Guid id)
        {
            if(_produtoRepository.Get(id) == null) return NotFound();
            _produtoRepository.Remove(id);
            return NoContent();
        }
    }
}
