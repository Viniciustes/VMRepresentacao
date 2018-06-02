using System;
using VMRepresentacao.Domain.Messages;

namespace VMRepresentacao.Domain.ValueObjects
{
    public class ZipCode
    {
        #region Constructors
        public ZipCode(string number)
        {
            Number = number;

            Validations();
        }
        #endregion

        #region Attributes
        public string Number { get; private set; }
        #endregion

        #region Methods
        private void Validations()
        {
            if (Number.Length != 8)
                throw new Exception(GeneralMessages.MSG0004);
        }
        #endregion
    }
}
