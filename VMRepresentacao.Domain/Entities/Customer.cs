using System.Collections.Generic;
using System.Linq;
using VMRepresentacao.Domain.ValueObjects;

namespace VMRepresentacao.Domain.Entities
{
    public class Customer : BaseEntity
    {

        #region Constructors
        private Customer() { }

        public Customer(string name, Email email, CPF cPF, CNPJ cNPJ)
        {
            Name = name;
            Email = email;
            CPF = cPF;
            CNPJ = cNPJ;

            //_addresses = new List<Address>();
        }
        #endregion

        #region Attributes
        private readonly IList<Address> _addresses;

        public string Name { get; private set; }

        public Email Email { get; private set; }

        public CPF CPF { get; private set; }

        public CNPJ CNPJ { get; private set; }

       // public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();
        #endregion
    }
}
