using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FC_Imobiliaria.Models
{
    [PrimaryKey(nameof(InquilinoID), nameof(ImovelID))]
    public class InquilinoImoveis
    {
        public int InquilinoID { get; set; }

        [ForeignKey(nameof(InquilinoID))]
        public Inquilino? Inquilino { get; set; }

        public int ImovelID { get; set; }

        [ForeignKey(nameof(ImovelID))]
        public Imoveis? Imoveis { get; set; }
    }
}
