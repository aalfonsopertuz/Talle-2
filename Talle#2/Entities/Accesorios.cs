namespace Talle_2.Entities
{
    public class Accesorios : Producto
    {
        public string? Disenador { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public string? Material { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }
    }
}

