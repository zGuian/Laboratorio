using Lab_Application.Interfaces;
using Lab_WebUI.Validators;

namespace Lab_WebUI.Models.TecnicoModels
{
    internal class CadastraTecnicoModel
    {
        [CheckNomeRepetido(typeof(ITecnicoServices))]
        public string? Nome { get; set; }
    }
}
