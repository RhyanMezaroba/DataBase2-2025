using System.ComponentModel.DataAnnotations;

namespace FC_Imobiliaria.Models
{
    public class Inquilino
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Idade { get; set; }
        public int QuantImoveis { get; set; }
    }
}
