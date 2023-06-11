using Microsoft.AspNetCore.Mvc;
using Order.Application.DataContract.Request.User;
using Order.Application.DataContract.Response.User;
using Order.Application.Interfaces.Services;
using Order.Domain.Messaging.Api;
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

        [HttpGet("{codigo}")]
        public async Task<ActionResult<UserResponse>> BuscarUsuarioByCodigo(Guid codigoUser) 
        {
            try
            {
                var response = await _userApplicationService.GetUsuarioByCode(codigoUser);

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
        public async Task<ActionResult<UserResponse>> CadastrarUsuario(UserRequest request)
        {
            try
            {
                var response = await _userApplicationService.CadastrarUsuario(request);

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
        public async Task<ActionResult<UserResponse>> AlterarUsuario(UserRequest request)
        {
            try
            {
                var response = await _userApplicationService.AlterarUsuario(request);

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
        public async Task<ActionResult> DeletarUsuario(Guid codigoUser) 
        {
            try
            {
                await _userApplicationService.DeletarUsuario(codigoUser);

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