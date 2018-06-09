using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace VMRepresentacao.Domain.Interfaces.Specifications
{
    public interface ISpecification <Entity>
    {
        Expression<Func<Entity, bool>> Criteria { get; }
        List<Expression<Func<Entity, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}
