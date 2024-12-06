namespace Talle_2.Entities
{
    public abstract class Producto
    {
        public string? Nombre { get; set; }
        public CategoriaProducto? Categoria { get; set; }

        public abstract Producto Clonar();
    }
}
