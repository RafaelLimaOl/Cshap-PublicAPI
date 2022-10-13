using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PublicApi.Interface;

namespace PublicApi.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {

        public readonly Endereco _cepService;

        public EnderecoController(Endereco cepService)
        {
            _cepService = cepService;
        }

        [HttpGet("/busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> BuscarEnderecoPorCEP([FromRoute] string cep)
        {
            var response = await _cepService.BuscarEndereco(cep);

            if (response.CodigoHttp == System.Net.HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
