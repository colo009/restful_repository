using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductoCategoriaMarcaSpecification : BaseSpecification<Producto>
    {
        public ProductoCategoriaMarcaSpecification()
        {
            AddInclude(a => a.Categoria);
            AddInclude(a => a.Marca);
        }

        public ProductoCategoriaMarcaSpecification(int id) : base(a => a.Id == id)
        {
            AddInclude(a => a.Categoria);
            AddInclude(a => a.Marca);
        }
    }
}
