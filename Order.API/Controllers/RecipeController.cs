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
        private readonly IRecipeImageApplicationService _recipeImageApplicationService;

        public RecipeController(IRecipeApplicationService recipeApplicationService, IRecipeImageApplicationService recipeImageApplicationService)
        {
            _recipeApplicationService = recipeApplicationService;
            _recipeImageApplicationService = recipeImageApplicationService;
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<RecipeResponse>> GetRecipeByCode(Guid recipeCode)
        {
            try
            {
                var response = await _recipeApplicationService.GetRecipeByCode(recipeCode);

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
        public async Task<ActionResult<RecipeResponse>> CreateRecipe(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.CreateRecipe(request);

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
        public async Task<ActionResult<RecipeResponse>> UpdateRecipe(RecipeRequest request)
        {
            try
            {
                var response = await _recipeApplicationService.UpdateRecipe(request);

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

        [HttpPost("Image")]
        public async Task<ActionResult> CreateImageRecipe(RecipeImageRequest request)
        {
            try
            {
                await _recipeImageApplicationService.CreateImageRecipe(request);

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

        [HttpGet("Image/{code}")]
        public async Task<ActionResult<RecipeImageResponse>> GetImageByCode(Guid imageCode)
        {
            try
            {
                var response = await _recipeImageApplicationService.GetImageByCode(imageCode);

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

        [HttpDelete("Image/{code}")]
        public async Task<ActionResult> DeleteRecipeImage(Guid imageCode)
        {
            try
            {
                await _recipeImageApplicationService.DeleteImagem(imageCode);

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