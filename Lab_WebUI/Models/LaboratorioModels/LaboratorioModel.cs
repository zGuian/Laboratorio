using Lab_Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_WebUI.Models.LaboratorioModels
{
    public class LaboratorioModel
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool? Cadeado { get; set; }
        public string? NomeTecnico { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public EnumArmario? Armario { get; set; }
        public string? Observacao { get; set; }
        public required SelectList TipoEquipOptions { get; set; }
        public required SelectList ArmarioOptions { get; set; }
    }
}
