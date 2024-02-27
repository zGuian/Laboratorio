using Lab_Domain.Enums;

namespace Lab_Domain.Entities
{
    public class Equipamento
    {
        public int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Inventario { get; set; }
        public bool Cadeado { get; set; }

        public Equipamento()
        {
        }

        public Equipamento(int id, EnumTipoEquipamento enumTipo, string serialNumber, string inventario, bool cadeado)
        {
            Id = id;
            TipoEquipamento = enumTipo;
            SerialNumber = serialNumber;
            Inventario = inventario;
            Cadeado = cadeado;
        }
    }
}