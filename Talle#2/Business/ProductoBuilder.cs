using Talle_2.Entities;

namespace Talle_2.Business
{
    public class ProductoBuilder
    {
        private Producto _producto;

        public ProductoBuilder(string categoria)
        {
            _producto = ProductoFactory.CrearProducto(categoria);
        }

        public ProductoBuilder SetColor(string color)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Color = color;
            }
            return this;
        }

        public ProductoBuilder SetTela(string tela)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Tela = tela;
            }
            return this;
        }

        public ProductoBuilder SetTalla(string talla)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Talla = talla;
            }
            return this;
        }

        public ProductoBuilder SetMarca(string marca)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Marca = marca;
            }
            return this;
        }


        public Producto Build() => _producto;
    }

}
