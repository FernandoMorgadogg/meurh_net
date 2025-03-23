using MediatR;
using FluentValidation;

namespace Meurh.API.Model.Message
{
    public class AddUserRequest: IRequest<bool>
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class AddUserRequestValidation : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidation() 
        {
            RuleFor(f => f.Name)
                .NotEmpty()
                .WithMessage("O campo deve ser preenchido")
                .MinimumLength(10)
                .WithMessage("O tamanho do campo deve ser superior a 10 caracteres");

            RuleFor(f => f.Mail)
                .NotEmpty()
                .WithMessage("O campo deve ser preenchido");

            RuleFor(f => f.PhoneNumber)
                .NotEmpty()
                .WithMessage("O campo deve ser preenchido");

        }
    }


}
