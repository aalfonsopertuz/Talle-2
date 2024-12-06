namespace Talle_2.Entities
{
    public class Ropa : Producto
    {
        public string? Color { get; set; }
        public string? Tela { get; set; }
        public string? Talla { get; set; }
        public string? Marca { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }
    }
}
