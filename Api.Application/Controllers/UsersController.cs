using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service { get; set; }
        public UsersController(IUserService service)
        {
            _service = service;
        }

        // [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpGet]
        [Route("{id:guid}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound($"Pesquisa não obteve êxito com Id: {id}");
                }
                return Ok(await _service.Get(id));

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        //  [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserCreateDto category)
        {
            try
            {
                var result = await _service.Post(category);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetById", new { id = result.Id })), result);
                }

                return BadRequest();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //   [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UserUpdateDto user)
        {
            try
            {
                var result = await _service.Put(user);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest("Dados não foram atualizados");
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //   [Authorize("Bearer")]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound($"Deleção não obteve êxito com Id: {id}");
                }
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
