using Lab_Application.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Lab_Application.Validators
{
    public class UsuarioRepetidoValidator : ValidationAttribute
    {
        private readonly IUsuarioValidatorService _usuarioValidator;

        public UsuarioRepetidoValidator(IUsuarioValidatorService usuarioValidator)
        {
            _usuarioValidator = usuarioValidator;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var chave = (string)value;
            var chaveEmUso = _usuarioValidator.EncontraChaveUnica(chave).Result;
            if (chaveEmUso == true)
            {
                return new ValidationResult("Ops, ocorreu um erro. Chave em uso", new[] { validationContext.MemberName });
            }
            return ValidationResult.Success;
        }
    }
}
