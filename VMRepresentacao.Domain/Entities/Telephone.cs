using System;
using System.Collections.Generic;
using VMRepresentacao.Domain.Enumerators;
using VMRepresentacao.Domain.Messages;

namespace VMRepresentacao.Domain.Entities
{
    public class Telephone : BaseEntity
    {
        #region Constructors
        private Telephone() { }

        public Telephone(int dDD, string phone, TypeOfTelephone typeOfTelephone)
        {
            DDD = dDD;
            Phone = phone;
            TypeOfTelephone = typeOfTelephone;

            Validations();
        }
        #endregion
        #region Attributes
        public int DDD { get; set; }

        public string Phone { get; private set; }

        public TypeOfTelephone TypeOfTelephone { get; private set; }

        public int CustomerId { get; private set; }
        public virtual Customer Customer { get; private set; }

        public int CompanyId { get; private set; }
        public virtual Company Company { get; private set; }
        #endregion

        #region Methods
        private void Validations()
        {
            var listDDD = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 31, 32, 33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53, 54, 55, 61, 62, 63, 64, 65, 66, 668, 69, 71, 72, 73, 74, 75, 77, 79, 81, 82, 83, 83, 85, 86, 87, 88, 91, 92, 93, 94, 95, 96, 97, 98, 99 };

            if (!listDDD.Contains(DDD))
                throw new ArgumentException(GeneralMessages.MSG0004);
        }
        #endregion

    }
}
