using VMRepresentacao.Domain.Enumerators;
using VMRepresentacao.Domain.ValueObjects;

namespace VMRepresentacao.Domain.Entities
{
    public class Company : BaseEntity
    {
        #region Constructors
        private Company() { }

        public Company(string name, CNPJ cNPJ, TypeOfSubsidiary typeOfSubsidiary, Email email, Address address)
        {
            Name = name;
            CNPJ = cNPJ;
            TypeOfSubsidiary = typeOfSubsidiary;
            Email = email;
            Address = address;
        }
        #endregion

        #region Attributes
        public string Name { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public TypeOfSubsidiary TypeOfSubsidiary { get; private set; }

        public Email Email { get; private set; }

        public int AddressId { get; private set; }
        public Address Address { get; private set; }
        #endregion
    }
}
