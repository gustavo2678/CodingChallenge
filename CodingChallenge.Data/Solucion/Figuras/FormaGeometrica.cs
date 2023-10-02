using CodingChallenge.Data.Solucion.Enum;

namespace CodingChallenge.Data.Solucion.Figuras
{
    public class FormaGeometrica
    {
        private int _tipo;
        private decimal _lado;        

        public FormaGeometrica(EnumFiguras figura, decimal ancho)
        {
            Tipo = (int)figura;
            _lado = ancho;
        }

        public int Tipo { get => _tipo; set => _tipo = value; }
        public decimal Lado { get => _lado; set => _lado = value; }
    }
}
