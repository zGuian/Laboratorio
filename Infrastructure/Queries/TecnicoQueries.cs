using Infrastructure.MappingData;

namespace Infrastructure.Queries
{
    public static class TecnicoQueries
    {
        public static QueryModel GetPessoasQuery()
        {
            var table = ContextMap.GetTecnicoTable();
            var query = @$"
                SELECT TOP(20) [ID] AS Id,
                [CL_NOME] AS Nome
                FROM {table}";

            var parameters = new { };

            return new QueryModel(query, parameters);
        }

        public static QueryModel GetPessoasQuery(int id)
        {
            var table = ContextMap.GetTecnicoTable();
            var query = @$"
                SELECT TOP(20) [ID] AS Id,
                [CL_NOME] AS Nome
                FROM {table}
                WHERE 
                [ID] = @Id
            ";

            var parameters = new 
            {
                Id = id
            };

            return new QueryModel(query, parameters);
        }
    }
}
