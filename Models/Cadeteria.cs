using System.Collections.Generic;
using System.Linq;

namespace Web_Api;


public class Cadeteria
{

  private static Cadeteria cadeteria;
  private List<Cadete> listaCadetes;


  public static Cadeteria GetCadeteria()
  {
    if (cadeteria == null)
    {
      cadeteria = new Cadeteria();
    }
    return cadeteria;
  }

  private List<Pedido> _pedidos;
  private string _nombre;

  public string Nombre { get => _nombre; set => _nombre = value; }

  public Cadeteria()
  {
    _pedidos = new List<Pedido>();
    listaCadetes = new List<Cadete>();
    _nombre = "Cadeteria la prueba";
    _pedidos.Add(new Pedido
    {
      Nro = 1,
      Observacion = " Es el primer pedido"
    });
    _pedidos.Add(new Pedido
    {
      Nro = 2,
      Observacion = " Es el segundo pedido"
    });
    _pedidos.Add(new Pedido
    {
      Nro = 3,
      Observacion = " Es el tercer pedido"
    });

    listaCadetes.Add(new Cadete
    {
      Id = 1,
      Nombre = "cadete 1",
    });
    listaCadetes.Add(new Cadete
    {
      Id = 2,
      Nombre = "cadete 2",
    });
  }

  public Pedido GetPedido(int nro)
  {
    return _pedidos.FirstOrDefault(t => t.Nro == nro);
  }


  public List<Cadete> getCadetes()
  {
    return listaCadetes;
  }

  public List<Pedido> DevolverPedidos()
  {
    return _pedidos;
  }


  public Pedido AgregarPedido(Pedido pedido)
  {
    _pedidos.Add(pedido);
    pedido.Nro = _pedidos.Count;
    return pedido;
  }

  public Cadete AgregarCadete(Cadete cadete)
  {
    listaCadetes.Add(cadete);
    cadete.Id = listaCadetes.Count;
    return cadete;
  }
  public Pedido ModificarPedido(Pedido pedido)
  {
    var pedidoAModificar = _pedidos.FirstOrDefault(t => t.Nro == pedido.Nro);
    pedidoAModificar.Observacion = pedido.Observacion;
    return pedidoAModificar;
  }

  public Pedido asignarPedido(int idPedido, int idCadete)
  {
    var pedidoAAsingar = _pedidos.FirstOrDefault(t => t.Nro == idPedido);
    if (pedidoAAsingar != null)
    {
      pedidoAAsingar.IdCadete = idCadete;
      return pedidoAAsingar;
    }
    return null;
  }

}