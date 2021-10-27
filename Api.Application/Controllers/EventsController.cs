
using Api.Domain.Dtos.Event;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route(template: "api/v1/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        private IEventService _service;
        private IUpLoadService _serviceUpload;
        public EventsController(IEventService service, IUpLoadService serviceUpload)
        {
            _service = service;
            _serviceUpload = serviceUpload;
        }

        // [Authorize("Bearer")]
        //[Authorize(Roles = "administrator")]
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

        [HttpGet]
        [Route("{int:skip}/{int:take}")]
        public async Task<ActionResult> GetAllPage([FromRoute] int skip, [FromRoute] int take)
        {
            try
            {
                return Ok(await _service.GetAllPage(skip, take));
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpGet("theme/{theme}")]
        public async Task<ActionResult> GetAllByTherm([FromRoute] string theme)
        {
            try
            {
                return Ok(await _service.GetAllByTheme(theme));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpGet]
        [Route("{id:guid}", Name = "GetEventWithId")]
        public async Task<ActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var result = await _service.GetEventById(id);
                if (result == null)
                {
                    return NotFound($"Pesquisa não obteve êxito com Id: {id}");
                }
                return Ok(await _service.GetEventById(id));

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //  [Authorize("Bearer")]
        [HttpPost("upload-image/{id:guid}")]
        public async Task<ActionResult> PostUpload([FromBody] EventUpdateDto events, [FromRoute] Guid id)
        {
            try
            {
                var result = await _service.GetEventById(id);
                if (result != null)
                {
                    var file = Request.Form.Files[0];
                    if (file.Length > 0)
                    {
                        _serviceUpload.DeleteImage(events.EventImage);
                    }
                }
                var EventReturn = await _service.Put(events);

                return Ok(EventReturn);
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //  [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EventCreateDto events)
        {
            try
            {
                var result = await _service.Post(events);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetEventWithId", new { id = result.Id })), result);
                }

                return BadRequest("Não foram encontrado valores");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //   [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] EventUpdateDto events)
        {
            try
            {
                var result = await _service.Put(events);
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
        public async Task<ActionResult> Delete([FromRoute] Guid id)
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


