using CodingChallenge.Data.Solucion.Interfaces;

namespace CodingChallenge.Data.Solucion.Figuras
{
    public class Cuadrado : IFiguraCalculos
    {
        private decimal _lado;
        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Res.Cuadrado : Res.Cuadrados;
        }
    }
}
