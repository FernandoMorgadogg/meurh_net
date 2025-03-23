using MediatR;
using Meurh.API.Model.Message;
namespace Meurh.API.Services
{
    public class GetUserService : IRequestHandler<GetUserRequest, List<GetUserResponse>>
    {
        private readonly IMediator _mediator;
        public GetUserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Retorna lista de usuarios
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>List<GetUserResponse></returns>
        public async Task<List<GetUserResponse>> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            return this.GetList();
        }

        /// <summary>
        /// Retorna lista de usuarios
        /// </summary>
        /// <returns>List<GetUserResponse></returns>
        private List<GetUserResponse> GetList()
        {
            var list = new List<GetUserResponse>();
            list.Add(new GetUserResponse() { id = 1, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 2, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 3, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 4, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 5, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 6, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 7, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });
            list.Add(new GetUserResponse() { id = 8, Name = "Teste 1", Mail = "mail1@test.com", PhoneNumber = "(00)00000-0000" });

            return list;
        }
        
    }
    
}
