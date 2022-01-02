using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class ProductoRepository : IProductoRepository
    {
        public Task<IEnumerable<Producto>> ListarProductos()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> ObtenerProductoPorId()
        {
            throw new NotImplementedException();
        }
    }
}
