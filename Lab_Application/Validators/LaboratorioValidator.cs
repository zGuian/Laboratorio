using EFTS_Domain.Entities;
using FluentValidation;

namespace EFTS_Application.Validators
{
    public class LaboratorioValidator : AbstractValidator<Laboratorio>
    {
        public LaboratorioValidator()
        {
            RuleFor(l => l.Inventario)
                .MaximumLength(10)
                .WithMessage("Inventario inválido");
        }
    }
}