using Microsoft.AspNetCore.Mvc;
using TesteJSL.Models;

namespace TesteJSL.Controllers
{
    public class PedidoItensController: Controller
    {
        private readonly Contexto _context;

        public PedidoItensController(Contexto context)
        {
            _context = context;
        }

        // GET: Itens do Pedido
        public ActionResult ListarItensPedido(int id)
        {
            var lista = _context.PedidoItens.Where(m => m.PedidoId == id).ToList();
            ViewBag.Pedido = id;
            return PartialView(lista);
        }

        // Post: Gravar Itens do Pedido
        public ActionResult GravarItensPedido(int idPedido, int idProduto, int quantidade, float vlrUnitario, float vlrTotal)
        {
            var lista = _context.PedidoItens.Where(m => m.PedidoId == idPedido).ToList();
            ViewBag.Pedido = idPedido;
            return PartialView(lista);
        }
    }
}
