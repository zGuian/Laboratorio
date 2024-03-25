namespace EFTS_Domain.Entities
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EquipamentoId { get; set; }
        public virtual Equipamento Equipamento { get; set; }
    }
}