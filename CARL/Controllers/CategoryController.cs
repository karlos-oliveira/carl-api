
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using System;
namespace Controllers
{
    [Route("api/v1/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _serv;

        public CategoryController(ICategoryService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult CreateCategory([FromBody] Category inputs)
        {
            try
            {
                //inputs.IdCategory = Guid.NewGuid();

                _serv.CreateCategory(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Create um novo Category: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("{idCategory}")]
        public ActionResult GetCategory([FromRoute] Guid IdCategory)
        {
            try
            {
                var response = _serv.GetCategory(IdCategory);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Get o Category {IdCategory}: {ex.Message}");
            }
        }

        [HttpGet]
        public ActionResult GetCategorys()
        {
            try
            {
                var response = _serv.GetCategorys();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao listar Categorys: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult EditCategory([FromBody] Category inputs)
        {
            try
            {
                _serv.EditCategory(inputs);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Edit o Category {inputs.Id}: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("{idCategory}")]
        public ActionResult DeleteCategory([FromRoute] Guid IdCategory)
        {
            try
            {
                _serv.DeleteCategory(IdCategory);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu um erro ao Delete o Category {IdCategory}: {ex.Message}");
            }
        }
    }
}
