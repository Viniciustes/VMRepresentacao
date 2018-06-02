﻿using System;
using VMRepresentacao.Domain.Messages;

namespace VMRepresentacao.Domain.ValueObjects
{
    public class CNPJ
    {
        #region Constructors
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
            if(Number.Length != 14)
                throw new ArgumentException(GeneralMessages.MSG0002);
        }
        #endregion
    }
}
