using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PublicApi.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace PublicApi.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {

        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Buscar([RegularExpressionAttribute("^[0-9]*$")] string codigoBanco)
        {
            var response = await _bancoService.BuscarBanco(codigoBanco);

            if (response.CodigoHttp == HttpStatusCode.OK)
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
