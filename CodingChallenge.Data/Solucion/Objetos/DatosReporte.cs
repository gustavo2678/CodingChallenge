namespace CodingChallenge.Data.Solucion.Objetos
{
    public class DatosReporte
    {
        private string nombre;

        private int cantidad;

        private decimal area;

        private decimal perimetro;

        public DatosReporte(string nombre, int cantidad, decimal area, decimal perimetro)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Area = area;
            this.Perimetro = perimetro;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Area { get => area; set => area = value; }
        public decimal Perimetro { get => perimetro; set => perimetro = value; }

        public override string ToString()
        {
            return $"{cantidad}  {Nombre} | " + Res.Area + $" {area:#.##} | " + Res.Perimetro + $" {perimetro:#.##} <br/>"; 
        }
    }
}
