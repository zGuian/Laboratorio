using Lab_Application.Interfaces;
using Lab_Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lab_WebUI.Validators
{
    public class CheckNomeRepetido : ValidationAttribute
    {
        private readonly Type _serviceType;

        public CheckNomeRepetido(Type services)
        {
            _serviceType = services ?? throw new ArgumentNullException(nameof(services));
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var services = validationContext.GetService(_serviceType) as ITecnicoServices;
            if (value is Tecnico tecnico && services != null)
            {
                string nome = tecnico.Nome;
                var tecNomeBanco = services.BuscaTecnicoPorNome(tecnico.Nome);
                if (tecNomeBanco != null &&  nome.Equals(tecNomeBanco.Result.Nome))
                {
                    return new ValidationResult("Nome já em uso");
                }
            }
            return ValidationResult.Success;
        }
    }
}
