using VMRepresentacao.Domain.Enumerators;
using VMRepresentacao.Domain.ValueObjects;

namespace VMRepresentacao.Domain.Entities
{
    public class Address : BaseEntity
    {

        #region constructors
        private Address() { }

        public Address(string superscription, ZipCode zipCode, States state,
            string city, int number, string district, TypeOfAddress typeOfAddress, string reference)
        {
            Superscription = superscription;
            ZipCode = zipCode;
            State = state;
            City = city;
            Number = number;
            District = district;
            TypeOfAddress = typeOfAddress;
            Reference = reference;
        }
        #endregion

        #region Attributes
        public string Superscription { get; private set; }

        public ZipCode ZipCode { get; private set; }

        public States State { get; private set; }

        public string City { get; private set; }

        public int Number { get; private set; }

        /// <summary>
        /// Referente ao bairro
        /// </summary>
        public string District { get; private set; }

        public TypeOfAddress TypeOfAddress { get; private set; }

        public string Reference { get; private set; }

        public virtual Company Company { get; private set; }
        public virtual Customer Customer { get; private set; }
        #endregion
    }
}
