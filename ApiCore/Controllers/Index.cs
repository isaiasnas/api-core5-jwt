using ApiCore.Entidade;
using ApiCore.Servico;
using ApiCore.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiCore.Controllers
{
    [ApiController]
    [ApiVersion("1")]
   //[ApiExplorerSettings(GroupName = "v1")]
    [Route("api/v{version:apiVersion}/Account/")]
    //[Produces("application/json")]
    public class IndexController : Controller
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] LoginBase login)
        {
            ILogin user = ServicoLogin.Get(login.Email, login.Senha);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token =UtilBase.GenerateToken(user);
            return Ok(new
            {
                user = user,
                token = token
            });
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,admin")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "admin")]
        public string Manager() => "Gerente";

    }

    [ApiController]
    [ApiVersion("2")]
    //[ApiExplorerSettings(GroupName = "v2")]
    [Route("api/v{version:apiVersion}/Account/")]
    //[Produces("application/json")]
    public class Index2Controller : Controller
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";
    }
}
