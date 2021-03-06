using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        //Representa la condicion logica que deseas aplicar a una entidad
        Expression<Func<T, bool>> Criteria { get; }

        //Representa las relaciones que vas a aplicar a la entidad, ejemplo: include
        List<Expression<Func<T, object>>> Includes { get; }
    }
}
