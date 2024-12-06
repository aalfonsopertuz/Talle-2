namespace Talle_2.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public List<Producto> Productos { get; set; } = [];
        public string Estado { get; set; } = "En proceso";
    }
}
