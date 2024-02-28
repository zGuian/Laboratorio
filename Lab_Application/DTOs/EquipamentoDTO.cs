using Lab_Domain.Enums;

namespace Lab_Application.DTOs
{
    public class EquipamentoDTO
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool Cadeado { get; set; }
    }
}
