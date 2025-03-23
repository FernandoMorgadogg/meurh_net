using MediatR;
using Meurh.API.Model.Message;
using Meurh.API.Services;
using Moq;

namespace meurh.Test.API.ServicesTest
{
    public class GetUserServiceTest
    {
        private readonly Mock<IMediator> _mediator;
        private readonly GetUserService _service;

        public GetUserServiceTest()
        {
            _mediator = new Mock<IMediator>();
            _service = new GetUserService(_mediator.Object);
        }

        [Fact(DisplayName = "Retorna listagem de todos os usuarios cadastrados")]
        public async void GetAll()
        {
            var result = await _service.Handle(new GetUserRequest(), CancellationToken.None);
            Assert.True(result.Count > 0);
        }

    }
}
