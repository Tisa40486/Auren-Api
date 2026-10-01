using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairoApi.App.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TemplateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TemplateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet("/")]
        //public async Task<ActionResult<TemplateReponse?>> GetTemplateAsync()
        //{
        //    var result = await _mediator.Send(new TemplateGetQuery { });

        //    return Ok(result);
        //}

        //[HttpPost("create")]
        //public async Task<ActionResult<TemplateReponse?>> CreateTaskAsync([FromBody] TemplateCreateCommand command)
        //{
        //    await _mediator.Send(command);
        //    return Ok();
        //}

    }
}