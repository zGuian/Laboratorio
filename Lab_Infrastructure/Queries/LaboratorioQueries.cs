using EFTS_Domain.Entities;
using Lab_Infrastructure.MappingData;

namespace Lab_Infrastructure.Queries
{
    internal static class LaboratorioQueries
    {
        public static QueryModel UpdateParteLaboratorio(Laboratorio laboratorio)
        {
            var table = ContextMap.GetLaboratorioTable();
            var query = $@"
			UPDATE [dbo].[{table}]
			SET
			[CL_TipoEquipamento] = @tipoEquipamento,
			[CL_SerialNumber] = @serialNumber,
			[CL_Inventario] = @inventario,
			[CL_Cadeado] = @Cadeado,
			[CL_Tecnico] = @NomeTecnico,
			[CL_Entrada] = @Entrada,
			[CL_Saida] = @Saida,
			[CL_Armario] = @Armario,
			[CL_Observacao] = @Observacao
			WHERE [Id] = @Id";

            var parameters = new
            {
                tipoEquipamento = laboratorio.TipoEquipamento,
                serialNumber = laboratorio.SerialNumber,
                inventario = laboratorio.Inventario
            };

            return new QueryModel(query, parameters);
        }
    }
}