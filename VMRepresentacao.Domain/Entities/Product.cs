using System;
using System.ComponentModel.DataAnnotations;

namespace VMRepresentacao.Domain.Entities
{
    public class Product : BaseEntity
    {

        #region Constructors
        private Product() { }

        public Product(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;

            Active = true;
            DateRegister = DateTime.Now;
        }
        #endregion

        #region Attributes
   
        public string Name { get; private set; }

        public double Price { get; private set; }

        public string Description { get; private set; }

        public DateTime DateRegister { get; private set; }

        public bool Active { get; private set; }
        #endregion
    }
}
