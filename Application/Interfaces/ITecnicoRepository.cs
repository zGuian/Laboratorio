using ApplicationArq.DTOs;
using Domain.Entities;

namespace ApplicationArq.Interfaces
{
    public interface ITecnicoRepository
    {
        Task<IEnumerable<TecnicoDTO>> GetTecnico();
        Task<TecnicoDTO> GetTecnico(int id);
        void InserirTecnico(string nome);
    }
}
