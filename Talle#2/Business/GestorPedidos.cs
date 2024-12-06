using Talle_2.Entities;

namespace Talle_2.Business
{
    public class GestorPedidos
    {
        private static GestorPedidos? _instancia;
        private int _idCounter = 0;
        private readonly List<Pedido> _pedidos = [];

        private GestorPedidos() { }

        public static GestorPedidos Instancia
        {
            get
            {
                _instancia ??= new GestorPedidos();
                return _instancia;
            }
        }

        public int AgregarPedido(Pedido pedido)
        {
            pedido.Id = ++_idCounter;
            _pedidos.Add(pedido);
            return pedido.Id;
        }

        public Pedido ObtenerPedido(int id) => _pedidos.FirstOrDefault(p => p.Id == id);

        public void ActualizarEstadoPedido(int id, string estado)
        {
            var pedido = ObtenerPedido(id);
            if (pedido != null) pedido.Estado = estado;
        }

        public void MostrarPedidos()
        {
            if (_pedidos.Count == 0)
            {
                Console.WriteLine("No hay pedidos registrados.");
                return;
            }

            Console.WriteLine("----- Listado de Pedidos -----");
            foreach (var pedido in _pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}, Cliente: {pedido.Cliente}, Estado: {pedido.Estado}");
            }
        }
    }

}
