using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Producto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int Stock { set; get; }
        public int MarcaId { set; get; }
        public Marca Marca { set; get; }
        public int CategoriaId { set; get; }
        public Categoria Categoria { set; get; }
        public decimal Precio { set; get; }
        public string Imagen { set; get; }
    }
}
