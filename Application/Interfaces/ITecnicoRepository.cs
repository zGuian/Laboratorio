using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITecnicoRepository
    {
        Task<IEnumerable<TecnicoDTO>> GetTecnico();
        Task<TecnicoDTO> GetTecnico(int id);
        void InserirTecnico(Tecnico tecnico);
    }
}
