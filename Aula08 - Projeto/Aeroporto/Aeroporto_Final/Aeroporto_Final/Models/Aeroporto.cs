using System.ComponentModel.DataAnnotations;

namespace Aeroporto_Final.Models
{
    public class Aeroporto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }

    }
}
