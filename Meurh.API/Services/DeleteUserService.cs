using MediatR;
using Meurh.API.Model.Message;
namespace Meurh.API.Services
{
    public class DeleteUserService: IRequestHandler<DeleteUserRequest, bool>
    {
        private readonly IMediator _mediator;
        public DeleteUserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
