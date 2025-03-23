using MediatR;
using FluentValidation;

namespace Meurh.API.Model.Message
{
    public class DeleteUserRequest: IRequest<bool>
    {
        public int id { get; set; }
    }

    public class DeleteUserRequestValidation : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserRequestValidation() 
        {
            RuleFor(f => f.id)
                .NotEmpty()
                .WithMessage("O campo deve ser preenchido")
                .GreaterThan(0)
                .WithMessage("o valor deve ser maior que zero");
        }
    }
}
