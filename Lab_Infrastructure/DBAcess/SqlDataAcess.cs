using Dapper;
using EFTS_Application.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Lab_Infrastructure.Factory
{
    public class SqlDataAcess : ISqlDataAcess
    {
        private readonly IConfiguration configuration;

        public SqlDataAcess(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //METODO QUE FAZ A LEITURA NO BANCO
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "Default")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        //METODO QUE FAZ EXECUÇÃO NO BANCO
        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "Default")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}