using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using ECommerce.Dtos;
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
        //----------------------------------------------------------------------------
        //REPOSITORIO NO GENERICO

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

        //----------------------------------------------------------------------------

        private readonly IGenericRepository<Producto> _repository;
        private readonly IMapper _mapper;

        public ProductosController(IGenericRepository<Producto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetAll()
        {
            //return Ok(await _repository.GetAll());

            //spec = debe incluir la logica de la condicion de la consulta y tambien las relaciones entre las entidades
            var spec = new ProductoCategoriaMarcaSpecification();
            var productos = await _repository.GetAllWithSpec(spec);
            return Ok(_mapper.Map<IReadOnlyList<Producto>, IReadOnlyList<ProductoDto>>(productos));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductoDto>> GetById(int id)
        {
            //return Ok(await _repository.GetById(id));

            //spec = debe incluir la logica de la condicion de la consulta y tambien las relaciones entre las entidades
            var spec = new ProductoCategoriaMarcaSpecification(id);
            var producto = await _repository.GetByIdWithSpec(spec);
            return Ok(_mapper.Map<Producto, ProductoDto>(producto));
        }
    }
}
