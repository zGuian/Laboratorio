using Application.DTOs;
using Application.Interfaces;
using Dapper;
using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Queries;

namespace Infrastructure.Repository
{
    internal class TecnicoRepository(ConexaoBanco conexao) : ITecnicoRepository
    {
        private readonly ConexaoBanco _conn = conexao;

        public async Task<IEnumerable<TecnicoDTO>> GetTecnico()
        {
            var query = TecnicoQueries.GetPessoasQuery();
            var connection = _conn.ConectarAsync();
            var tecnico = await connection.QueryAsync<TecnicoDTO>(query.Query, query.Parameters);
            return tecnico;
        }

        public async Task<TecnicoDTO> GetTecnico(int id)
        {
            var query = TecnicoQueries.GetPessoasQuery(id);
            var connection = _conn.ConectarAsync();
            var tecnico = await connection.QueryFirstOrDefaultAsync<TecnicoDTO>(query.Query, query.Parameters);
            if (tecnico != null)
            {
                return tecnico;
            }
            throw new NotImplementedException();
        }

        public void InserirTecnico(Tecnico tecnico)
        {
            throw new NotImplementedException();
        }
    }
}
