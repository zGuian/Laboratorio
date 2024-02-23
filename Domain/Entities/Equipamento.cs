using Domain.Enums;

namespace Domain.Entities
{
    public class Equipamento
    {
        public required int Id { get; set; }
        public EnumTipoEquipamento TipoEquipamento { get; set; }
        public string? SerialNumber { get; set; }
        public string? Hostname { get; set; }
        public bool Cadeado { get; set; }

        public Equipamento()
        {
        }

        public Equipamento(int id, EnumTipoEquipamento enumTipo, string serialNumber, string hostname, bool cadeado)
        {
            Id = id;
            TipoEquipamento = enumTipo;
            SerialNumber = serialNumber;
            Hostname = hostname;
            Cadeado = cadeado;
        }
    }
}
