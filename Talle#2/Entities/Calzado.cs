namespace Talle_2.Entities
{
    public class Calzado : Producto
    {
        public string? Capellada { get; set; }
        public string? Suela { get; set; }
        public string? Cierre { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }
    }
}
