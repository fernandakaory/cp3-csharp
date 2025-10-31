using CandidatosBusiness;
using CandidatosModel;
using Microsoft.AspNetCore.Mvc;
namespace CandidatosApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController
        (
        IFuncionarioService funcionarioService
    ) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = funcionarioService.ListarTodos();
            return Ok(funcionarios);
        }
    }
}
