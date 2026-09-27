using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMuhasebeServer.Presentation.Abstraction
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
