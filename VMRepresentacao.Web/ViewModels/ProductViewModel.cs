using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Web.ViewModels
{
    public class ProductViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Nome do produto")]
        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preço do produto é obrigatório")]
        [Display(Name = "Preço do produto")]
        [DataType(DataType.Currency, ErrorMessage = "Preço inválido.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Descrição do produto é obrigatório.")]
        [Display(Name = "Descrição do produto")]
        public string Description { get; set; }
    }
}
