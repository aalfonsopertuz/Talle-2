using Talle_2.Entities;

namespace Talle_2.Business
{
    public class ProductoFactory
    {
        public static Producto CrearProducto(string categoria)
        {
            return categoria switch
            {
                "Ropa" => new Ropa(),
                "Accesorios" => new Accesorios(),
                "Calzado" => new Calzado(),
                _ => throw new ArgumentException("Categoría no válida")
            };
        }
    }
}



