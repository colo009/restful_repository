using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        //private readonly IProductoRepository _productoRepository;

        //public ProductosController(IProductoRepository productoRepository)
        //{
        //    _productoRepository = productoRepository;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Producto>>> GetAll()
        //{
        //    return Ok(await _productoRepository.ListarProductos());
        //}

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Producto>> GetById(int id)
        //{
        //    return Ok(await _productoRepository.ObtenerProductoPorId(id));
        //}

        private readonly IGenericRepository<Producto> _repository;

        public ProductosController(IGenericRepository<Producto> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetAll()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            return Ok(await _repository.GetById(id));
        }
    }
}
