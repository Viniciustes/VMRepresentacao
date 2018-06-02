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
        }
        #endregion

        #region Attributes
   
        public string Name { get; private set; }

        public double Price { get; private set; }

        public string Description { get; private set; }
        #endregion
    }
}
