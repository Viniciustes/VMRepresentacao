using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VMRepresentacao.Domain.Interfaces.Specifications;

namespace VMRepresentacao.Domain.Specifications
{
    public abstract class BaseSpecification<Entity> : ISpecification<Entity>
    {
        public BaseSpecification(Expression<Func<Entity, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<Entity, bool>> Criteria { get; }

        public List<Expression<Func<Entity, object>>> Includes { get; } = new List<Expression<Func<Entity, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        protected virtual void AddInclude(Expression<Func<Entity, object>> expression)
        {
            Includes.Add(expression);
        }

        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
    }
}
