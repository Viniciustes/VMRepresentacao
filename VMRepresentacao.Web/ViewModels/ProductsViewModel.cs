using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Web.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        [Display(Name="Nome do produto")]
        public string Name { get; set; }

        [Display(Name="Preço do produto")]
        public double Price { get; set; }

        [Display(Name="Descrição do produto")]
        public string Description { get; set; }
    }
}
