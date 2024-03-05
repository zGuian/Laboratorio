using FluentValidation;
using Lab_Domain.Entities;

namespace Lab_Application.Validators
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
