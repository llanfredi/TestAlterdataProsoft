using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Validators
{
    public class DevValidator : AbstractValidator<DevEntity>
    {
        public DevValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Campo nome não pode ser nulo");
            RuleFor(x => x.Endereco).NotEmpty().WithMessage("Campo endereço não pode ser nulo");
            RuleFor(x => x.Cidade).NotEmpty().WithMessage("Campo cidade não pode ser nulo");

            RuleFor(x => x.Estado).MaximumLength(2).WithMessage("Campo estado deve ter no máximo 2 caracteres");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("Campo estado não pode ser nulo");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Campo email não pode ser nulo");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Insira um e-mail válido");
            RuleFor(x => x.Email).Must(x => x.Contains("@prosoft.com.br")).WithMessage("O domínio do e-mail deve ser @prosoft.com.br");

            RuleFor(x => x.IdTipoDev).NotEmpty().NotNull().WithMessage("Campo tipo de desenvolvedor não pode ser nulo");
        }
    }
}
