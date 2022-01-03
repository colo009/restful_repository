﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> ObtenerProductoPorId(int id);
        Task<IEnumerable<Producto>> ListarProductos();

    }
}
