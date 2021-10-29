namespace Dominio
{
  public class Precio
  {
    public int PrecioId { get; set; }
    public decimal PrecioActualValue { get; set; }
    public decimal Promocional { get; set; }
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
  }
}