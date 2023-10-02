using CodingChallenge.Data.Solucion.CreadorFiguras;
using CodingChallenge.Data.Solucion.Figuras;
using CodingChallenge.Data.Solucion.Objetos;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.Solucion.Impresion
{
    public static class DatosImpresion
    {
        public static IEnumerable<DatosReporte> ObtenerDatosImpresion(List<FormaGeometrica> listaForma)
        {
           var listaDeListasDeFormas = SepararFigurasEnListas(listaForma);           

            foreach (var item in listaDeListasDeFormas)
            {                
                var linea = ObtenerDatosReporte(item);               

                yield return linea;
            }
            
        }

        private static IEnumerable<List<FormaGeometrica>> SepararFigurasEnListas(List<FormaGeometrica> listaForma)
        {
            var agrupada = listaForma.GroupBy(x => x.Tipo);            

            foreach (var item in agrupada)
            {                
                yield return listaForma.Where(x => x.Tipo == item.Key).ToList();
            }
            
        }

        private static DatosReporte ObtenerDatosReporte(List<FormaGeometrica> lista)
        { 
            var cantidad = lista.Count;

            decimal area = 0; decimal perimetro = 0;

            var formaNombre = string.Empty;

            foreach (var figura in lista)
            {
                var creador = new CrearFiguraGeometrica(figura.Tipo, figura.Lado);                

                var objeto = creador.GetFigura();

                if (string.IsNullOrWhiteSpace(formaNombre)) formaNombre = objeto.TraducirForma(cantidad);

                area += objeto.CalcularArea();

                perimetro += objeto.CalcularPerimetro();                

            }

            var datosReporte = new DatosReporte(formaNombre, cantidad, area, perimetro);

            return datosReporte;
        }
       
    }
}
