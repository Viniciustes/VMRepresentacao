using System;
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

            Active = true;
            DateRegister = DateTime.Now;
        }
        #endregion

        #region Attributes
        public string Name { get; private set; }

        public Email Email { get; private set; }

        public CPF CPF { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public DateTime DateRegister { get; private set; }

        public bool Active { get; private set; }
        #endregion
    }
}
