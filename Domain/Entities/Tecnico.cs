namespace Domain.Entities
{
    public class Tecnico
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }

        public Tecnico()
        {
        }

        public Tecnico(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
