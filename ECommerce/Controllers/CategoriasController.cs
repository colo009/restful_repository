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
    [Route("api/categorias")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IGenericRepository<Categoria> _repository;

        public CategoriasController(IGenericRepository<Categoria> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Categoria>>> GetAll() => Ok(await _repository.GetAll());

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Categoria>> GetById(int id) => Ok(await _repository.GetById(id));

    }
}
