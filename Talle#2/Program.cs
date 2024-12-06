using Talle_2.Business;
using Talle_2.Entities;


// Caso #1

var gestor = GestorPedidos.Instancia;

var builder = new ProductoBuilder("Ropa");
var producto = builder.SetColor("Azul")
                      .SetTela("Algodón")
                      .Build();

var pedido = new Pedido { Cliente = "Andres Pertuz" };
pedido.Productos.Add(producto);

int pedidoId = gestor.AgregarPedido(pedido);
gestor.ActualizarEstadoPedido(pedidoId, "Procesado");


// Caso 2
var camiseta = new Ropa
{
    Nombre = "Camiseta Deportiva",
    Categoria = new()
    {
        Nombre = "Ropa"
    },
    Color = "Rojo",
    Tela = "Poliéster",
    Talla = "M",
    Marca = "Adidas"
};

// Pedido Orginal
var pedidoOriginal = new Pedido
{
    Cliente = "Maria Diaz",
    Productos = [camiseta]
};
gestor.AgregarPedido(pedidoOriginal);


// Pedido clonado
var camisetaNueva = camiseta.Clonar();
(camisetaNueva as Ropa).Color = "Verde";

var pedidoClonado = new Pedido
{
    Cliente = "María Pérez",
    Productos = [camisetaNueva]
};
pedidoId = gestor.AgregarPedido(pedidoClonado);
gestor.ActualizarEstadoPedido(pedidoId, "Entregado");



gestor.MostrarPedidos();