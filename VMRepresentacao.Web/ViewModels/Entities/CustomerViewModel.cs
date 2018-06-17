using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Web.ViewModels.Entities
{
    public class CustomerViewModel
    {
        [ScaffoldColumn(false)]
        public int IdViewModel { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
        public string NameViewModel { get; set; }

        [Display(Name = "E-mail do cliente")]
        [Required(ErrorMessage = "E-mail do cliente é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        public string EmailViewModel { get; set; }

        [Display(Name = "CPF do cliente")]
        [Required(ErrorMessage = "CPF do cliente é obrigatório.")]
        public string CPFViewModel { get; set; }

        [Display(Name = "CNPJ da empresa")]
        [Required(ErrorMessage = "CNPJ da empresa é obrigatório.")]
        public string CNPJViewModel { get; set; }

        [Display(Name = "Endereço")]
        public AddressViewModel AddressViewModel { get; set; }

        //public IEnumerable<Telephone> Telephones { get; set; }
    }
}
