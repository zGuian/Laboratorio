using Lab_Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_WebUI.Models.EquipamentosModels
{
    public class EquipamentoModel
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool Cadeado { get; set; }
        public required SelectList TipoEquipOptions { get; set; }
    }
}
