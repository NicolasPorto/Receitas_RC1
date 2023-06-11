using Microsoft.AspNetCore.Mvc;
using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.Interfaces.Services;
using Order.Domain.Messaging.Api;
using Order.Infra.Exceptions;

namespace Order.API.Controllers
{
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeApplicationService _recipeApplicationService;

        public RecipeController(IRecipeApplicationService recipeApplicationService)
        {
            _recipeApplicationService = recipeApplicationService;
        }

        // GET: RecipeController
        [HttpGet("{codigo}")]
        public async Task<ActionResult<RecipeResponse>> BuscarReceitaByCodigo(Guid codigoRecipe)
        {
            try
            {
                var response = await _recipeApplicationService.GetReceitaByCode(codigoRecipe);

                if (response.Sucesso)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException rcEx)
            {
                return BadRequest(ResponseBase.ErroTratado(rcEx));
            }
            catch (Exception)
            {
                return BadRequest(ResponseBase.ErroGenerico());
            }
        }

        [HttpPost]
        public async Task<ActionResult<RecipeResponse>> CadastrarReceita(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.CadastrarReceita(request);

                if (response.Sucesso)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException rcEx)
            {
                return BadRequest(ResponseBase.ErroTratado(rcEx));
            }
            catch (Exception)
            {
                return BadRequest(ResponseBase.ErroGenerico());
            }
        }

        [HttpPut]
        public async Task<ActionResult<RecipeResponse>> AlterarReceita(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.AlterarReceita(request);

                if (response.Sucesso)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException rcEx)
            {
                return BadRequest(ResponseBase.ErroTratado(rcEx));
            }
            catch (Exception)
            {
                return BadRequest(ResponseBase.ErroGenerico());
            }
        }

        [HttpDelete("{codigo}")]
        public async Task<ActionResult> DeletarUsuario(Guid codigoRecipe)
        {
            try
            {
                await _recipeApplicationService.DeletarReceita(codigoRecipe);

                return Ok();
            }
            catch (RCException rcEx)
            {
                return BadRequest(ResponseBase.ErroTratado(rcEx));
            }
            catch (Exception)
            {
                return BadRequest(ResponseBase.ErroGenerico());
            }
        }
    }
}
