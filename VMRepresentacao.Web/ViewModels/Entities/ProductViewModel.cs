using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Web.ViewModels.Entities
{
    public class ProductViewModel
    {
        [Key]
        public int IdViewModel { get; set; }

        [Display(Name = "Nome do produto")]
        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        public string NameViewModel { get; set; }

        [Required(ErrorMessage = "Preço do produto é obrigatório")]
        [Display(Name = "Preço do produto")]
        [DataType(DataType.Currency, ErrorMessage = "Preço inválido.")]
        public double PriceViewModel { get; set; }

        [Required(ErrorMessage = "Descrição do produto é obrigatório.")]
        [Display(Name = "Descrição do produto")]
        public string DescriptionViewModel { get; set; }
    }
}
