using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface ITecnicoRepository
    {
        Task<IEnumerable<TecnicoDTO>> GetTecnico();

        Task<TecnicoDTO> GetTecnico(int id);

        void InserirTecnico(Tecnico tecnico);
    }
}