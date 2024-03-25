namespace EFTS_Application.Interfaces
{
    public interface ISqlDataAcess
    {
        //METODO DE LEITURA NO BANCO
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "Default");

        //METODO DE ESCRITA NO BANCO
        Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "Default");
    }
}