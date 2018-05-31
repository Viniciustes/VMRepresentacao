using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Web.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        [Display(Name="Nome do cliente")]
        public string Name { get;  set; }

        [Display(Name="Email do cliente")]
        public string Email { get;  set; }

        [Display(Name="CPF do cliente")]
        public string CPF { get;  set; }

        [Display(Name="CNPJ da empresa")]
        public string CNPJ { get;  set; }
    }
}
