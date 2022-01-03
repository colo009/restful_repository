using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessLogic.Data
{
    public class EcommerceDbContextData
    {
        public static async Task CargarDataAsync(EcommerceDbContext ecommerceDbContext)
        {
            if (!ecommerceDbContext.Marcas.Any())
            {
                var marcaData = File.ReadAllText("../BusinessLogic/CargarDataPrueba/marca.json");
                var marcas = JsonSerializer.Deserialize<List<Marca>>(marcaData);

                foreach (var m in marcas)
                {
                    ecommerceDbContext.Marcas.Add(m);
                }

                await ecommerceDbContext.SaveChangesAsync();
            }

            if (!ecommerceDbContext.Categorias.Any())
            {
                var categoriaData = File.ReadAllText("../BusinessLogic/CargarDataPrueba/categoria.json");
                var categorias = JsonSerializer.Deserialize<List<Categoria>>(categoriaData);

                foreach (var m in categorias)
                {
                    ecommerceDbContext.Categorias.Add(m);
                }

                await ecommerceDbContext.SaveChangesAsync();
            }

            if (!ecommerceDbContext.Productos.Any())
            {
                var productoData = File.ReadAllText("../BusinessLogic/CargarDataPrueba/producto.json");
                var productos = JsonSerializer.Deserialize<List<Producto>>(productoData);

                foreach (var m in productos)
                {
                    ecommerceDbContext.Productos.Add(m);
                }

                await ecommerceDbContext.SaveChangesAsync();
            }
        }
    }
}
