using BusinessLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly EcommerceDbContext _context;

        public ProductoRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> ListarProductos()
        {
            return await _context.Productos.Include(a => a.Marca).Include(a => a.Categoria).ToListAsync();
        }

        public async Task<Producto> ObtenerProductoPorId(int id)
        {
            return await _context.Productos.Include(a => a.Marca).Include(a => a.Categoria).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
