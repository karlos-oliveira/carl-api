
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;
namespace Controllers
{
    [Route("api/v1/Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _serv;

        public AccountController(IAccountService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult CreateAccount([FromBody] Account inputs)
        {
            try
            {
                //inputs.IdAccount = Guid.NewGuid();

                _serv.CreateAccount(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Create um novo Account: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("{idAccount}")]
        public ActionResult GetAccount([FromRoute] Guid IdAccount)
        {
            try
            {
                var response = _serv.GetAccount(IdAccount);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Get o Account {IdAccount}: {ex.Message}");
            }
        }

        [HttpGet]
        public ActionResult GetAccounts()
        {
            try
            {
                var response = _serv.GetAccounts();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao listar Accounts: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult EditAccount([FromBody] Account inputs)
        {
            try
            {
                _serv.EditAccount(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Edit o Account {inputs.Id}: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("{idAccount}")]
        public ActionResult DeleteAccount([FromRoute] Guid IdAccount)
        {
            try
            {
                _serv.DeleteAccount(IdAccount);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Delete o Account {IdAccount}: {ex.Message}");
            }
        }
    }
}
