namespace Domain.Entities
{
    public class Tecnico
    {
        public Tecnico(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public required int Id { get; set; }
        public required string Nome { get; set; }
    }
}
