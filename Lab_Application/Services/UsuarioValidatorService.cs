using Lab_Application.Interfaces;

namespace Lab_Application.Services
{
    internal class UsuarioValidatorService : IUsuarioValidatorService
    {
        private readonly IUsuarioServices _services;

        public UsuarioValidatorService(IUsuarioServices services)
        {
            _services = services;
        }

        public async Task<bool> EncontraChaveUnica(string chave)
        {
            var usuario = await _services.Buscar(chave);
            if (usuario != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
