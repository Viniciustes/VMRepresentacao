using System.Collections.Generic;
using System.Linq;
using VMRepresentacao.Domain.ValueObjects;

namespace VMRepresentacao.Domain.Entities
{
    public class Customer : BaseEntity
    {
        #region Constructors
        private Customer() { }

        public Customer(string name, Email email, CPF cPF, CNPJ cNPJ, Address address, IList<Telephone> telephones)
        {
            Name = name;
            Email = email;
            CPF = cPF;
            CNPJ = cNPJ;
            Address = address;

            // TODO: Remover comentario abaixo e inicialização do array
            //_telephones =  telephones;
            //_telephones.Add(new Telephone(61, "99999999", Enumerators.TypeOfTelephone.CellPhone));
        }
        #endregion

        #region Attributes
        //private readonly IList<Telephone> _telephones;

        public string Name { get; private set; }

        public Email Email { get; private set; }

        public CPF CPF { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public int AddressId { get; private set; }
        public virtual Address Address { get; private set; }

        public IReadOnlyCollection<Telephone> Telephones { get; private set; }
        #endregion
    }
}
