using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab_Infrastructure.Factory
{
    public class ConexaoBanco
    {
        private readonly SqlConnection _conn = new();

        public ConexaoBanco()
        {
            _conn.ConnectionString = "";
        }

        public SqlConnection ConectarAsync()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            return _conn;
        }
    }
}