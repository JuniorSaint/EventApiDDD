using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Interfaces.Services;
using Api.Domain.Dtos.Lot;
using Microsoft.Extensions.Logging;

namespace Api.Application.Controllers
{
    [Route(template: "api/v1/[controller]")]
    [ApiController]
    public class LotsController : ControllerBase
    {
        private ILotService _service { get; set; }
        public LotsController(ILotService service)
        {
            _service = service;
        }



        // [Authorize("Bearer")]
        [HttpGet("{eventId}")]
        public async Task<ActionResult> GetAll([FromRoute] Guid eventId)
        {
            try
            {
                return Ok(await _service.GetLotByEvent(eventId));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        //  [Authorize("Bearer")]
        //[HttpPost]
        //public async Task<ActionResult> Post([FromBody] LotCreateDto lot)
        //{
        //    try
        //    {
        //        var result = await _service.Post(lot);
        //        if (result != null)
        //        {
        //            return Created(new Uri(Url.Link("GetLotById", new { id = result.Id })), result);
        //        }

        //        return BadRequest();
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}

        //   [Authorize("Bearer")]
        [HttpPut("{eventId}")]
        public async Task<ActionResult> Put([FromRoute] Guid eventId, [FromBody] LotUpdateDto[] lots)
        {
            try
            {
                var result = await _service.Put(eventId, lots);
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
        [HttpDelete("{eventId:guid}/{id:guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid eventId, [FromRoute] Guid id)
        {
            try
            {
                var result = await _service.GetLotByEventLot(eventId, id);
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
