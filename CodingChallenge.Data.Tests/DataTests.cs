//using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Solucion.Enum;
using CodingChallenge.Data.Solucion.Impresion;
using NUnit.Framework;
using System.Collections.Generic;
using CodingChallenge.Data.Solucion.Figuras;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {      

        [TestCase]
        public void TestResumenCuadradoEnCastellano()
        {
            var cuadrado = new List<FormaGeometrica> { new FormaGeometrica(EnumFiguras.Cuadrado, 5) };

            var resumen = Impresion.Imprimir(cuadrado, 1);

            var textoVerificar = "<h1>Reporte de Formas</h1>1  Cuadrado | Area 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Area 25";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenCuadradoEnIngles()
        {
            var cuadrado = new List<FormaGeometrica> { new FormaGeometrica(EnumFiguras.Cuadrado, 5) };

            var resumen = Impresion.Imprimir(cuadrado, 2);

            var textoVerificar = "<h1>Shapes report</h1>1  Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 Formas Perimeter 20 Area 25";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenCuadradoEnFrances()
        {
            var cuadrado = new List<FormaGeometrica> { new FormaGeometrica(EnumFiguras.Cuadrado, 5) };

            var resumen = Impresion.Imprimir(cuadrado, 3);

            var textoVerificar = "<h1>Rapport de formulaires</h1>1  Carré | Zone 25 | Périmètre 20 <br/>TOTAL:<br/>1 Formes Périmètre 20 Zone 25";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaCastellano()
        {
            var formas = new List<FormaGeometrica> {  };

            var resumen = Impresion.Imprimir(formas, 1);

            var textoVerificar = "<h1>Lista vacía de formas!</h1>";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaIngles()
        {
            var formas = new List<FormaGeometrica> { };

            var resumen = Impresion.Imprimir(formas, 2);

            var textoVerificar = "<h1>Empty list of shapes!</h1>";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaFrances()
        {
            var formas = new List<FormaGeometrica> { };

            var resumen = Impresion.Imprimir(formas, 3);

            var textoVerificar = "<h1>Liste de formes vide!</h1>";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaTodasLasFigurasCastellano()
        {
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

            var resumen = Impresion.Imprimir(formas, 1);

            var textoVerificar =
                "<h1>Reporte de Formas</h1>2  Cuadrados | Area 29 | Perímetro 28 <br/>2  Circulos | Area 13,01 | Perímetro 18,06 " +
                "<br/>3  Triangulos | Area 49,64 | Perímetro 51,6 <br/>2  Trapecios | Area 85 | Perímetro 52 <br/>1  Rectangulo | Area 4 | Perímetro 8 " +
                "<br/>TOTAL:<br/>10 Formas Perímetro 157,66 Area 180,65";

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaTodasLasFigurasIngles()
        {
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

            var resumen = Impresion.Imprimir(formas, 2);

            var textoVerificar =
                "<h1>Shapes report</h1>2  Squares | Area 29 | Perimeter 28 <br/>2  Circles | Area 13,01 | Perimeter 18,06 " +
                "<br/>3  Triangles | Area 49,64 | Perimeter 51,6 <br/>2  Trapezoids | Area 85 | Perimeter 52 <br/>1  Rectangle | Area 4 | Perimeter 8 " +
                "<br/>TOTAL:<br/>10 Formas Perimeter 157,66 Area 180,65";
                

            Assert.AreEqual(textoVerificar, resumen);
        }

        [TestCase]
        public void TestResumenListaTodasLasFigurasFrances()
        {
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

            var resumen = Impresion.Imprimir(formas, 3);

            var textoVerificar = "<h1>Rapport de formulaires</h1>2  Carrés | Zone 29 | Périmètre 28 <br/>2  Cercles | Zone 13,01 | Périmètre 18,06 " +
                "<br/>3  Triangles | Zone 49,64 | Périmètre 51,6 <br/>2  Trapèzes | Zone 85 | Périmètre 52 <br/>1  Rectangle | Zone 4 | Périmètre 8 " +
                "<br/>TOTAL:<br/>10 Formes Périmètre 157,66 Zone 180,65";               


            Assert.AreEqual(textoVerificar, resumen);
        }
    }
}
