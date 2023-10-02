namespace CodingChallenge.Data.Solucion.Interfaces
{
    //Producto
    public interface IFiguraCalculos
    {
        decimal CalcularArea();

        decimal CalcularPerimetro();

        string TraducirForma(int cantidad);
    }
}
