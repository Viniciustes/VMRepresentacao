using System.ComponentModel.DataAnnotations;
using VMRepresentacao.Domain.Enumerators;

namespace VMRepresentacao.Web.ViewModels.Entities
{
    public class AddressViewModel
    {
        [ScaffoldColumn(false)]
        public int IdViewModel { get; set; }

        [Display(Name = "Endereço")]
        public string SuperscriptionViewModel { get; set; }

        [Display(Name = "CEP")]
        public string ZipCodeViewModel { get; set; }

        [Display(Name = "Estado")]
        public string StateViewModel { get; set; }

        [Display(Name = "Cidade")]
        public string CityViewModel { get; set; }

        [Display(Name = "Número")]
        public int NumberViewModel { get; set; }

        [Display(Name = "Bairro")]
        public string DistrictViewModel { get; set; }

        [Display(Name = "Tipo de endereço")]
        public TypeOfAddress TypeOfAddressViewModel { get; set; }

        [Display(Name = "Referência")]
        public string ReferenceViewModel { get; set; }
    }
}
