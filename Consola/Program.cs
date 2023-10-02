// See https://aka.ms/new-console-template for more information
using CodingChallenge.Data.Solucion.Enum;
using CodingChallenge.Data.Solucion.Figuras;
using CodingChallenge.Data.Solucion.Impresion;
//using CodingChallenge.Data.Classes;

Console.WriteLine("Hello, World!");

var formas = new List<FormaGeometrica>
            {
               new FormaGeometrica(EnumFiguras.Cuadrado, 5),
                new FormaGeometrica(EnumFiguras.Circulo, 3),
                new FormaGeometrica(EnumFiguras.Triangulo, 4),
                new FormaGeometrica(EnumFiguras.Cuadrado, 2),
                new FormaGeometrica(EnumFiguras.Triangulo, 9),
                new FormaGeometrica(EnumFiguras.Circulo, 2.75m),
                new FormaGeometrica(EnumFiguras.Triangulo, 4.2m),
                new FormaGeometrica(EnumFiguras.Trapecio, 6),
                new FormaGeometrica(EnumFiguras.Rectangulo, 2),
                new FormaGeometrica(EnumFiguras.Trapecio, 7)
            };

var reporte = Impresion.Imprimir(formas,4);

Console.WriteLine(reporte.ToString());


