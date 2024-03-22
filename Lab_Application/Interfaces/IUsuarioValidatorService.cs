namespace Lab_Application.Interfaces
{
    public interface IUsuarioValidatorService
    {
        Task<bool> EncontraChaveUnica(string chave);
    }
}
