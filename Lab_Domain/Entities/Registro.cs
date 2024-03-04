namespace Lab_Domain.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public string? Observacao { get; set; }
        public int EquipamentoId { get; set; }
        public virtual Equipamento Equipamento { get; set; }
    }
}