
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;
namespace Controllers
{
    [Route("api/v1/TransactionType")]
    [ApiController]
    public class TransactionTypeController : ControllerBase
    {
        private readonly ITransactionTypeService _serv;

        public TransactionTypeController(ITransactionTypeService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult CreateTransactionType([FromBody] TransactionType inputs)
        {
            try
            {
                //inputs.Id = Guid.NewGuid();

                _serv.CreateTransactionType(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Create um novo TransactionType: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("{idTransactionType}")]
        public ActionResult GetTransactionType([FromRoute] Guid IdTransactionType)
        {
            try
            {
                var response = _serv.GetTransactionType(IdTransactionType);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Get o TransactionType {IdTransactionType}: {ex.Message}");
            }
        }

        [HttpGet]
        public ActionResult GetTransactionTypes()
        {
            try
            {
                var response = _serv.GetTransactionTypes();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao listar TransactionTypes: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult EditTransactionType([FromBody] TransactionType inputs)
        {
            try
            {
                _serv.EditTransactionType(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Edit o TransactionType {inputs.Id}: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("{idTransactionType}")]
        public ActionResult DeleteTransactionType([FromRoute] Guid IdTransactionType)
        {
            try
            {
                _serv.DeleteTransactionType(IdTransactionType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Delete o TransactionType {IdTransactionType}: {ex.Message}");
            }
        }
    }
}
