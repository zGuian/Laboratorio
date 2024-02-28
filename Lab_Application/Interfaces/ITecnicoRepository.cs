using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface ITecnicoRepository
    {
        Task<IEnumerable<TecnicoDTO>> GetTecnicoAsync();
        Task<TecnicoDTO> GetTecnicoAsync(int id);
        Task<TecnicoDTO> GetTecnicoAsync(string nome);
        void InserirTecnico(Tecnico tecnico);
        void AtualizaTecnico(int id, Tecnico tecnico);

    }
}