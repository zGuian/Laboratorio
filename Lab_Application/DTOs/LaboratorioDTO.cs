using Lab_Domain.Enums;

namespace Lab_Application.DTOs
{
    public class LaboratorioDTO
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool? Cadeado { get; set; }
        public string NomeTecnico { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public EnumArmario? Armario { get; set; }
        public string? Observacao { get; set; }
    }
}
