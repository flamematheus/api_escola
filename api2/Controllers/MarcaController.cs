using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {

        // O garçom guarda o cardápio (o acesso à cozinha).
        private readonly IMarcaRepository _cursoRepository;

        // Injeção de dependência: a API entrega o CursoRepository
        // (por causa do AddScoped do passo 11).
        public CursoController(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        // GET api/curso
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_cursoRepository.ListarTodos());   // 200 + lista em JSON
        }
    }
}