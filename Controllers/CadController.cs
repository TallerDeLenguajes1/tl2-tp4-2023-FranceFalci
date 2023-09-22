using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CadeteriaController : ControllerBase
{
  private Cadeteria cadeteria;

  private readonly ILogger<CadeteriaController> _logger;

  public CadeteriaController(ILogger<CadeteriaController> logger)
  {
    _logger = logger;
    cadeteria = Cadeteria.GetCadeteria();
  }

  [HttpGet]
  public ActionResult<string> GetNombreCadeteria()
  {
    return Ok(cadeteria.Nombre);
  }

  [HttpGet]
  [Route("Pedidos")]
  public ActionResult<IEnumerable<Pedido>> GetPedidos()
  {
    var pedidos = cadeteria.DevolverPedidos();
    return Ok(pedidos);
  }

  [HttpPost("AddPedido")]
  public ActionResult<Pedido> PostPedido(Pedido pedido)
  {
    var nuevoPedido = cadeteria.AgregarPedido(pedido);
    return Ok(nuevoPedido);
  }

  [HttpPut("UpdatePedido")]
  public ActionResult<Pedido> PutPedido(Pedido pedido)
  {
    var pedidoModificado = cadeteria.ModificarPedido(pedido);
    return Ok(pedidoModificado);
  }

  [HttpGet]
  [Route("Cadetes")]
  public ActionResult<IEnumerable<Pedido>> GetCadetes()
  {
    var cadetes = cadeteria.getCadetes();
    return Ok(cadetes);
  }

  [HttpPost("AddCadete")]
  public ActionResult<Cadete> PostCadete(Cadete cadete)
  {
    var nuevoCadete = cadeteria.AgregarCadete(cadete);
    return Ok(cadete);
  }

  [HttpPut("AsignarPedido")]
  public ActionResult<Pedido> AsignarPedido(int idPedido, int idCadete)
  {
    var pedidoAsignado = cadeteria.asignarPedido(idPedido, idCadete);
    return Ok(pedidoAsignado);
  }
}
