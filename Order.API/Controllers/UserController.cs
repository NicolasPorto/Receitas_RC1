using Microsoft.AspNetCore.Mvc;
using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;
using Order.Application.Interfaces.Services;
using Order.Application.Messaging.Api;
using Order.Infra.Exceptions;

namespace Order.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplicationService _userApplicationService;

        public UserController(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }

        [HttpGet("{userCode}")]
        public async Task<ActionResult<UserResponse>> GetUserByCode(Guid userCode)
        {
            try
            {
                var response = await _userApplicationService.GetUserByCode(userCode);

                if (response.Success)
                    return Ok(response);

                return BadRequest(response);
            }
            catch (RCException ex)
            {
                return BadRequest(ResponseBase.ErrorHandled(ex));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBase.GenericError());
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserResponse>> CreateUser(UserRequest request)
        {
            try
            {
                var response = await _userApplicationService.CreateUser(request);

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
        public async Task<ActionResult<UserResponse>> UpdateUser(UserRequest request)
        {
            try
            {
                var response = await _userApplicationService.UpdateUser(request);

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

        [HttpDelete("{userCode}")]
        public async Task<ActionResult> DeleteUser(Guid userCode)
        {
            try
            {
                await _userApplicationService.DeleteUser(userCode);

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