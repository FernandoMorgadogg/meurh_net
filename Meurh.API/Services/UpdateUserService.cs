using MediatR;
using Meurh.API.Model.Message;

namespace Meurh.API.Services
{
    public class UpdateUserService: IRequestHandler<UpdateUserRequest, bool>
    {
        private readonly IMediator _mediator;
        public UpdateUserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            return false;
        }
    }
}
