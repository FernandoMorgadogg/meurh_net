using MediatR;

namespace Meurh.API.Model.Message
{
    public class GetUserRequest: IRequest<List<GetUserResponse>>
    {
    }

    public class GetUserResponse 
    {
        public int id { get; set;}
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
