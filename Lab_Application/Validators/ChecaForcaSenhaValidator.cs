using System.ComponentModel.DataAnnotations;

namespace Lab_Application.Validators
{
    public class ChecaForcaSenhaValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var senhaRecebida = (string)value;
            if (senhaRecebida.Length < 8)
            {
                return new ValidationResult("A senha deve ter no minimo 8 caracteres");
            }
            if (senhaRecebida.Any(char.IsSymbol))
            {
                return new ValidationResult("A senha deve conter pelo menos um caractere especial");
            }
            return ValidationResult.Success;
        }
    }
}
