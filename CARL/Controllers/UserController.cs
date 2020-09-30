
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;
namespace Controllers
{
    [Route("api/v1/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _serv;

        public UserController(IUserService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult CreateUser([FromBody] User inputs)
        {
            try
            {
                //inputs.Id = Guid.NewGuid();

                _serv.CreateUser(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Create um novo User: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("{idUser}")]
        public ActionResult GetUser([FromRoute] Guid IdUser)
        {
            try
            {
                var response = _serv.GetUser(IdUser);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Get o User {IdUser}: {ex.Message}");
            }
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            try
            {
                var response = _serv.GetUsers();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao listar Users: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult EditUser([FromBody] User inputs)
        {
            try
            {
                _serv.EditUser(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Edit o User {inputs.Id}: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("{idUser}")]
        public ActionResult DeleteUser([FromRoute] Guid IdUser)
        {
            try
            {
                _serv.DeleteUser(IdUser);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Delete o User {IdUser}: {ex.Message}");
            }
        }
    }
}
