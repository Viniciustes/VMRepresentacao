using System;

namespace VMRepresentacao.Domain.ValueObjects
{
    public class Email
    {
        #region Constructors
        public Email(string address)
        {
            Address = address;

            Validations();
        }
        #endregion

        #region Attributes
        public string Address { get; private set; }
        #endregion

        #region Methodos
        private void Validations()
        {
            if (string.IsNullOrEmpty(Address))
                throw new ArgumentException("Email não pode ficar em branco");
        }
        #endregion
    }
}
