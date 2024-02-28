using Lab_Application.DTOs;

namespace Lab_Application.Interfaces
{
    public interface ITecnicoServices
    {
        void AtualizarTecnico(int id, TecnicoDTO tecnicoDTO);
        void CadastraTecnico(TecnicoDTO tecnicoDto);
        Task<IEnumerable<TecnicoDTO>> BuscaTecnicos();
        Task<TecnicoDTO> BuscaTecnicosPorId(int id);
        Task<TecnicoDTO> BuscaTecnicoPorNome(string nome);
    }
}
