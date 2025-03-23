using MediatR;
using Meurh.API.Model.Message;
namespace Meurh.API.Services
{
    public class AddUserService : IRequestHandler<AddUserRequest, bool>
    {
        private readonly IMediator _mediator;
        public AddUserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
