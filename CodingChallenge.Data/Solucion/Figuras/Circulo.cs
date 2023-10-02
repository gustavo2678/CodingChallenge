using CodingChallenge.Data.Solucion.Interfaces;
using System;

namespace CodingChallenge.Data.Solucion.Figuras
{
    //Producto Concreto
    public class Circulo : IFiguraCalculos
    {
        private decimal _lado;
        public Circulo(decimal lado) 
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Res.Circulo : Res.Circulos;
        }
    }
}
