using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Dtos
{
    public class ProductoDto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int Stock { set; get; }
        public int MarcaId { set; get; }
        public string MarcaNombre { set; get; }
        public int CategoriaId { set; get; }
        public string CategoriaNombre { set; get; }
        public decimal Precio { set; get; }
        public string Imagen { set; get; }
    }
}
