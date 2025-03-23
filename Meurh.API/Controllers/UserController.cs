using Microsoft.AspNetCore.Mvc;
using MediatR;
using Meurh.API.Model.Message;

namespace Meurh.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser() {
            return Ok(await _mediator.Send(new GetUserRequest()));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest request) 
        {
            var result = await _mediator.Send(request);
            if (result)
                return Ok(result);

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteUserRequest request) 
        {
            var result = await _mediator.Send(request);
            if (result) return Ok(result);

            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserRequest request) 
        {
            var result = await _mediator.Send(request);
            if (result) return Ok(result);

            return NotFound();
        }

    }
}
