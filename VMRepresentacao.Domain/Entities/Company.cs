using System.Collections.Generic;
using System.Linq;
using VMRepresentacao.Domain.Enumerators;
using VMRepresentacao.Domain.ValueObjects;

namespace VMRepresentacao.Domain.Entities
{
    public class Company : BaseEntity
    {
        #region Constructors
        private Company() { }

        public Company(string name, CNPJ cNPJ, TypeOfSubsidiary typeOfSubsidiary, Email email, Address address, IList<Telephone> telephones)
        {
            Name = name;
            CNPJ = cNPJ;
            TypeOfSubsidiary = typeOfSubsidiary;
            Email = email;
            Address = address;

            _telephones = telephones;
        }
        #endregion

        #region Attributes
        private readonly IList<Telephone> _telephones;

        public string Name { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public TypeOfSubsidiary TypeOfSubsidiary { get; private set; }

        public Email Email { get; private set; }

        public int AddressId { get; private set; }
        public virtual Address Address { get; private set; }

        public IReadOnlyCollection<Telephone> Telephones => _telephones.ToArray();
        #endregion
    }
}
