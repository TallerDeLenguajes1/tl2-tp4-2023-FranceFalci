namespace Web_Api;

public class Pedido
{
  private int _nro;
  private string _observacion;
  private int idCadete;

  private int estado;
  public int Nro { get => _nro; set => _nro = value; }
  public string Observacion { get => _observacion; set => _observacion = value; }
  public int Estado { get => estado; set => estado = value; }
  public int IdCadete { get => idCadete; set => idCadete = value; }
}