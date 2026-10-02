using Auren.Api.Business.Finance.BankAccount.Command;
using Auren.Api.Business.Finance.BankAccount.Query;
using Auren.Api.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Auren.Api.App.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class BankAccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BankAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet($"/")]
        public async Task<ActionResult<List<BankAccountReponse?>>> GetAllBankAccountAsync()
        {
            var result = await _mediator.Send(new GetAllBankAccountQuery());

            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult<BankAccountReponse?>> CreateTaskAsync([FromBody] CreateBankAccountCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

    }
}