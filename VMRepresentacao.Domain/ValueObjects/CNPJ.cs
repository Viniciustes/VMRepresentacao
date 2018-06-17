using System;
using VMRepresentacao.Domain.Messages;
using VMRepresentacao.Domain.Services;

namespace VMRepresentacao.Domain.ValueObjects
{
    public class CNPJ
    {
        #region Constructors
        private CNPJ() { }

        public CNPJ(string number)
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

            if (Number.Length != 14)
                throw new ArgumentException(GeneralMessages.MSG0002);
        }
        #endregion
    }
}
