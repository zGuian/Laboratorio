using Domain.Enums;

namespace Domain.Entities
{
    public class Equipamento
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Hostname { get; set; }
        public bool Cadeado { get; set; }
    }
}
