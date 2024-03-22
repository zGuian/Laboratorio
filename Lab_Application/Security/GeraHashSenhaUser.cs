using Lab_Application.Interfaces;
using Lab_Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Lab_Application.Services
{
    public static class GeraHashSenhaUser
    {
        private static readonly IUsuarioServices _service;

        public static void ConverteSenhaEmHash(Usuario usuario)
        {
            var senhaHasher = new PasswordHasher<Usuario>();
            usuario.Senha = senhaHasher.HashPassword(usuario, usuario.Senha);
        }

        public static bool ValidaAtualizaHashAsync(Usuario usuario, string hash)
        {
            var senhaHasher = new PasswordHasher<Usuario>();
            var status = senhaHasher.VerifyHashedPassword(usuario, hash, usuario.Senha);
            switch (status)
            {
                case PasswordVerificationResult.Failed:
                    return false;
                case PasswordVerificationResult.Success:
                    return true;
                case PasswordVerificationResult.SuccessRehashNeeded:
                    _service.Atualizar(usuario.Id, usuario);
                    return true;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
