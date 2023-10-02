using CodingChallenge.Data.Solucion.Enum;
using CodingChallenge.Data.Solucion.Figuras;
using CodingChallenge.Data.Solucion.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Solucion.Impresion
{
    public static class Impresion
    {
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            if (ValidarIdioma(idioma))
            {
                var listaReporte = DatosImpresion.ObtenerDatosImpresion(formas);

                var sb = ArmarReporte(listaReporte, idioma);

                return sb;
            }            

            return "Error";
        }

        private static bool ValidarIdioma(int idioma)
        {
            var result = true;

            if (!System.Enum.IsDefined(typeof(EnumIdiomas), idioma))
                result = false;

            return result;
        }      

        private static string ArmarReporte(IEnumerable<DatosReporte> datosReporte, int idioma)
        {
            SeleccionarIdioma(idioma);

            var sb = new StringBuilder();

            if (!datosReporte.Any())
            {
                sb = AgregarReporteVacio(sb);
                return sb.ToString();
            }

            sb = AgregarReporteForma(datosReporte, sb);

            sb = AgregarTotal(datosReporte, sb);

            return sb.ToString();
        }

        private static StringBuilder AgregarReporteVacio(StringBuilder sb)
        {
            sb.Append($"<h1>{Res.ListaVaciaFormas}!</h1>");
            return sb;
        }

        private static StringBuilder AgregarReporteForma(IEnumerable<DatosReporte> datosReporte, StringBuilder sb)
        {
            sb.Append($"<h1>{Res.ReporteDeFormas}</h1>");
            foreach (var reporte in datosReporte)
            {
                sb.Append(reporte.ToString());
            }

            return sb;
        }

        private static StringBuilder AgregarTotal(IEnumerable<DatosReporte> datosReporte, StringBuilder sb)
        {
            var cantidadForma = datosReporte.Sum(x => x.Cantidad);
            var totalPerimetro = datosReporte.Sum(x => x.Perimetro).ToString("#.##");
            var totalArea = datosReporte.Sum(x => x.Area).ToString("#.##");

            sb.Append("TOTAL:<br/>");
            sb.Append($"{cantidadForma} " + Res.Formas + " " + Res.Perimetro + $" {totalPerimetro} " + Res.Area + $" {totalArea}");

            return sb;
        }

        private static void SeleccionarIdioma(int idioma)
        {
            var region = string.Empty;
            switch (idioma)
            {
                case 2:
                    region = "en-US";
                    break;
                case 3: region = "fr-FR";
                    break;
                default:
                    break;
            }

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(region);
        }


    }
}
