using Lab_Application.DTOs;

namespace Lab_Application.Interfaces
{
    public interface ITecnicoServices
    {
        void AtualizarTecnico(TecnicoDTO tecnicoDTO);
        void CadastraTecnico(TecnicoDTO tecnicoDto);
        Task<IEnumerable<TecnicoDTO>> BuscaTecnicos();
        Task<TecnicoDTO> BuscaTecnicosPorId(int id);
    }
}
