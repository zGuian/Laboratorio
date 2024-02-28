namespace Lab_Domain.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public string? Observacao { get; set; }
        public int IdTecnico { get; set; }
        public Tecnico? Tecnico { get; set; }
        public int IdEquipamento { get; set; }
        public Equipamento? Equipamento { get; set; }
    }
}