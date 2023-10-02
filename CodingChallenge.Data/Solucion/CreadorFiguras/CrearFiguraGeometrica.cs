
using CodingChallenge.Data.Solucion.Figuras;
using CodingChallenge.Data.Solucion.Interfaces;

namespace CodingChallenge.Data.Solucion.CreadorFiguras
{
    //CreadorConcreto
    public class CrearFiguraGeometrica : FiguraGeometrica
    {
        private int _tipo;
        private decimal _lado;       

        public CrearFiguraGeometrica(int tipo, decimal lado)
        {
            _tipo = tipo;
            _lado = lado;
        }

        public override IFiguraCalculos GetFigura()
        {
            switch (_tipo)
            {
                case 1:
                    return new Cuadrado(_lado);
                case 2:
                    return new Circulo(_lado);
                case 3:
                    return new Triangulo(_lado);
                case 4:
                    return new Trapecio(_lado);
                case 5:
                    return new Rectangulo(_lado);
                default:
                    return null;
            }
        }
    }
}
