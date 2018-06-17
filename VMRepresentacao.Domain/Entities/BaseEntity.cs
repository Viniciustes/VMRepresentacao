using System;

namespace VMRepresentacao.Domain.Entities
{
    public class BaseEntity 
    {
        public BaseEntity()
        {
            DateRegister = DateTime.Now;
            Active = true;
        }

        public int Id { get; private set; }

        public DateTime DateRegister { get; private set; }

        public bool Active { get; private set; }
    }
}