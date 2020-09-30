
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;
namespace Controllers
{
    [Route("api/v1/Transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _serv;

        public TransactionController(ITransactionService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult CreateTransaction([FromBody] Transaction inputs)
        {
            try
            {
                //inputs.Id = Guid.NewGuid();

                _serv.CreateTransaction(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Create um novo Transaction: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("{idTransaction}")]
        public ActionResult GetTransaction([FromRoute] Guid IdTransaction)
        {
            try
            {
                var response = _serv.GetTransaction(IdTransaction);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Get o Transaction {IdTransaction}: {ex.Message}");
            }
        }

        [HttpGet]
        public ActionResult GetTransactions()
        {
            try
            {
                var response = _serv.GetTransactions();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao listar Transactions: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult EditTransaction([FromBody] Transaction inputs)
        {
            try
            {
                _serv.EditTransaction(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Edit o Transaction {inputs.Id}: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("{idTransaction}")]
        public ActionResult DeleteTransaction([FromRoute] Guid IdTransaction)
        {
            try
            {
                _serv.DeleteTransaction(IdTransaction);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Delete o Transaction {IdTransaction}: {ex.Message}");
            }
        }
    }
}
