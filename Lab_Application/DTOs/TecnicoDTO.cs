using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_Application.DTOs
{
    public class TecnicoDTO
    {
        [Key]
        public int Id { get; set; }

        [Column("CL_Nome")]
        public required string Nome { get; set; }
    }
}