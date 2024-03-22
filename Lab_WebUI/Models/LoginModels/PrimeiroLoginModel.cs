using Lab_Application.Validators;
using System.ComponentModel.DataAnnotations;

namespace Lab_WebUI.Models.LoginModels
{
    public class PrimeiroLoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [ChecaForcaSenhaValidator]
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
