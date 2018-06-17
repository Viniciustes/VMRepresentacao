using System;
using VMRepresentacao.Domain.Messages;
using VMRepresentacao.Domain.Services;

namespace VMRepresentacao.Domain.ValueObjects
{
    public class ZipCode
    {
        #region Constructors
        private ZipCode() { }

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
            Number = OnlyNumbersService.OnlyNumbers(Number);

            if (Number.Length != 8)
                throw new Exception(GeneralMessages.MSG0004);
        }
        #endregion
    }
}
