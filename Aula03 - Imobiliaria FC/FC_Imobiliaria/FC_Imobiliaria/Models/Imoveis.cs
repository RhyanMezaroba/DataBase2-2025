using System.ComponentModel.DataAnnotations;

namespace FC_Imobiliaria.Models
{
    public class Imoveis
    {
        [Key]
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Definicao { get; set; }
        public int NumeroQuartos { get; set; }
        public float Preco { get; set; }
    }
}
