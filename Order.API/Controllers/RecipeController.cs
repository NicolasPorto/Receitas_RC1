using Microsoft.AspNetCore.Mvc;
using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.DataContract.Response.RecipeImage;
using Order.Application.Interfaces.Services;
using Order.Application.Messaging.Api;
using Order.Infra.Exceptions;

namespace Order.API.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeApplicationService _recipeApplicationService;

        public RecipeController(IRecipeApplicationService recipeApplicationService)
        {
            _recipeApplicationService = recipeApplicationService;
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<RecipeResponse>> SearchRecipeByCode(Guid recipeCode)
        {
            try
            {
                var response = await _recipeApplicationService.SearchRecipeByCode(recipeCode);

                if (response.Success)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpPost]
        public async Task<ActionResult<RecipeResponse>> RegisterRecipe(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.RegisterRecipe(request);

                if (response.Success)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpPut]
        public async Task<ActionResult<RecipeResponse>> ChangeRecipe(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.ChangeRecipe(request);

                if (response.Success)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult> DeleteRecipe(Guid recipeCode)
        {
            try
            {
                await _recipeApplicationService.DeleteRecipe(recipeCode);

                return Ok();
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpPost]
        public async Task<ActionResult> RegisterImageRecipe(RecipeImageRequest request)
        {
            try
            {
                await _recipeApplicationService.RegisterImage(request);

                return Ok();
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<RecipeImageResponse>> BuscarImagemReceitaByCodigo(Guid imageCode)
        {
            try
            {
                var response = await _recipeApplicationService.GetImageByCode(imageCode);

                if (response.Success)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult> DeleteRecipeImage(Guid imageCode)
        {
            try
            {
                await _recipeApplicationService.DeleteImagem(imageCode);

                return Ok();
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }
    }
}