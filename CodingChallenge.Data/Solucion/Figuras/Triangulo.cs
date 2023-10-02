using CodingChallenge.Data.Solucion.Interfaces;
using System;

namespace CodingChallenge.Data.Solucion.Figuras
{
    public class Triangulo : IFiguraCalculos
    {
        private decimal _lado;
        public Triangulo(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Res.Triangulo : Res.Triangulos;
        }
    }
}
