using System.ComponentModel.DataAnnotations;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Enumerators;

namespace VMRepresentacao.Web.ViewModels
{
    public class AddressViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Endereço")]
        public string Superscription { get; set; }

        [Display(Name = "CEP")]
        public string ZipCode { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Número")]
        public int Number { get; set; }

        [Display(Name = "Bairro")]
        public string District { get; set; }

        [Display(Name = "Tipo de endereço")]
        public TypeOfAddress TypeOfAddress { get; set; }

        [Display(Name = "Referência")]
        public string Reference { get; set; }

        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
