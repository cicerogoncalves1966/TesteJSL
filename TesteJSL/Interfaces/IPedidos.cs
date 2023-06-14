using System.Web.Mvc;
using TesteJSL.Models;

namespace TesteJSL.Interfaces
{
    public interface IPedidos
    {
        ActionResult Create(Pedido pedido);
    }
}
