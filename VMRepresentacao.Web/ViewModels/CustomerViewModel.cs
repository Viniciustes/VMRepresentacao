using System.ComponentModel.DataAnnotations;
using VMRepresentacao.Domain.Entities;

namespace VMRepresentacao.Web.ViewModels
{
    public class CustomerViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
        public string Name { get; set; }

        [Display(Name = "Email do cliente")]
        [Required(ErrorMessage = "Email do cliente é obrigatório.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido.")]
        public string Email { get; set; }

        [Display(Name = "CPF do cliente")]
        [Required(ErrorMessage = "CPF do cliente é obrigatório.")]
        [StringLength(11, ErrorMessage = ("CPF inválido."))]
        public string CPF { get; set; }

        [Display(Name = "CNPJ da empresa")]
        [StringLength(14, ErrorMessage = "CNPJ inválido.")]
        [Required(ErrorMessage = "CNPJ do cliente é obrigatório.")]
        public string CNPJ { get; set; }

        public Address Address { get; set; }

        //public IEnumerable<Telephone> Telephones { get; set; }
    }
}
