using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTS_Application.DTOs
{
    public class TecnicoDTO
    {
        [Key]
        public int Id { get; set; }

        [Column("CL_Nome")]
        public string Nome { get; set; }
    }
}