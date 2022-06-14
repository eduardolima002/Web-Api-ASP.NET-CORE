using APICatalogo1.Context;
using APICatalogo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly APICatalogoDBContext _context;

        public CategoriasController(APICatalogoDBContext context)
        {
            _context = context;
        }

        [HttpGet("Produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategiasEprodutos()
        {
            return _context.Categorias.Include(p => p.Produtos).AsNoTracking().Take(10).ToList();
        }

        [HttpGet("{id:int}", Name ="ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            if (categoria is null)
                return NotFound("Categoria não encontrada");

            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria is null)
                return BadRequest();

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return CreatedAtRoute("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Categoria> Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
                return BadRequest();

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            if (categoria is null)
            {
                return NotFound("Categoria não encontrada");
            }
            
            _context.Categorias.Remove(categoria);

            return Ok(categoria);
        }
    }
}
