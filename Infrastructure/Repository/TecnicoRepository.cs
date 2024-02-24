using ApplicationArq.DTOs;
using ApplicationArq.Interfaces;
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
            try
            {
                using (var cn = _conn.ConectarAsync())
                {
                    var query = TecnicoQueries.GetTecnicosQuery();
                    var tecDtos = cn.Query<TecnicoDTO>(query.Query, query.Parameters);
                    return tecDtos;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<TecnicoDTO> GetTecnico(int id)
        {
            var query = TecnicoQueries.GetTecnicosQuery(id);
            try
            {
                using (var cn = _conn.ConectarAsync())
                {
                    var tecnico = await cn.QueryFirstOrDefaultAsync<TecnicoDTO>(query.Query, query.Parameters);
                    return tecnico;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public async void InserirTecnico(string nome)
        {
            var query = TecnicoQueries.InsertTecnicos(nome);
            try
            {
                var connection = _conn.ConectarAsync();
                await connection.QuerySingleAsync(query.Query, query.Parameters);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
