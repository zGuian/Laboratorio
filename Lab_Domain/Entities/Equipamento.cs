using EFTS_Domain.Enums;

namespace EFTS_Domain.Entities
{
    public class Equipamento
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool Cadeado { get; set; }
        public int RegistroId { get; set; }
        public virtual IEnumerable<Registro>? Registros { get; set; }
    }
}