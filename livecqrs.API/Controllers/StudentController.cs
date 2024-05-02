using livecqrs.Application.Queries.GetStudents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace livecqrs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var getStudentsQuery = new GetStudentsQuery();

            var result = await _mediator.Send(getStudentsQuery);

            return Ok(result);
        }
    }
}
